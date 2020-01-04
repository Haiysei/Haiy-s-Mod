using Haiyseimod;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Haiyseimod.Projectiles
{
    public class IceBolt : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice Bolt"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

        public override void SetDefaults()
        {
			projectile.width = 18;
			projectile.height = 18;
			projectile.aiStyle = 0;
			aiType = ProjectileID.IceBolt;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.noDropItem = true;
			projectile.ignoreWater = true;
			projectile.timeLeft = 1000;
			projectile.hide = true;
        }
		
		public override void AI() {
			int Dust1 = Dust.NewDust(projectile.position + projectile.velocity, projectile.width/2, projectile.height/2, 88, 0f, 0f, 0, default(Color), 1.5f);
			Main.dust[Dust1].noGravity = true;
			int Dust2 = Dust.NewDust(projectile.position + projectile.velocity, projectile.width/2, projectile.height/2, 16, 0f, 0f, 0, default(Color), 1.5f);
			Main.dust[Dust2].noGravity = true;
			int Dust3 = Dust.NewDust(projectile.position + projectile.velocity, 1, 1, 88, 0f, 0f, 0, default(Color), 2f);
			Main.dust[Dust3].noGravity = true;
		}

		public override void Kill(int timeLeft) {
			Main.PlaySound(SoundID.Item27, projectile.position);
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			if (Main.rand.NextBool(3)) { //1 over number, in this case 1/5
				target.AddBuff(BuffID.Frostburn, 240);
			}
		}
    }
}