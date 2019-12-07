using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MythMod.Projectiles.Pets
{
    public class LoLPet : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 1;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            aiType = ProjectileID.ZephyrFish;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false; // Relic from aiType
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            MythPlayer modPlayer = player.GetModPlayer<MythPlayer>();
            if (player.dead)
            {
                modPlayer.LoLPet = false;
            }
            if (modPlayer.LoLPet)
            {
                projectile.timeLeft = 2;
            }
            Lighting.AddLight(projectile.Center, (255 - projectile.alpha) * 0.9f / 100f, (255 - projectile.alpha) * 0.1f / 100f, (255 - projectile.alpha) * 0.3f / 100f);
        }
    }
}