using BepInEx;
using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;

namespace JotunnModStub
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    internal class FeruxModTemplate : BaseUnityPlugin
    {
        public const string PluginGUID = "com.feruxiuvenis.feruxmodtemplate";
        public const string PluginName = "FeruxModTemplate";
        public const string PluginVersion = "1.0.0";
        
        public static CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

        private void Awake()
        {
            Jotunn.Logger.LogInfo("FeruxModTemplate has landed");
        }

        void AddItems()
        {
            // Clone a vanilla prefab as a starting point
            var item = new CustomItem("FERUXSWORD", "SwordIron", new ItemConfig {
                Name = "FERUX'S SWORD",
                Description = "A test item created for developers.",
                CraftingStation = CraftingStations.Forge
            });
            ItemManager.Instance.AddItem(item);
            PrefabManager.OnVanillaPrefabsAvailable -= AddItems;
        }
    }
}