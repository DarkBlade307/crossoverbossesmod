using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CBs.Projectiles
{
  public class CobaltSabotShot : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("CobaltSabot");
        }


        public override void SetDefaults()
        { 
            projectile.width = 30;
            projectile.height = 7;
            projectile.friendly = true;
            projectile.penetrate = 200;
            projectile.ranged = true;
            Projectiles.aiStyle = 21;

        }
    }
}