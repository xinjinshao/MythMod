using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace MythMode.Projectiles
{
	public class SparklingBall : ModProjectile
	{
		public override void SetDefaults() {
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.timeLeft = 600;
		}

		public override void AI() {
			projectile.velocity.Y += projectile.ai[0];
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			projectile.ai[0] += 0.1f;
			projectile.velocity *= 0.75f;
		}
	}
}