using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using VoltriumMod.Projectiles;

namespace VoltriumMod.Items
{
	public class LightningRod : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lightning Rod"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("If you use a metal rod in a thunderstorm you can get superpowers.");
			Item.staff[Item.type] = true;
		}

		public override void SetDefaults()
		{
			Item.damage = 89;
			Item.mana = 28;
			Item.DamageType = DamageClass.Magic;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 2;
			Item.value = 10000;
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item8;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<EletricProjectile>();
			Item.shootSpeed = 30f;
			Item.noMelee = true;

		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TitaniumBar, 25);
			recipe.AddIngredient(ItemID.WaterBolt);
			recipe.AddIngredient(ItemID.Diamond, 10);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}