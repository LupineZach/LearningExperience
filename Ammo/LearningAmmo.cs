using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace LearningExp.Ammo
{
    public class LearningAmmo : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Learning Ammo");
        }

        public override void SetDefaults()
        {
            Projectile.arrow = false;
            Projectile.width = 10;
            Projectile.height = 10;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Ranged;
        }
    }
}
