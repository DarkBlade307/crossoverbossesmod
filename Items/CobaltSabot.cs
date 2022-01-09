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
            item.notAmmo = false;
            //item.UseSound = SoundID

            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}
