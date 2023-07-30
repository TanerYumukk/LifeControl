using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeControl
{
    public class LifeConfig : IRocketPluginConfiguration
    {
        public bool InfHealth;
        public bool InfFood;
        public bool InfWater;
        public bool InfStamina;
        public bool DisableVirus;
        public bool DisableHealthHud;
        public bool DisableFoodHud;
        public bool DisableWaterHud;
        public bool DisableStaminaHud;
        public bool DisableVirusHud;
        public bool DisableOxygenHud;

        public void LoadDefaults()
        {
            InfHealth = true;
            InfFood = true;
            InfWater = true;
            InfStamina = true;
            DisableVirus = true;
            DisableHealthHud = false;
            DisableFoodHud = false;
            DisableWaterHud = false;
            DisableStaminaHud = false;
            DisableVirusHud = false;
            DisableOxygenHud = false;
        }
    }
}
