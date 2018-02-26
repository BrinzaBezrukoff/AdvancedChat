﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using Rocket.Core.Plugins;

namespace AdvancedChat
{
    public class AdvancedChatConfig : IRocketPluginConfiguration
    {
        public bool BroadcastMute;
        public bool BroadcastUnmute;
        public int WarningsBeforeMute;
        public int WarningsBeforeKick;
        public int WarningsBeforeBan;
        public uint AutoMuteDuration;
        public uint AutoBanDuration;
        public List<string> WordsBlackList;

        public void LoadDefaults()
        {
            BroadcastMute = true;
            BroadcastUnmute = true;
            WarningsBeforeMute = 3;
            WarningsBeforeKick = 6;
            WarningsBeforeBan = 10;
            AutoMuteDuration = 60;
            AutoBanDuration = 3600;
            WordsBlackList = new List<string>() { "fuck", "suck", "bitch" };
        }
    }
}