using HarmonyLib;
using PathCamController = ABI_RC.Core.IO.CVRPathCamController;

namespace CVR.NumpadFreedomMod.Patches; 
internal class CVRPathCamController {

  [HarmonyPatch(typeof(PathCamController), "Start")]
  class Start {
    static void Postfix(PathCamController __instance) {
      __instance.enabled = !Env.Enabled;
    }
  }
}
