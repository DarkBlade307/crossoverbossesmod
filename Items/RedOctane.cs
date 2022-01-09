using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using CBs.NPCs.Bosses;
//using Terraria.GameContent.Creative;
using Terraria;

namespace CBs.Items
{
	public class RedOctane : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Red Toy Guitar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Looks good enough to play some DragonForce on!");

			//ItemID.Sets.SortingPriorityBossSpawns[Type] = 12;
			
		}

		public override void SetDefaults() 
		{
			item.damage = 0;
			item.melee = false;
			item.noMelee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 0;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.consumable = true;
		}

        public override bool CanUseItem(Player player)
        {
			return !Main.dayTime && !NPC.AnyNPCs(ModContent.NPCType<Villain>());
		}

		public override bool UseItem(Player player)
        {
			if (player.whoAmI == Main.myPlayer)
            {
				Main.PlaySound(SoundID.Roar, player.position, 0);

				int type = ModContent.NPCType<Villain>();

				if (Main.netMode != NetmodeID.MultiplayerClient)
                {
					NPC.SpawnOnPlayer(player.whoAmI, type);
                }
				else
                {
					NetMessage.SendData(MessageID.SpawnBoss, number: player.whoAmI, number2: type);
                }
            }

			return true;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 15);
			recipe.AddIngredient(ItemID.Wire, 12);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}