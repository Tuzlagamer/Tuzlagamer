using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VoltriumMod.Projectiles;

namespace VoltriumMod.Items
{
	public class ElectroShockSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("Electro Shock Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A Sword held by the Thunder God");
		}

		public override void SetDefaults()
		{
			Item.damage = 189;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 50;
			Item.useTime = 5;
			Item.useAnimation = 5;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 5f;
			Item.value = 10000000;
			Item.rare = ItemRarityID.Cyan;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<ElectroProjectile>();
			Item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TerraBlade);
			recipe.AddIngredient(ItemID.TitaniumBar, 10);
			recipe.AddIngredient(ItemID.EnchantedSword);
			recipe.AddIngredient(ItemID.Muramasa);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}