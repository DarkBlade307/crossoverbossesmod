using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using CBs.NPCs.Bosses;
namespace CBs.Projectiles
{
    public class CobaltSabot : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cobalt Sabot");
        }

        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 7;
            projectile.damage = 100;
            projectile.knockBack = 20;
            projectile.ranged = true;
            //projectile.UseSound = SoundID

            // Set other projectile.X values here
        }
    }
}
