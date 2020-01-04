using Haiyseimod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Haiyseimod.Items.Weapons
{
	public class RookieIceStaff : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Rookie's Ice Staff"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault($"[c/77ddff:Ice Element]" + $"\n[c/1eff00:Uncommon Staff]");
            Item.staff[item.type] = true;
		}

		public override void SetDefaults() 
		{
            item.shoot = ProjectileType<IceBolt>();
            item.damage = 16;
            item.crit = 10;
			item.knockBack = 3;
            item.height = 26;
            item.width = 26;
            item.magic = true;
            item.reuseDelay = 20;
            item.useTime = 20;
            item.useAnimation = 20;
            item.noMelee = true;
            item.mana = 2;
            item.shootSpeed = 6;
            item.scale = 1;
            item.useStyle = 5;
            item.value = 00001000;
            item.autoReuse = true;
            item.UseSound = SoundID.Item28;
			item.rare = 2;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}