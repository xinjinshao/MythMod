using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace MythMod.Items.Material
{
    class SeaEssence : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Essence from the sea.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 4));
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 20;
            item.maxStack = 999;
            item.value = 1000;
            item.rare = 3;
        }
    }
}
