using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KebabInjector.Patches
{
    [HarmonyPatch(typeof(PlayerMovement))]
    internal class PlayerMovementPatch
    {
        /*[HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void JumpInputPatch(ref float ___jumpForce)
        {
            ___jumpForce = 70f; 
        }*/

        [HarmonyPatch("JumpInput")]
        [HarmonyPrefix]
        static void NoCooldownPatch(ref bool ___canJump, ref bool ___canJumpSlide, ref float ___jumpCooldown, ref float ___slideCooldown)
        {
            ___canJump = true;
            ___canJumpSlide = true;
            ___jumpCooldown = 0f;
            ___slideCooldown = 0f;
        }
    }
}
