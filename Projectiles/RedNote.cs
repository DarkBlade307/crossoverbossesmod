using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CBs.Projectiles
{
    public class RedNote : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Note");
        }


        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;

            projectile.aiStyle = 29;
            projectile.friendly = true;

            projectile.penetrate = 2;

            projectile.magic = true;


        }
    }
}
