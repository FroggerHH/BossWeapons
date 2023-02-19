using BepInEx;
using ItemManager;

namespace BossWeapons
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class Plugin : BaseUnityPlugin
    {
        internal const string ModName = "Frogger-BossWeapons", ModVersion = "0.0.2", ModGUID = "com.Frogger.BossWeapons";
        internal static Plugin _self;

        private void Awake()
        {
            _self = this;

            Item ModerPolearm = new("lunchbox", "JF_ModerPolearmLunchbox");
            ModerPolearm.Name
                .English("Moders Rage")
                .Russian("Гнев Матери");
            ModerPolearm.Description
                .English("You can almost hear her warsong as you swing this weapon")
                .Russian("Ты почти слышишь ее боевую песню, когда размахиваешь этим оружием");
            ModerPolearm.Crafting.Add(CraftingTable.ArtisanTable, 1);
            ModerPolearm.RequiredItems.Add("TrophyDragonQueen", 1);
            ModerPolearm.RequiredItems.Add("DragonTear", 10);
            ModerPolearm.RequiredItems.Add("ElderBark", 10);
            ModerPolearm.RequiredItems.Add("Silver", 5);
            ModerPolearm.RequiredUpgradeItems.Add("ElderBark", 5);
            ModerPolearm.RequiredUpgradeItems.Add("Silver", 5);
            ModerPolearm.Configurable = Configurability.Full;


            Item Arbalest = new("lunchbox", "JF_ArbalestLunchbox");
            Arbalest.Name
                .English("Abomination Crossbow")
                .Russian("Арбалет Мерзости");
            Arbalest.Description
                .English("")
                .Russian("");
            Arbalest.Crafting.Add(CraftingTable.Forge, 1);
            Arbalest.RequiredItems.Add("TrophyAbomination", 1);
            Arbalest.RequiredItems.Add("Root", 10);
            Arbalest.RequiredItems.Add("Guck", 10);
            Arbalest.RequiredUpgradeItems.Add("Root", 5);
            Arbalest.Configurable = Configurability.Full;

            Item BreidSkera = new("lunchbox", "JF_BreidSkeraLunchbox");
            BreidSkera.Name
                .English("BreidSkera")
                .Russian("Брейдскера");
            BreidSkera.Description
                .English("")
                .Russian("");
            BreidSkera.Crafting.Add(CraftingTable.Forge, 1);
            BreidSkera.RequiredItems.Add("Silver", 5);
            BreidSkera.RequiredUpgradeItems.Add("Silver", 5);
            BreidSkera.Configurable = Configurability.Full;

            Item EikthurSpear = new("lunchbox", "JF_EikthurSpearLunchbox");
            EikthurSpear.Name
                .English("Eikthyr Spear")
                .Russian("Копье Эйктюра");
            EikthurSpear.Description
                .English("")
                .Russian("");
            EikthurSpear.Crafting.Add(CraftingTable.Forge, 1);
            EikthurSpear.RequiredItems.Add("TrophyEikthyr", 1);
            EikthurSpear.RequiredItems.Add("Bronze", 5);
            EikthurSpear.RequiredUpgradeItems.Add("Bronze", 5);
            EikthurSpear.Configurable = Configurability.Full;


            Item ElderAxe = new("lunchbox", "JF_ElderAxeLunchbox");
            ElderAxe.Name
                .English("Elder Battleaxe")
                .Russian("Боевой топор Древнего");
            ElderAxe.Description
                .English("")
                .Russian("");
            ElderAxe.Crafting.Add(CraftingTable.Forge, 1);
            ElderAxe.RequiredItems.Add("TrophyTheElder", 1);
            ElderAxe.RequiredItems.Add("Iron", 5);
            ElderAxe.RequiredUpgradeItems.Add("IronScrap", 5);
            ElderAxe.Configurable = Configurability.Full;

            Item FulingMace = new("lunchbox", "JF_FulingMaceLunchbox");
            FulingMace.Name
                .English("Fuling Brute Mace")
                .Russian("Булава брутального Фулинга");
            FulingMace.Description
                .English("")
                .Russian("");
            FulingMace.Crafting.Add(CraftingTable.Forge, 1);
            FulingMace.RequiredItems.Add("TrophyGoblinBrute", 1);
            FulingMace.RequiredItems.Add("BlackMetal", 10);
            FulingMace.RequiredUpgradeItems.Add("BlackMetal", 5);
            FulingMace.Configurable = Configurability.Full;

            Item SerpentBow = new("lunchbox", "JF_SerpentBowLunchbox");
            SerpentBow.Name
                .English("Serpent Bow")
                .Russian("Змеиный лук");
            SerpentBow.Description
                .English("")
                .Russian("");
            SerpentBow.Crafting.Add(CraftingTable.Forge, 1);
            SerpentBow.RequiredItems.Add("TrophySerpent", 1);
            SerpentBow.RequiredItems.Add("Iron", 5);
            SerpentBow.RequiredUpgradeItems.Add("Iron", 5);
            SerpentBow.Configurable = Configurability.Full;


            Item Spear = new("lunchbox", "JF_SpearLunchbox");
            Spear.Name
                .English("Spear")
                .Russian("Копье");
            Spear.Description
                .English("")
                .Russian("");
            Spear.Crafting.Add(CraftingTable.Forge, 1);
            //Spear.RequiredItems.Add("TrophyDragonQueen", 1);
            Spear.RequiredItems.Add("Silver", 5);
            Spear.RequiredUpgradeItems.Add("Silver", 5);
            Spear.Configurable = Configurability.Full;

            Item TheVirus = new("lunchbox", "JF_TheVirusLunchbox");
            TheVirus.Name
                .English("The Virus")
                .Russian("Вирус");
            TheVirus.Description
                .English("")
                .Russian("");
            TheVirus.Crafting.Add(CraftingTable.Forge, 1);
            TheVirus.RequiredItems.Add("TrophyBonemass", 1);
            TheVirus.RequiredItems.Add("Silver", 5);
            TheVirus.RequiredUpgradeItems.Add("Silver", 5);
            TheVirus.Configurable = Configurability.Full;

            Item TrollShield = new("lunchbox", "JF_TrollShieldLunchbox");
            TrollShield.Name
                .English("Troll Shield")
                .Russian("Щит тролля");
            TrollShield.Description
                .English("")
                .Russian("");
            TrollShield.Crafting.Add(CraftingTable.Forge, 1);
            TrollShield.RequiredItems.Add("TrophyFrostTroll", 1);
            TrollShield.RequiredItems.Add("TrollHide", 5);
            TrollShield.RequiredItems.Add("BoneFragments", 15);
            TrollShield.RequiredUpgradeItems.Add("TrollHide", 5);
            TrollShield.RequiredUpgradeItems.Add("BoneFragments", 10);
            TrollShield.Configurable = Configurability.Full;

            Item QueenFists = new("lunchbox", "JF_QueenFistsLunchbox");
            QueenFists.Name
                .English("QueenFists")
                .Russian("Кулаки королевы");
            QueenFists.Description
                .English("")
                .Russian("");
            QueenFists.Crafting.Add(CraftingTable.Forge, 1);
            QueenFists.RequiredItems.Add("Iron", 10);
            QueenFists.RequiredUpgradeItems.Add("Iron", 5);
            QueenFists.Configurable = Configurability.Full;
        }

        internal void Debug(string msg)
        {
            Logger.LogInfo(msg);
        }
        internal void DebugError(string msg)
        {
            Logger.LogError(msg);
        }
    }
}