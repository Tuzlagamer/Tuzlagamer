using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VoltriumMod.Items
{
	public class VoltriumAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("Voltrium Axe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			Item.damage = 13;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 9;
			Item.useAnimation = 9;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 5;
			Item.value = 10000;
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.axe = 22;
			Item.useTurn = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TitaniumBar, 15);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}