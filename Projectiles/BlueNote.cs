using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CBs.Projectiles
{
    public class BlueNote : ModProjectile
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

            projectile.penetrate = 4;

            projectile.magic = true;


        }
    }
}
