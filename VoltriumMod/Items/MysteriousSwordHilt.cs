using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;


namespace VoltriumMod.Items
{
    internal class MysteriousSwordHilt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mysterious Sword Hilt");
            Tooltip.SetDefault("Hmm looks like it needs a gem");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 1;
            Item.rare = ItemRarityID.Pink;
            Item.width = 36;
            Item.height = 36;
            Item.value = Item.buyPrice(gold: 36);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
                recipe.AddIngredient(ModContent.ItemType<BlueSteelBar>(), 25);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
                recipe.AddIngredient(ItemID.Leather, 2);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.Register();
        }
    }
}
