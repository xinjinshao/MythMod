using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace MythMod
{
    public class MythPlayer : ModPlayer
    {
        public bool chrismasGiftUsed;

        public bool LoLPet;

        public override TagCompound Save()
        {
            return new TagCompound {
                {"chrismasGiftUsed", chrismasGiftUsed},
                {"LolPet", LoLPet},
            };
        }

        public override void Load(TagCompound tag)
        {
            chrismasGiftUsed = tag.GetBool("chrismasGiftUsed");
            LoLPet = tag.GetBool("LolPet");
        }
    }
}