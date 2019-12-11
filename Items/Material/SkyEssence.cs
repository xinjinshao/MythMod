using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace MythMod.Items.Material
{
    class SkyEssence : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Essence from the sky.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 8));
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 23;
            item.height = 50;
            item.maxStack = 999;
            item.value = 1000;
            item.rare = 3;
        }
    }
}
