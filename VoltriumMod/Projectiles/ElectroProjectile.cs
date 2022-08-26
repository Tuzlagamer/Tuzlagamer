using Terraria;
using System;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace VoltriumMod.Projectiles
{
    public class ElectroProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Electro Projectile");
        }

        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Melee;
            Projectile.width = 50;
            Projectile.height = 25;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 5;
            Projectile.timeLeft = 600;
            Projectile.light = 2f;
            Projectile.ignoreWater = false;
            Projectile.tileCollide = true;
        }

        public override void AI()
        {
            int dust = Dust.NewDust(Projectile.Center, 1, 1, DustID.MagicMirror, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust].noGravity = true;
            Main.dust[dust].velocity *= 5f;
            Main.dust[dust].scale = (float)Main.rand.Next(100, 135) * 0.013f;

            int dust2 = Dust.NewDust(Projectile.Center, 1, 1, DustID.IcyMerman, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust2].noGravity = true;
            Main.dust[dust2].velocity *= 5f;
            Main.dust[dust2].scale = (float)Main.rand.Next(100, 135) * 0.013f;
        }
    }
}
