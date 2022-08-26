using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;


namespace VoltriumMod.Items
{
    internal class PhantomShard : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Phantom Shard");
            Tooltip.SetDefault("High Powerd Shard");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 1;
            Item.rare = ItemRarityID.Pink;
            Item.width = 16;
            Item.height = 16;
            Item.value = Item.buyPrice(gold: 25);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Ectoplasm, 10);
            recipe.AddIngredient(ItemID.Meteorite, 5);
            recipe.AddIngredient(ItemID.Amethyst, 2);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}
