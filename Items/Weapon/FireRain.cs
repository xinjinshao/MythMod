﻿using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using MythMod.Items.Material;
using MythMod.Projectiles;

namespace MythMod.Items.Weapon
{
    public class FireRain : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Power from hell essence.");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.magic = true;
            item.mana = 10;
            item.noMelee = true;
            item.width = 35;
            item.height = 35;
            item.useTime = 40;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.knockBack = 10;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = true;
            item.shoot = ProjectileType<FireDrop>();
            item.shootSpeed = 5f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<HellEssence>(), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}