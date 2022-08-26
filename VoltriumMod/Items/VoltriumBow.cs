using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VoltriumMod.Items
{
	public class VoltriumBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Voltrium LongBow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'THUNDER STRIKE!!!'");
		}

		public override void SetDefaults()
		{
			Item.damage = 58;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 2;
			Item.value = 10000;
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.useAmmo = AmmoID.Arrow;
			Item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TitaniumBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
	
}