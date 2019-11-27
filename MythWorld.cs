using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;

namespace MythMod
{
	public class MythWorld : ModWorld
	{
		public static bool landGuardianDefeated;
        public static bool seaGuardianDefeated;
        public static bool hellGuardianDefeated;
        public static bool skyGuardianDefeated;

        public override void Initialize() {
            landGuardianDefeated = false;
            seaGuardianDefeated = false;
            hellGuardianDefeated = false;
            hellGuardianDefeated = false;
        }

		public override TagCompound Save() {
			var defeated = new List<string>();
			if (landGuardianDefeated) {
				defeated.Add("landGuardian");
			}
            if (seaGuardianDefeated)
            {
                defeated.Add("seaGuardian");
            }
            if (hellGuardianDefeated)
            {
                defeated.Add("hellGuardian");
            }
            if (skyGuardianDefeated)
            {
                defeated.Add("skyGuardian");
            }

			return new TagCompound {
				["defeated"] = defeated
			};
		}

		public override void Load(TagCompound tag) {
			var defeated = tag.GetList<string>("defeated");
            landGuardianDefeated = defeated.Contains("landGuardian");
            seaGuardianDefeated = defeated.Contains("seaGuardian");
            hellGuardianDefeated = defeated.Contains("hellGuardian");
            skyGuardianDefeated = defeated.Contains("skyGuardian");
        }

		public override void LoadLegacy(BinaryReader reader) {
		}

		public override void NetSend(BinaryWriter writer) {
		}

		public override void NetReceive(BinaryReader reader) {
		}

		// We use this hook to add 3 steps to world generation at various points. 
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight) {
		}

		public override void PostUpdate() {
		}

		// In ExampleMod, we use PostDrawTiles to draw the TEScoreBoard area. PostDrawTiles draws before players, npc, and projectiles, so it works well.
		public override void PostDrawTiles() {
		}

		// A helper method that draws a bordered rectangle. 
		public static void DrawBorderedRect(SpriteBatch spriteBatch, Color color, Color borderColor, Vector2 position, Vector2 size, int borderWidth) {
		}
	}
}
