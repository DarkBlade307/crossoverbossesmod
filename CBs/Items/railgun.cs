using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using CBs.NPCs.Bosses;
using CBs.Items;
//using Terraria.GameContent.Creative;
using Terraria;
namespace CBs.Items
{
    public class railgun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Railgun");
            Tooltip.SetDefault("CAUTION: VERY VERY FAST");
        }

        public override void SetDefaults()
        {
            item.width = 100;
            item.height = 40;
            item.maxStack = 1;
            item.value = 1000000;
            item.rare = 9;
            item.useStyle = 5;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 250;
            item.useTime = 250;
            item.damage = 100;
            item.knockBack = 20;
            item.shoot = 10;
            item.shootSpeed = 100.0f;
            item.ranged = true;
            item.crit = 10;

            item.useAmmo = mod.ItemType(CobaltSabot);
            item.notAmmo = true;

            //item.UseSound = SoundID

            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}
