using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MythMod.Items
{
    public class ChrismasGift : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ChrismasGift");
            Tooltip.SetDefault("<right> for goodies!");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.rare = 2;
        }

        public override bool CanRightClick()
        {
            return !Main.LocalPlayer.GetModPlayer<MythPlayer>().chrismasGiftUsed;
        }

        public override void RightClick(Player player)
        {
            if (!player.GetModPlayer<MythPlayer>().chrismasGiftUsed)
            {
                player.QuickSpawnItem(ItemID.CellPhone);
                player.QuickSpawnItem(ItemID.FrostsparkBoots);
                player.QuickSpawnItem(ItemID.CandyCaneSword);
                player.QuickSpawnItem(ItemID.ReaverShark);
                player.QuickSpawnItem(ItemID.DogWhistle);
                player.QuickSpawnItem(ItemID.GoldCoin, 2);
                player.GetModPlayer<MythPlayer>().chrismasGiftUsed = true;
            }
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            bool chrismasGiftUsed = Main.LocalPlayer.GetModPlayer<MythPlayer>().chrismasGiftUsed;
            if (chrismasGiftUsed)
            {
                tooltips.Add(new TooltipLine(mod, "NoTwice", "Chrismas Gift can not be used twice."));
            }
        }
    }
}