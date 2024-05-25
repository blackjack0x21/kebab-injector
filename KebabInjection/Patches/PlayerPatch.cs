using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KebabInjector.Patches
{
    [HarmonyPatch(typeof(Player))]
    internal class PlayerPatch
    {
        [HarmonyPatch("Die")]
        [HarmonyPrefix]
        static bool DeathPatch()
        {
            return false;
        }
    }
}
