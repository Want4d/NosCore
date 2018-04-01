﻿using NosCore.Core.Serializing;
using NosCore.Domain.Interaction;

namespace NosCore.Packets.ServerPackets
{
    [PacketHeader("failc")]
    public class FailcPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public LoginFailType Type { get; set; }

        #endregion
    }
}