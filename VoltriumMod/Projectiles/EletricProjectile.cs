using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace VoltriumMod.Projectiles
{
	public class EletricProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("Electric Bolt"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			Projectile.DamageType = DamageClass.Magic;
			Projectile.width = 8;
			Projectile.height = 8;
			Projectile.aiStyle = 0;
			Projectile.friendly = true;
			Projectile.hostile = false;
			Projectile.penetrate = 5;
			Projectile.timeLeft = 600;
			Projectile.light = 3f;
			Projectile.ignoreWater = true;
			Projectile.tileCollide = true;
		}

		public override void AI()
        {
			int dust = Dust.NewDust(Projectile.Center, 1, 1, DustID.GoldFlame, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust].velocity *= 0.2f;
			Main.dust[dust].scale = (float)Main.rand.Next(80, 115) * 0.013f;
        }

	}
}