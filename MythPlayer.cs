using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace MythMod
{
    public class MythPlayer : ModPlayer
    {
        public bool chrismasGiftUsed;

        public override TagCompound Save()
        {
            return new TagCompound {
                {"chrismasGiftUsed", chrismasGiftUsed},
            };
        }

        public override void Load(TagCompound tag)
        {
            chrismasGiftUsed = tag.GetBool("chrismasGiftUsed");
        }
    }
}