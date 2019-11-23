using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using MythMode.Items.Material;
using MythMode.Projectiles;

namespace MythMode.Items.Weapon
{
    public class SkyLightning : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Power from sky essence.");
        }

        public override void SetDefaults()
        {
            item.damage = 45;
            item.knockBack = 10;
            item.useStyle = 1;
            item.useAnimation = 25;
            item.useTime = 10;
            item.useStyle = 5;
            item.width = 30;
            item.height = 30;
            item.rare = 2;
            item.noMelee = true;
            item.autoReuse = true;
            item.thrown = true;
            item.shoot = ProjectileType<Lightning>();
            item.shootSpeed = 20f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<SkyEssence>(), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}