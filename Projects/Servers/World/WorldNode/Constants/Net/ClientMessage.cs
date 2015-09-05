// Copyright (c) Multi-Emu.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WorldNode.Constants.Net
{
    // Value '0x2000' means not updated/implemented
    public enum ClientMessage : ushort
    {
        RequestCemeteryList = 0x0957,
        ViolenceLevel = 0x0A76,

        #region Player
        LogoutRequest = 0x0C5E,
        #endregion

        #region PlayerGameEvent
        #endregion

        #region PlayerInventory
        #endregion

        #region PlayerMovement
        #endregion
    }
}
