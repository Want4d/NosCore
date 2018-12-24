﻿//  __  _  __    __   ___ __  ___ ___  
// |  \| |/__\ /' _/ / _//__\| _ \ __| 
// | | ' | \/ |`._`.| \_| \/ | v / _|  
// |_|\__|\__/ |___/ \__/\__/|_|_\___| 
// 
// Copyright (C) 2018 - NosCore
// 
// NosCore is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using NosCore.Core.Serializing;
using NosCore.Shared.Enumerations.Items;
using System.ComponentModel.DataAnnotations;

namespace NosCore.Packets.ClientPackets
{
    [PacketHeader("sl")]
    public class SpTransformPacket : PacketDefinition
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public int? TransportId { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public short? SpecialistDamage { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public short? SpecialistDefense { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public short? SpecialistElement { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public short? SpecialistHP { get; set; }

    }
}