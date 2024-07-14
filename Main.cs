using Rocket.Core.Plugins;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using Rocket.Unturned;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Core.Logging;

namespace LifeControl
{
    public class Main : RocketPlugin<LifeConfig>
    {
        protected override void Load()
        {
            Logger.Log("Nel Plugins", ConsoleColor.Red);
            Logger.Log("Support Discord", ConsoleColor.Cyan);
            Logger.Log("https://discord.gg/wSt3Jsx2bC", ConsoleColor.Cyan);
            Logger.Log("░░░░░░░░░░░░░░░░░░░░░▄▀░░▌", ConsoleColor.Red);
            Logger.Log("░░░░░░░░░░░░░░░░░░░▄▀▐░░░▌", ConsoleColor.Red);
            Logger.Log("░░░░░░░░░░░░░░░░▄▀▀▒▐▒░░░▌", ConsoleColor.Red);
            Logger.Log("░░░░░▄▀▀▄░░░▄▄▀▀▒▒▒▒▌▒▒░░▌", ConsoleColor.Red);
            Logger.Log("░░░░▐▒░░░▀▄▀▒▒▒▒▒▒▒▒▒▒▒▒▒█", ConsoleColor.Red);
            Logger.Log("░░░░▌▒░░░░▒▀▄▒▒▒▒▒▒▒▒▒▒▒▒▒▀▄", ConsoleColor.Red);
            Logger.Log("░░░░▐▒░░░░░▒▒▒▒▒▒▒▒▒▌▒▐▒▒▒▒▒▀▄", ConsoleColor.Red);
            Logger.Log("░░░░▌▀▄░░▒▒▒▒▒▒▒▒▐▒▒▒▌▒▌▒▄▄▒▒▐", ConsoleColor.Red);
            Logger.Log("░░░▌▌▒▒▀▒▒▒▒▒▒▒▒▒▒▐▒▒▒▒▒█▄█▌▒▒▌", ConsoleColor.Red);
            Logger.Log("░▄▀▒▐▒▒▒▒▒▒▒▒▒▒▒▄▀█▌▒▒▒▒▒▀▀▒▒▐░░░▄", ConsoleColor.Red);
            Logger.Log("▀▒▒▒▒▌▒▒▒▒▒▒▒▄▒▐███▌▄▒▒▒▒▒▒▒▄▀▀▀▀", ConsoleColor.Red);
            Logger.Log("▒▒▒▒▒▐▒▒▒▒▒▄▀▒▒▒▀▀▀▒▒▒▒▄█▀░░▒▌▀▀▄▄", ConsoleColor.Red);
            Logger.Log("▒▒▒▒▒▒█▒▄▄▀▒▒▒▒▒▒▒▒▒▒▒░░▐▒▀▄▀▄░░░░▀", ConsoleColor.Red);
            Logger.Log("▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▄▒▒▒▒▄▀▒▒▒▌░░▀▄", ConsoleColor.Red);
            Logger.Log("▒▒▒▒▒▒▒▒▀▄▒▒▒▒▒▒▒▒▀▀▀▀▒▒▒▄▀", ConsoleColor.Red);
            Logger.Log("Nel Plugins", ConsoleColor.Red);
            Logger.Log("Support Discord", ConsoleColor.Cyan);
            Logger.Log("https://discord.gg/wSt3Jsx2bC", ConsoleColor.Cyan);
            Logger.Log("Life Control Loaded", ConsoleColor.Blue);
            U.Events.OnPlayerConnected += NelPlayerConnected;
            UnturnedPlayerEvents.OnPlayerUpdateHealth += UnturnedPlayerEvents_OnPlayerUpdateHealth;
            UnturnedPlayerEvents.OnPlayerUpdateFood += UnturnedPlayerEvents_OnPlayerUpdateFood;
            UnturnedPlayerEvents.OnPlayerUpdateWater += UnturnedPlayerEvents_OnPlayerUpdateWater;
            UnturnedPlayerEvents.OnPlayerUpdateStamina += UnturnedPlayerEvents_OnPlayerUpdateStamina;
            UnturnedPlayerEvents.OnPlayerUpdateVirus += UnturnedPlayerEvents_OnPlayerUpdateVirus;
            UnturnedPlayerEvents.OnPlayerChatted += NelChat;
        }
        private void NelChat(UnturnedPlayer player, ref UnityEngine.Color color, string message, EChatMode chatMode, ref bool cancel)
        {
            var c = Configuration.Instance;
            if (c.DisableChat == true)
            {
                cancel = true;
            }
            else
            {
                cancel = false;
            }
        }
        private void NelPlayerConnected(UnturnedPlayer player)
        {
            var c = Configuration.Instance;
            if (c.DisableStatusIcons == true)
            {
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowStatusIcons);
            }
            else
            {
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowStatusIcons);
            }
            if (c.DisableVehicleHud == true)
            {
                player.Player.disablePluginWidgetFlag((EPluginWidgetFlags)8192);
            }
            else
            {
                player.Player.enablePluginWidgetFlag((EPluginWidgetFlags)8192);
            }

            if (c.DisableHealthHud == true)
            {
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowHealth);
            }
            else
            {
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowHealth);
            }

            if (c.DisableFoodHud == true)
            {
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowFood);
            }
            else
            {
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowFood);
            }

            if (c.DisableWaterHud == true)
            {
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowWater);
            }
            else
            {
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowWater);
            }

            if (c.DisableStaminaHud == true)
            {
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowStamina);
            }
            else
            {
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowStamina);
            }

            if (c.DisableVirusHud == true)
            {
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowVirus);
            }
            else
            {
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowVirus);
            }

            if (c.DisableOxygenHud == true)
            {
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowOxygen);
            }
            else
            {
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowOxygen);
            }
        }
            private void UnturnedPlayerEvents_OnPlayerUpdateVirus(Rocket.Unturned.Player.UnturnedPlayer player, byte virus)
        {
            if (Configuration.Instance.DisableVirus == true)
            {
                if (player.Infection >= 50)
                {
                    return;
                }
                player.Player.life.serverModifyVirus(100f);
            }
        }

        private void UnturnedPlayerEvents_OnPlayerUpdateStamina(Rocket.Unturned.Player.UnturnedPlayer player, byte stamina)
        {
            if (Configuration.Instance.InfStamina == true)
            {
                if (player.Stamina >= 40)
                {
                    return;
                }
                player.Player.life.serverModifyStamina(100f);
            }
        }

        private void UnturnedPlayerEvents_OnPlayerUpdateWater(Rocket.Unturned.Player.UnturnedPlayer player, byte water)
        {
            if (Configuration.Instance.InfWater == true)
            {
                if (player.Thirst >= 50)
                {
                    return;
                }
                player.Player.life.serverModifyWater(100f);
            }
        }

        private void UnturnedPlayerEvents_OnPlayerUpdateFood(Rocket.Unturned.Player.UnturnedPlayer player, byte food)
        {
            if (Configuration.Instance.InfFood == true)
            {
                if (player.Hunger >= 50)
                {
                    return;
                }
                player.Player.life.serverModifyFood(100f);
            }
        }

        private void UnturnedPlayerEvents_OnPlayerUpdateHealth(Rocket.Unturned.Player.UnturnedPlayer player, byte health)
        {
            if (Configuration.Instance.InfHealth == true)
            {
                if (player.Health >= 80)
                {
                    return;
                }
                player.Player.life.serverModifyHealth(100f);
            }
        }

        protected override void Unload()
        {
            Logger.Log("Nel Plugins", ConsoleColor.Red);
            Logger.Log("Life Control Loaded", ConsoleColor.Blue);
            UnturnedPlayerEvents.OnPlayerUpdateHealth -= UnturnedPlayerEvents_OnPlayerUpdateHealth;
            UnturnedPlayerEvents.OnPlayerUpdateFood -= UnturnedPlayerEvents_OnPlayerUpdateFood;
            UnturnedPlayerEvents.OnPlayerUpdateWater -= UnturnedPlayerEvents_OnPlayerUpdateWater;
            UnturnedPlayerEvents.OnPlayerUpdateStamina -= UnturnedPlayerEvents_OnPlayerUpdateStamina;
            UnturnedPlayerEvents.OnPlayerUpdateVirus -= UnturnedPlayerEvents_OnPlayerUpdateVirus;
        }
    }
}
