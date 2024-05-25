using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using KebabInjector.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KebabInjector
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class KebabInjector : BaseUnityPlugin
    {
        private const string modGUID = "Blackjack.KebabInjector";
        private const string modName = "Kebab Injector";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        internal static KebabInjector Instance;

        internal static ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            mls.LogInfo("KebabInjector Started");

            harmony.PatchAll(typeof(KebabInjector));
            harmony.PatchAll(typeof(MeatRotisseriePatch));
            harmony.PatchAll(typeof(PlayerPatch));
            harmony.PatchAll(typeof(PlayerMovementPatch));
            harmony.PatchAll(typeof(ShaormaAIPach));
            harmony.PatchAll(typeof(CarAIPatch));
        }
    }
}