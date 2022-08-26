using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VoltriumMod.Items;

namespace VoltriumMod.Items
{
	public class TestSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("Voltrium Blade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It's a very 'Shocking' sword");
		}

		public override void SetDefaults()
		{
			Item.damage = 78;
			Item.DamageType = DamageClass.Melee;
			Item.width = 64;
			Item.height = 64;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 3;
			Item.value = 10000;
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<BlueSteelBar>(), 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}