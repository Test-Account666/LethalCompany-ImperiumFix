using HarmonyLib;
using LethalCompanyInputUtils.Api;
using static Imperium.Imperium;

namespace ImperiumFix.Patches;

[HarmonyPatch(typeof(StartOfRound), nameof(StartOfRound.Awake))]
public class StartOfRoundPatch {
    [HarmonyPatch]
    [HarmonyPostfix]
    public static void ReinitializeKeybinds() {
        ImperiumFix.Logger.LogInfo("Reloading keybinds...");

        var methodInfo = AccessTools.Method(typeof(LcInputActions), "Load");
        methodInfo.Invoke(InputBindings.BaseMap, null);
        methodInfo.Invoke(InputBindings.FreecamMap, null);
        methodInfo.Invoke(InputBindings.InterfaceMap, null);

        ImperiumFix.Logger.LogInfo("Done!");
    }
}