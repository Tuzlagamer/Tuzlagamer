using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VoltriumMod.Items;

namespace VoltriumMod.Items
{
	public class BlueSteelPowerdSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("Blue Steel Powerd Blade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Its powerd now");
		}

		public override void SetDefaults()
		{
			Item.damage = 98;
			Item.DamageType = DamageClass.Melee;
			Item.width = 64;
			Item.height = 64;
			Item.useTime = 5;
			Item.useAnimation = 5;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 5;
			Item.value = 1000000;
			Item.rare = ItemRarityID.Cyan;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<BlueSteelPowerCell>(), 1);
			recipe.AddIngredient(ModContent.ItemType<TestSword>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}