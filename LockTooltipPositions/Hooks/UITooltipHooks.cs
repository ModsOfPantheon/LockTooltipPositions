using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace LockTooltipPositions.Hooks;

// Maybe better to hook UIBuffTooltip::ClampToWindow here, as that's likely the final position update
[HarmonyPatch(typeof(UIBuffTooltip), nameof(UIBuffTooltip.LateUpdate))]
public class UITooltipHooks
{
    private static void Postfix(UIBuffTooltip __instance)
    {
        __instance.RectTransform.anchoredPosition = new Vector2(100, 100);
    }
}