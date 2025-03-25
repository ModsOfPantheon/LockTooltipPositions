using Il2CppSystem.Xml.Linq;
using UnityEngine;

namespace LockTooltipPositions;

public class Globals
{
    public static int xOffset = 0;
    public static int yOffset = 0;
    
    public static void SetPosition(RectTransform rectTransform)
    {
        // Pivot around bottom left corner to make it easier to position
        rectTransform.pivot = new Vector2(0, 0);
        
        // Anchor to bottom left corner instead of the center of the screen, makes the math a bit easier :D
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);

        rectTransform.anchoredPosition = new Vector2(xOffset, yOffset);
    }
}