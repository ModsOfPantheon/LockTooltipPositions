using MelonLoader;

namespace LockTooltipPositions;

public class ModMain : MelonMod
{
    public const string ModVersion = "1.0.0";

    public override void OnInitializeMelon()
    {
        var modCategory = MelonPreferences.CreateCategory(nameof(LockTooltipPositions));
        var xOffset = modCategory.CreateEntry("xOffset", 5000);
        var yOffset = modCategory.CreateEntry("yOffset", 200);

        Globals.xOffset = xOffset.Value;
        Globals.yOffset = yOffset.Value;
        
        modCategory.SaveToFile(false);
    }
}