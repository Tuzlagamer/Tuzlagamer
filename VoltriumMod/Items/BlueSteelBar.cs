using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;


namespace VoltriumMod.Items
{
    internal class BlueSteelBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Steel Bar");
            Tooltip.SetDefault("Very STRONG material");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 999;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.rare = ItemRarityID.Pink;
            Item.width = 30;
            Item.height = 24;
            Item.value = Item.buyPrice(gold: 25);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup("IronBar", 15);
            recipe.AddIngredient(ItemID.Sapphire, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}
