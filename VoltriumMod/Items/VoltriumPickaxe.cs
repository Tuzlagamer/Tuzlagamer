using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VoltriumMod.Items
{
	public class VoltriumPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("Voltrium Pickaxe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			Item.damage = 10;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 7;
			Item.useAnimation = 7;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 1;
			Item.value = 10000;
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.pick = 200;
			Item.useTurn = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TitaniumBar, 20);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}