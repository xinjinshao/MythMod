using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace MythMod.Items.Material
{
    class LandEssence : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Essence from the land.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 2));
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 999;
            item.value = 1000;
            item.rare = 3;
        }
    }
}
