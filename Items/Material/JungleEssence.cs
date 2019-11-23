using Terraria.ID;
using Terraria.ModLoader;

namespace MythMode.Items.Material
{
    class JungleEssence : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Essence from the jungle.");
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;
            item.maxStack = 999;
            item.value = 1000;
            item.rare = 3;
        }
    }
}
