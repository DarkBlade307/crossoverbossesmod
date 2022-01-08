using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using CBs.NPCs.Bosses;
namespace CBs.Items
{
    public class CobaltSabot : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cobalt Sabot");
            Tooltip.SetDefault("For use with the railgun.");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 7;
            item.maxStack = 9999;
            item.value = 10;
            item.rare = 1;
            item.damage = 100;
            item.knockBack = 20;
            item.shoot = 10;
            item.shootSpeed = 100.0f;
            item.ranged = true;
            item.crit = 10;
            
            item.notAmmo = true;

            //item.UseSound = SoundID

            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }

        class CobaltSabot
        {
        }
    }
}
