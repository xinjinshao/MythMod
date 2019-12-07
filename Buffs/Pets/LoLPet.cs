using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace MythMod.Buffs.Pets
{
    public class LoLPet : ModBuff
    {
        public override void SetDefaults()
        {
            // DisplayName and Description are automatically set from the .lang files, but below is how it is done normally.
            DisplayName.SetDefault("LoLPet");
            Description.SetDefault("Let LoL champion be with you!");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<MythPlayer>().LoLPet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[ProjectileType<Projectiles.Pets.LoLPet>()] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, 
                    ProjectileType<Projectiles.Pets.LoLPet>(), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}