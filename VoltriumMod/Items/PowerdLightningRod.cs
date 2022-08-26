using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using VoltriumMod.Projectiles;
using VoltriumMod.Items;

namespace VoltriumMod.Items
{
    internal class PowerdLightningRod : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Powerd Lightning Rod");
            Tooltip.SetDefault("If you use a metal rod in a thunderstorm you can be God.");
            Item.staff[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 64;
            Item.height = 64;
            Item.useStyle = ItemUseStyleID.Shoot;

            Item.DamageType = DamageClass.Magic;
            Item.noMelee = true;
            Item.mana = 15;
            Item.damage = 97;
            Item.knockBack = 4f;

            Item.useTime = 15;
            Item.useAnimation = 10;

            Item.UseSound = SoundID.Item71;
            Item.shoot = ModContent.ProjectileType<PowerdProjectile>();
            Item.shootSpeed = 1f;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<LightningRod>());
            recipe.AddIngredient(ModContent.ItemType<BlueSteelPowerCell>());
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
