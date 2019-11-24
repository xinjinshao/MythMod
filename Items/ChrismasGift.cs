using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MythMode.Items
{
	public class ChrismasGift : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("ChrismasGift");
			Tooltip.SetDefault("<right> for goodies!");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.rare = 2;
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void RightClick(Player player) {
            player.QuickSpawnItem(ItemID.CellPhone);
            player.QuickSpawnItem(ItemID.FrostsparkBoots);
            player.QuickSpawnItem(ItemID.CandyCaneSword);
            player.QuickSpawnItem(ItemID.DogWhistle);
        }
	}
}