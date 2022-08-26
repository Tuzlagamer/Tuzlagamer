using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VoltriumMod.Items;

namespace VoltriumMod.Items
{
	public class PhantomBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("Phantom Blade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("it's a phantom");
		}

		public override void SetDefaults()
		{
			Item.damage = 96;
			Item.DamageType = DamageClass.Melee;
			Item.width = 64;
			Item.height = 64;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 3;
			Item.value = 10000;
			Item.rare = ItemRarityID.Cyan;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<PhantomShard>());
			recipe.AddIngredient(ModContent.ItemType<MysteriousSwordHilt>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}