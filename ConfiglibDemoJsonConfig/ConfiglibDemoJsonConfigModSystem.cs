using HarmonyLib;
using somniumtweaks;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace ConfiglibDemoJsonConfig
{
    public class ConfiglibDemoJsonConfigModSystem : ModSystem
    {
        private Harmony _harmony;

        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            _harmony = new Harmony("somniumconfiglibdemojsonconfig_harmonypatches");
            _harmony.PatchAll();

            // Initialize mod settings: Read or create json configuration file.
            try
            {
                ModConfig file;
                if ((file = api.LoadModConfig<ModConfig>("SomniumConfiglibDemoJsonConfig.json")) == null)
                {
                    api.StoreModConfig<ModConfig>(ModConfig.Instance, "SomniumConfiglibDemoJsonConfig.json");
                }
                else
                {
                    ModConfig.Instance = file;
                }
            }
            catch
            {
                api.StoreModConfig<ModConfig>(ModConfig.Instance, "SomniumConfiglibDemoJsonConfig.json");
            }

            // Register modded Axe class
            api.RegisterItemClass("somniumfixaxe", typeof(SomniumFixAxe));
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            api.Logger.Notification("Hello from template mod server side: " + Lang.Get("configlibdemojsonconfig:hello"));
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            api.Logger.Notification("Hello from template mod client side: " + Lang.Get("configlibdemojsonconfig:hello"));
        }
    }
}
