using Terraria.GameContent.ItemDropRules;

namespace SeedConditionsExample.Content.NPCs
{
	public class MyGlobalNPC : GlobalNPC
	{
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
		{
			// First, we need to check the npc.type to see if the code is running for the vanilla NPC we want to change
			if (npc.type is NPCID.Lavabat or NPCID.Hellbat)
			{
				// This is where we add item drop rules for Lavabat/Hellbat, here are some examples:
				
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.DrunkWorldIsUp(), ItemID.FlowingMagma, 5, 1, 1, 5));
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.BeesSeed(), ItemID.CrispyHoneyBlock, 5, 1, 1, 5));
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.ForTheWorthyIsUp(), ItemID.LivingFireBlock, 5, 1, 1, 5));
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.TenthAnniversaryIsUp(), ItemID.BurningSpirit, 5, 1, 1, 5));
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.DontStarveIsUp(), ItemID.SpicyPepper, 5, 1, 1, 5));
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.RemixSeed(), ItemID.Flamelash, 5, 1, 1, 5));
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NoTrapsSeed(), ItemID.FlameTrap, 5, 1, 1, 5));
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.ZenithSeedIsUp(), ItemID.LakeofFire, 5, 1, 1, 5));
				npcLoot.Add(ItemDropRule.ByCondition(new Conditions.ZenithSeedIsUp(), ItemID.LivingFlameDye, 5, 1, 1, 5));
			}
		}
	}
}