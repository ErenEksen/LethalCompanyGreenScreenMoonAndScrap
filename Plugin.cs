using BepInEx;
using BepInEx.Logging;

namespace GreenScreenMoon
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        const string PLUGIN_GUID = "Axis.GreenScreenMoon";
        const string PLUGIN_NAME = "Green Screen Moon";
        const string PLUGIN_VERSION = "1.0.0b-1";
        internal ManualLogSource mls;
        private static Plugin Instance;
        
        private void Awake()
        {
            if(Instance == null) Instance = this;

            mls = BepInEx.Logging.Logger.CreateLogSource(PLUGIN_GUID);
            mls.LogInfo($"{PLUGIN_NAME} loaded successfully!");
        }
    }
}
