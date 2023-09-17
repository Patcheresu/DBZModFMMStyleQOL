using System;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.ItemDropRules;

namespace DBZModFMMStyleQOL.Globals
{
    internal class EditsToGlobalNPC : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            [JITWhenModsEnabled("FargowiltasSouls")]
            void TimsConcoctionDrop(IItemDropRule rule)
            {
                FargowiltasSouls.Core.ItemDropRules.Conditions.TimsConcoctionDropCondition dropCondition = new();
                IItemDropRule conditionalRule = new LeadingConditionRule(dropCondition);
                conditionalRule.OnSuccess(rule);
                npcLoot.Add(conditionalRule);
            }

            if (ModLoader.HasMod("FargowiltasSouls"))
            {
                switch (npc.type)
                {
                    case NPCID.EaterofSouls:
                    case NPCID.Crimera:
                        TimsConcoctionDrop(ItemDropRule.Common(ModContent.ItemType<DBZMODPORT.Items.Consumables.DisgustingGoop>(), 1, 1, 3));
                        break;

                    case NPCID.CochinealBeetle:
                        TimsConcoctionDrop(ItemDropRule.Common(ModContent.ItemType<DBZMODPORT.Items.Consumables.Potions.KiStimulant>(), 1, 1, 6));
                        break;

                    case NPCID.SporeBat:
                        TimsConcoctionDrop(ItemDropRule.Common(ModContent.ItemType<DBZMODPORT.Items.Consumables.MRE>(), 1, 1, 6));
                        break;
                }
            }
        }
    }
}
