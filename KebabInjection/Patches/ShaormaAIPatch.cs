using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KebabInjector.Patches
{
    [HarmonyPatch(typeof(ShaormaAI))]
    internal class ShaormaAIPach
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void DropRatePatch(ref float ___dropRate, ref float ___sauceDropRate)
        {
            ___dropRate = 0f;
            ___sauceDropRate = 0f;
        }
    }
}
