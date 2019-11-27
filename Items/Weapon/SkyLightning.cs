using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using MythMod.Items.Material;
using MythMod.Projectiles;

namespace MythMod.Items.Weapon
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
            item.thrown = true;
            item.noMelee = true;
            item.width = 30;
            item.height = 30;
            item.useTime = 10;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.knockBack = 10;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = true;
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