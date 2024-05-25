using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KebabInjector.Patches

{
    [HarmonyPatch(typeof(MeatRotisserie))]
    internal class MeatRotisseriePatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void RotisserieSpeedPatch(ref float ___rotationSpeed)
        {
            ___rotationSpeed = 100f;
        }
    }
}
