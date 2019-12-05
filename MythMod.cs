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
                    "Use a [i:" + ModContent.ItemType<NPCs.boss.landguardian.LandHeart>() + "] at surface");
                bossChecklist.Call("AddBossWithInfo", "SeaGuardian", 1.5f, (Func<bool>)(() => MythWorld.seaGuardianDefeated),
                    "Use a [i:" + ModContent.ItemType<NPCs.boss.seaguardian.SeaWave>() + "] at sea");
                bossChecklist.Call("AddBossWithInfo", "HellGuardian", 1.5f, (Func<bool>)(() => MythWorld.hellGuardianDefeated),
                    "Use a [i:" + ModContent.ItemType<NPCs.boss.hellguardian.HellFire>() + "] at hell");
                bossChecklist.Call("AddBossWithInfo", "SkyGuardian", 1.5f, (Func<bool>)(() => MythWorld.skyGuardianDefeated),
                    "Use a [i:" + ModContent.ItemType<NPCs.boss.skyguardian.SkyWind>() + "] at sky");
            }
        }
    }
}