using HarmonyLib;

namespace BossWeapons
{
    [HarmonyPatch]
    internal class Patch
    {
        [HarmonyPatch(typeof(ItemDrop), nameof(ItemDrop.DropItem)), HarmonyPostfix]
        private void ItemDropm_onDropPatch(ItemDrop __instance)
        {
            if(__instance.name == "$item_JF_EikthurSpearLunchbox")
            {
                __instance.m_autoPickup = true;
            }
        }
    }
}
