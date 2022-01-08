using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CBs.Projectiles
{
    public class YellowNote : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Green Note");
        }


        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;

            projectile.aiStyle = 29;
            projectile.friendly = true;

            projectile.penetrate = 3;

            projectile.magic = true;


        }
    }
}
