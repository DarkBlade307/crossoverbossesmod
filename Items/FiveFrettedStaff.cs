using System;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using CBs.NPCs.Bosses;
using CBs.Projectiles;
//using Terraria.GameContent.Creative;
using Terraria;
using Microsoft.Xna.Framework;

namespace CBs.Items
{
    public class FiveFrettedStaff : ModItem
    {
		Random rnd = new Random();
		public static int Note(Random rnd, int fret)
        {
			if (fret == 1)
            {
				return ModContent.ProjectileType<GreenNote>();

            }
			else if (fret == 2) {
				return ModContent.ProjectileType<RedNote>();
            }
			else if (fret == 3)
            {
				return ModContent.ProjectileType<YellowNote>();
            }
			else if (fret == 4)
            {
				return ModContent.ProjectileType<BlueNote>();
            }
			else
            {
				return ModContent.ProjectileType<OrangeNote>();
            }
        }


		public override void SetDefaults()
		{
			item.damage = 20;
			item.magic = true;
			item.mana = 12;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = Note(rnd, rnd.Next(1, 6));
			item.shootSpeed = 16f;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            item.shoot = Note(rnd, rnd.Next(1, 6));
			return true;
        }

        public FiveFrettedStaff()
        {
        }
    }
}
