using Fargowiltas.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace DBZModFMMStyleQOL.Content
{    
    public class ExampleRecipes : ModSystem
    {
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
            recipe.AddIngredient(ItemID.CultistBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
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

            //I.T. Tome Vol 1 Recipe

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Consumables.Transmissions.TransmissionVanish>(), 1);
            recipe.AddIngredient(ItemID.WallOfFleshBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.Register();

            //Materials

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.AstralEssentia>(), 33);
            recipe.AddIngredient(ItemID.HarpyBanner);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.AddCondition(Condition.DownedQueenBee);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.SoulofEntity>(), 51);
            recipe.AddIngredient(ItemID.PossessedArmorBanner);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.AddCondition(Condition.DownedMechBossAll);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.SoulofEntity>(), 51);
            recipe.AddIngredient(ItemID.CursedHammerBanner);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.AddCondition(Condition.DownedMechBossAll);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.SoulofEntity>(), 51);
            recipe.AddIngredient(ItemID.CrimsonAxeBanner);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.AddCondition(Condition.DownedMechBossAll);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.SoulofEntity>(), 51);
            recipe.AddIngredient(ItemID.EnchantedSwordBanner);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.AddCondition(Condition.DownedMechBossAll);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.DemonicSoul>(), 33);
            recipe.AddIngredient(ItemID.DemonBanner);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "ZTable");
            recipe.AddCondition(Condition.DownedGolem);
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.KatchinScale>(), 12);
            recipe.AddIngredient(ItemID.FishronBossBag);
            recipe.AddTile(ModLoader.GetMod("DBZMODPORT"), "KaiTable");
            recipe.Register();

            recipe = Recipe.Create(ModContent.ItemType<DBZMODPORT.Items.Materials.RadiantFragment>(), 1);
            recipe.AddIngredient(ItemID.FragmentSolar, 1);
            recipe.AddIngredient(ItemID.FragmentVortex, 1);
            recipe.AddIngredient(ItemID.FragmentNebula, 1);
            recipe.AddIngredient(ItemID.FragmentStardust, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();

            //Fargo's Mutant Mod Exclusive Content

            if (ModLoader.HasMod("Fargowiltas"))
            {
                //Travelling Merchant's Accessory

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
