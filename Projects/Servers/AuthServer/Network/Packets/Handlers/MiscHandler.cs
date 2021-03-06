﻿// Copyright (c) Multi-Emu.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using AuthServer.Attributes;
using AuthServer.Constants.Authentication;
using AuthServer.Constants.Net;
using AuthServer.Managers;
using AuthServer.Network.Sessions;
using Framework.Database;
using Framework.Database.Auth.Entities;
using Framework.Logging;
using Framework.Network.Packets;

namespace AuthServer.Network.Packets.Handlers
{
    class MiscHandler
    {
        [AuthMessage(AuthClientMessage.InformationRequest, AuthChannel.Authentication)]
        public static void OnInformationRequest(AuthPacket packet, Client client)
        {
            var session = client.Session;

            if (!Manager.GetState())
            {
                AuthHandler.SendAuthComplete(true, AuthResult.ServerBusy, client);
                return;
            }

            var game = packet.ReadFourCC();
            var os = packet.ReadFourCC();
            var language = packet.ReadFourCC();

            Log.Debug($"Program: {game}");
            Log.Debug($"Platform: {os}");
            Log.Debug($"Locale: {language}");

            var componentCount = packet.Read<int>(6);

            for (int i = 0; i < componentCount; i++)
            {
                var program = packet.ReadFourCC();
                var platform = packet.ReadFourCC();
                var build = packet.Read<int>(32);

                Log.Debug($"Program: {program}");
                Log.Debug($"Platform: {platform}");
                Log.Debug($"Locale: {build}");

                if (DB.Auth.Any<Component>(c => c.Program == program && c.Platform == platform && c.Build == build))
                    continue;

                if (!DB.Auth.Any<Component>(c => c.Program == program))
                {
                    AuthHandler.SendAuthComplete(true, AuthResult.InvalidProgram, client);
                    return;
                }

                if (!DB.Auth.Any<Component>(c => c.Platform == platform))
                {
                    AuthHandler.SendAuthComplete(true, AuthResult.InvalidPlatform, client);
                    return;
                }

                if (!DB.Auth.Any<Component>(c => c.Build == build))
                {
                    AuthHandler.SendAuthComplete(true, AuthResult.InvalidGameVersion, client);
                    return;
                }
            }

            var hasAccountName = packet.Read<bool>(1);

            if (hasAccountName)
            {
                var accountLength = packet.Read<int>(9) + 3;
                var accountName = packet.ReadString(accountLength);
                var account = DB.Auth.Single<Account>(a => a.Email == accountName);

                // First account lookup on database
                if ((session.Account = account) != null)
                {
                    // Assign the possible game accounts based on the game.
                    //session.GameAccounts.ForEach(ga => ga.OS = os);

                    // Save the last changes
                    // Needs testing...
                    // DB.Auth.Update<Account>(a => a.Id == account.Id, a => a.IP.Set(session.GetClientInfo()), a => a.Language.Set(language));

                    // Used for module identification.
                    client.Game = game;
                    client.OS = os;

                    AuthHandler.SendProofRequest(client);
                }
                else
                    AuthHandler.SendAuthComplete(true, AuthResult.BadLoginInformation, client);
            }
        }

        [AuthMessage(AuthClientMessage.Ping, AuthChannel.Connection)]
        public static void OnPing(AuthPacket packet, Client client)
        {
            var pong = new AuthPacket(AuthServerMessage.Pong, AuthChannel.Connection);

            client.SendPacket(pong);
        }

        [AuthMessage(AuthClientMessage.Disconnect, AuthChannel.Connection)]
        public static void OnDisconnect(AuthPacket packet, Client client)
        {
            Log.Debug($"Client '{client.ConnectionInfo}' disconnected.");

            Manager.SessionMgr.RemoveClient(client.Id);
        }
    }
}
