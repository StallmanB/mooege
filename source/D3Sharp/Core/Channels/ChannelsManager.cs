﻿/*
 * Copyright (C) 2011 D3Sharp Project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System.Collections.Generic;

namespace D3Sharp.Core.Channels
{
    public static class ChannelsManager
    {
        private readonly static Dictionary<ulong, Channel> Channels =
            new Dictionary<ulong, Channel>();

        // We'll start at a high value to avoid ID conflicts for now
        private static ulong _channelgen = 100000;

        public static Channel CreateNewChannel()
        {
            var channel = new Channel(_channelgen++);
            Channels.Add(channel.ID, channel);
            return channel;
        }
        
        public static Channel DeleteChannel(ulong id) {
            throw new System.NotImplementedException();
            // TODO: Mapping removal should be done in client or mayhaps the ID controller
        }
    }
}