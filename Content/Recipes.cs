using Fargowiltas.Utilities;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace DBZModFMMStyleQOL.Content
{    
    public class ExampleRecipes : ModSystem
    {

        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Language.GetTextValue("ItemName.Terrarian")} {Language.GetTextValue($"Mods.DBZModFMMStyleQOL.RecipeText.TreasureBag")}",
                ItemID.KingSlimeBossBag,
                ItemID.EyeOfCthulhuBossBag,
                ItemID.EaterOfWorldsBossBag,
                ItemID.BrainOfCthulhuBossBag,
                ItemID.QueenBeeBossBag,
                ItemID.SkeletronBossBag,
                ItemID.DeerclopsBossBag,
                ItemID.WallOfFleshBossBag,
                ItemID.QueenBeeBossBag,
                ItemID.DestroyerBossBag,
                ItemID.TwinsBossBag,
                ItemID.SkeletronPrimeBossBag,
                ItemID.PlanteraBossBag,
                ItemID.FairyQueenBossBag,
                ItemID.GolemBossBag,
                ItemID.FishronBossBag,
                ItemID.MoonLordBossBag);
            RecipeGroup.RegisterGroup("DBZModFMMStyleQOL:SenzuBossBagGroup", group);

            group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Language.GetTextValue("NPCName.CultistBoss")} {Language.GetTextValue("LegacyInterface.104")}",
                ItemID.LunaticCultistMasterTrophy,
                ItemID.LunaticCultistPetItem,
                ItemID.BossMaskCultist,
                ItemID.CultistBossBag,
                3357);
            RecipeGroup.RegisterGroup("DBZModFMMStyleQOL:LunaticRewardGroup", group);

            group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Language.GetTextValue("MapObject.Banner")} {Language.GetTextValue("Bestiary_ItemDropConditions.CrimsonKeyCondition")}",
            ItemID.HerplingBanner,
            ItemID.CrimslimeBanner,
            ItemID.BloodJellyBanner,
            ItemID.BloodFeederBanner);
            RecipeGroup.RegisterGroup("DBZModFMMStyleQOL:CrimsonBloodstainedBandanaGroup", group);

            group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Language.GetTextValue("MapObject.Banner")} {Language.GetTextValue("Bestiary_ItemDropConditions.CorruptKeyCondition")}",
            ItemID.CorruptorBanner,
            ItemID.SlimerBanner,
            ItemID.CorruptSlimeBanner,
            ItemID.WorldFeederBanner);
            RecipeGroup.RegisterGroup("DBZModFMMStyleQOL:CorruptionBloodstainedBandanaGroup", group);
        }

        public override void AddRecipes()
        {
            //Ki Fragment Recipies

            var recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.KiFragments.KiFragment1>(), 1);
            recipe.AddIngredient(ItemID.EyeOfCthulhuBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.KiFragments.KiFragment2>(), 1);
            recipe.AddIngredient(ItemID.SkeletronBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.KiFragments.KiFragment3>(), 1);
            recipe.AddIngredient(ItemID.SkeletronPrimeBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.KiFragments.KiFragment4>(), 1);
            recipe.AddIngredient(ItemID.PlanteraBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.KiFragments.KiFragment5>(), 1);
            recipe.AddRecipeGroup("DBZModFMMStyleQOL:LunaticRewardGroup", 1);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "KaiTable");
            recipe.Register();

            //Kaioken Recipies

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.KaioFragments.KaioFragmentFirst>(), 1);
            recipe.AddIngredient(ItemID.EyeOfCthulhuBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.KaioFragments.KaioFragment1>(), 1);
            recipe.AddIngredient(ItemID.EaterOfWorldsBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.KaioFragments.KaioFragment1>(), 1);
            recipe.AddIngredient(ItemID.BrainOfCthulhuBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.KaioFragments.KaioFragment2>(), 1);
            recipe.AddIngredient(ItemID.QueenBeeBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.KaioFragments.KaioFragment3>(), 1);
            recipe.AddIngredient(ItemID.SkeletronBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.KaioFragments.KaioFragment4>(), 1);
            recipe.AddIngredient(ItemID.WallOfFleshBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            //Weapons

            //Candy Laser
            //TODO: Make Majin Banners

            //Accessories

            //Baldur Essentia

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Accessories.BaldurEssentia>(), 1);
            recipe.AddIngredient(ItemID.GraniteGolemBanner);
            recipe.AddTile(TileID.Solidifier);
            recipe.Register();

            //Ice Energy Talisman

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Accessories.IceTalisman>(), 1);
            recipe.AddIngredient(ItemID.IceBatBanner);
            recipe.AddTile(TileID.Solidifier);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Accessories.IceTalisman>(), 1);
            recipe.AddIngredient(ItemID.IceSlimeBanner);
            recipe.AddTile(TileID.Solidifier);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Accessories.IceTalisman>(), 1);
            recipe.AddIngredient(ItemID.SpikedIceSlimeBanner);
            recipe.AddTile(TileID.Solidifier);
            recipe.Register();

            //Burning Energy Amulet

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Accessories.BurningEnergyAmulet>(), 1);
            recipe.AddIngredient(ItemID.MeteorHeadBanner);
            recipe.AddTile(TileID.Solidifier);
            recipe.AddCondition(Condition.DownedEowOrBoc);
            recipe.Register();


            //Bloodstained Bandana

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Accessories.BloodstainedBandana>(), 1);
            recipe.AddRecipeGroup("DBZModFMMStyleQOL:CorruptionBloodstainedBandanaGroup", 1);
            recipe.AddTile(TileID.Solidifier);
            recipe.AddCondition(Condition.Hardmode);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Accessories.BloodstainedBandana>(), 1);
            recipe.AddRecipeGroup("DBZModFMMStyleQOL:CorruptionBloodstainedBandanaGroup", 1);
            recipe.AddTile(TileID.Solidifier);
            recipe.AddCondition(Condition.Hardmode);
            recipe.Register();


            //Majin Nucleus
            //TODO: Make Majin Banners


            //I.T. Tome Vol 1 Recipe

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.Transmissions.TransmissionVanish>(), 1);
            recipe.AddIngredient(ItemID.WallOfFleshBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            //Spiritualist Emblem

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Accessories.SpiritualEmblem>(), 1);
            recipe.AddIngredient(ItemID.WallOfFleshBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            //Metamoran Sash

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Accessories.MetamoranSash>(), 1);
            recipe.AddRecipeGroup("DBZModFMMStyleQOL:LunaticRewardGroup", 1);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "KaiTable");
            recipe.AddCondition(Condition.InExpertMode);
            recipe.Register();

            //Materials

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.AstralEssentia>(), 33);
            recipe.AddIngredient(ItemID.HarpyBanner);
            recipe.AddTile(TileID.Solidifier);
            recipe.AddCondition(Condition.DownedQueenBee);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.SoulofEntity>(), 50);
            recipe.AddIngredient(ItemID.PossessedArmorBanner);
            recipe.AddTile(TileID.Solidifier);
            recipe.AddCondition(Condition.DownedMechBossAll);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.SoulofEntity>(), 50);
            recipe.AddIngredient(ItemID.CursedHammerBanner);
            recipe.AddTile(TileID.Solidifier);
            recipe.AddCondition(Condition.DownedMechBossAll);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.SoulofEntity>(), 50);
            recipe.AddIngredient(ItemID.CrimsonAxeBanner);
            recipe.AddTile(TileID.Solidifier);
            recipe.AddCondition(Condition.DownedMechBossAll);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.SoulofEntity>(), 50);
            recipe.AddIngredient(ItemID.EnchantedSwordBanner);
            recipe.AddTile(TileID.Solidifier);
            recipe.AddCondition(Condition.DownedMechBossAll);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.DemonicSoul>(), 33);
            recipe.AddIngredient(ItemID.DemonBanner);
            recipe.AddTile(TileID.Solidifier);
            recipe.AddCondition(Condition.DownedGolem);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.KatchinScale>(), 12);
            recipe.AddIngredient(ItemID.FishronBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.RadiantFragment>(), 1);
            recipe.AddIngredient(ItemID.FragmentSolar, 1);
            recipe.AddIngredient(ItemID.FragmentVortex, 1);
            recipe.AddIngredient(ItemID.FragmentNebula, 1);
            recipe.AddIngredient(ItemID.FragmentStardust, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();

            //Senzu Beans

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.SenzuBean>(), 2);
            recipe.AddRecipeGroup("DBZModFMMStyleQOL:SenzuBossBagGroup", 1);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            //Fargo's Mutant Mod Exclusive Content

            if (ModLoader.HasMod("Fargowiltas"))
            {

                //Blood Thief

                recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Weapons.Tier_3.BlightedFang>(), 1);
                recipe.AddIngredient(ItemID.GoldCoin, 1);
                recipe.AddIngredient(ItemID.SilverCoin, 60);
                recipe.AddIngredient(ModLoader.GetMod("Fargowiltas"), "Dryad");
                recipe.AddIngredient(ItemID.BloodMoonStarter, 1);
                recipe.AddCondition(Condition.DownedSkeletron);
                recipe.AddTile(TileID.Solidifier);
                recipe.Register();

                //Luminous Sectum

                recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Accessories.LuminousSectum>(), 1);
                recipe.AddIngredient(ItemID.GoldCoin, 64);
                recipe.AddIngredient(ModLoader.GetMod("Fargowiltas"), "Steampunker");
                recipe.AddTile(TileID.Solidifier);
                recipe.Register();

                //Arm Cannon

                recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Accessories.ArmCannon>(), 1);
                recipe.AddIngredient(ItemID.GoldCoin, 1);
                recipe.AddIngredient(ItemID.SilverCoin, 20);
                recipe.AddIngredient(ModLoader.GetMod("Fargowiltas"), "TravellingMerchant");
                recipe.AddTile(TileID.Solidifier);
                recipe.Register();

                //MREs
                recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.MRE>(), 1);
                recipe.AddIngredient(ItemID.SilverCoin, 60);
                recipe.AddIngredient(ModLoader.GetMod("Fargowiltas"), "TravellingMerchant");
                recipe.AddTile(TileID.Solidifier);
                recipe.Register();

                recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.MRE>(), 30);
                recipe.AddIngredient(ItemID.GoldCoin, 18);
                recipe.AddIngredient(ModLoader.GetMod("Fargowiltas"), "TravellingMerchant");
                recipe.AddTile(TileID.Solidifier);
                recipe.Register();

                //Disgusting Goop
                recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.DisgustingGoop>(), 1);
                recipe.AddIngredient(ItemID.SilverCoin, 80);
                recipe.AddIngredient(ItemID.GoldCoin, 4);
                recipe.AddIngredient(ModLoader.GetMod("Fargowiltas"), "SkeletonMerchant");
                recipe.AddTile(TileID.Solidifier);
                recipe.Register();

                recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.DisgustingGoop>(), 30);
                recipe.AddIngredient(ItemID.GoldCoin, 44);
                recipe.AddIngredient(ItemID.PlatinumCoin, 1);
                recipe.AddIngredient(ModLoader.GetMod("Fargowiltas"), "SkeletonMerchant");
                recipe.AddTile(TileID.Solidifier);
                recipe.Register();
            }

        }
    }
}
