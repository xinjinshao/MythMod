using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace MythMode.Projectiles
{
	public class FireDrop : ModProjectile
	{
		public override void SetDefaults() {
            projectile.CloneDefaults(ProjectileID.ImpFireball);
            aiType = ProjectileID.ImpFireball;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            projectile.timeLeft = 200;
        }

        public override bool PreKill(int timeLeft)
        {
            projectile.type = ProjectileID.ImpFireball;
            return true;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
            for (int i = 0; i < 5; i++)
            {
                int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y,
                    Main.rand.Next(-8, 8) * .25f, Main.rand.Next(-8, 8) * .25f, 
                    ProjectileID.ImpFireball, (int)(projectile.damage * .5f), 0, projectile.owner);
                Main.projectile[a].aiStyle = 1;
                Main.projectile[a].tileCollide = true;
            }
        }
    }
}