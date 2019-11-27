using System;
using Terraria.ModLoader;

namespace MythMod
{
	public class MythMod : Mod
	{
        public override void PostSetupContent()
        {
            // Showcases mod support with Boss Checklist without referencing the mod
            Mod bossChecklist = ModLoader.GetMod("BossChecklist");
            if (bossChecklist != null)
            {
                bossChecklist.Call("AddBossWithInfo", "LandGuardian", 1.5f, (Func<bool>)(() => MythWorld.landGuardianDefeated),
                    "Use a [i:" + ModContent.ItemType<NPCs.boss.landguardian.LandHeart>() + "] anywhere");
            }
        }
    }
}