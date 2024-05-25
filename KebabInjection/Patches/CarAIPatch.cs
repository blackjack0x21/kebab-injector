using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KebabInjector.Patches
{
    [HarmonyPatch(typeof(CarAI_New))]
    internal class CarAIPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        static void CarSpeedPatch(ref float ___speed, ref float ___angularSpeed)
        {
            ___speed = 150f;
            ___angularSpeed = 20f;
        }
    }
}
