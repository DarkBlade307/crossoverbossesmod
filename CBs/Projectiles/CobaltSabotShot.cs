using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using CBs.NPCs.Bosses;
namespace CBs.Projectiles
{
    public class CobaltSabotShot : ModProjectile
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
            projectile.friendly = true;
            projectile.penetrate = 100;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.rotation = 0f;
            projectile.noDropItem = true;
            projectile.light = 1f;

            //projectile.UseSound = SoundID

            // Set other projectile.X values here
        }
    }
}
