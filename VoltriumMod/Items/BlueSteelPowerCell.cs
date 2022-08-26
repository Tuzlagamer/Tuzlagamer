using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using VoltriumMod.Items;


namespace VoltriumMod.Items
{
    internal class BlueSteelPowerCell : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Steel Power Cell");
            Tooltip.SetDefault("Good Power cell");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 999;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.rare = ItemRarityID.Pink;
            Item.width = 11;
            Item.height = 16;
            Item.value = Item.buyPrice(gold: 25);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Bottle, 1);
            recipe.AddIngredient(ModContent.ItemType<BlueSteelBar>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}
