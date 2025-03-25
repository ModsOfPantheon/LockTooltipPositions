using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace LockTooltipPositions.Hooks;

// Maybe better to hook UIBuffTooltip::ClampToWindow here, as that's likely the final position update
[HarmonyPatch(typeof(UIBuffTooltip), nameof(UIBuffTooltip.LateUpdate))]
public class UIBuffTooltipHook
{
    private static void Postfix(UIBuffTooltip __instance)
    {
        Globals.SetPosition(__instance.RectTransform);
        __instance.ClampToWindow();
    }
}

[HarmonyPatch(typeof(UIItemTooltip), nameof(UIItemTooltip.LateUpdate))]
public class UIItemTooltipHook
{
    private static void Postfix(UIItemTooltip __instance)
    {
        Globals.SetPosition(__instance.RectTransform);
        __instance.ClampToWindow();
    }
}

[HarmonyPatch(typeof(UIAbilityTooltip), nameof(UIAbilityTooltip.LateUpdate))]
public class UIAbilityTooltipHook
{
    private static void Postfix(UIAbilityTooltip __instance)
    {
        Globals.SetPosition(__instance.RectTransform);
        __instance.ClampToWindow();
    }
}