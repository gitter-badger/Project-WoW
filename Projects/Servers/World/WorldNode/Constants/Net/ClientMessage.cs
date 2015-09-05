// Copyright (c) Multi-Emu.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WorldNode.Constants.Net
{
    // Value '0x2000' means not updated/implemented
    public enum ClientMessage : ushort
    {
        #region Player
        LogoutRequest = 0x0C5E,
        ViolenceLevel = 0x0A76,
        #endregion

        #region PlayerGameEvent
        #endregion

        #region PlayerInventory
        #endregion

        #region PlayerMovement
        #endregion
    }
}
