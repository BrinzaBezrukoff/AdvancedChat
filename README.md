# AdvancedChat
##### AdvancedChat is Unturned plugin for Rocket.This plugin is similar to the ChatControl plugin, but AdvancedChat is modified version of ChatControl, I did not want to steal the ChatControl plugin idea, I just modified it!
---
## Commands
- ### Mute command
  Use for **mute** player in chat
  - Syntax: /mute [player] [seconds] or /mute [player]
    - First usage mutes player for seconds
    - Second usage mutes player permanently
  - Permission: AdvancedChat.Mute
- ### Unmute command
  Use for **unmute** player in chat
  - Syntax: /umute [player]
  - Permission: AdvancedChat.Unmute
## Plugin systems
- ### Blacklisted words
  - If player message contains **blacklisted word**, message will not be sent
  - Also player, who used **blacklisted word** will get **warning**
- ### Warnings
  - If player has defined **warnings** count he will get:
    - Auto mute
    - Auto kick
    - Auto ban
## Plugin setup
- ### Permissions
  - AdvancedChat.Mute - /mute command permission
  - AdvancedChat.Unmute - /unmute command permission
  - AdvancedChat.BypassBadWords - allows use in chat **blacklisted words** for the player
  - AdvancedChat.BypassAutoMute - **Auto mute** punishment will not be applied to the player
  - AdvancedChat.BypassAutoKick - **Auto kick** punishment will not be applied to the player
  - AdvancedChat.BypassAutoBan - **Auto ban** punishment will not be applied to the player
- ### Configuration
  - BroadcastMute - if true plugin will announce about player's mute
  - BroadcastUnmute - if true plugin will announce about player's unmute
  - WarningsBeforeMute - how many warnings player need to get before plugin will **auto mute** him
  - WarningsBeforeKick - how many warnings player need to get before plugin will **auto kick** him
  - WarningsBeforeBan - how many warnings player need to get before plugin will **auto ban** him
  - AutoMuteDuration - duration of **auto mute**
  - AutoBanDuration - duration of **auto ban**
  - WordsBlackList - list of all **blacklisted words**
- ### Translations
  - kick_ban_reason - reason that will be marked, if player gets **auto kick/ban**
  - mute_broadcast - message that will be broadcast, if player gets mute (if **BroadcastMute** configuration true
    - {0} is a player name
    - {1} is mute time
  - permamute_broadcast - message that will be broadcast, if player gets mute permanently (if **BroadcastMute** configuration true)
    - {0} is a player name
  - unmute_boadcast - message that will be broadcast, if player gets unmute (if **BroadcastUnmute** configuration true)
    - {0} is a player name
  - you_in_mute - message that player will get if try to chat when he mutted
    - {0} is remaining mute time
  - you_use_badword - message that player will get if try to write message with **blacklisted word**
    - {0} is warnings that player had + 1 warning for **blacklisted word** using
    - {1} is warnings that player need to reach for get **automute**
  - player_not_found - error message, if you incorrect define player in /mute or /unmute commands
  - wrong_time - errror message, if you incorrect define time in /mute command (eg string instead number)
<hr>
- Plugin AdvancedChat created by Brinza Bezrukoff
- My Vk page: https://vk.com/brinza888
- My email: bezrukoff888@gmail.com