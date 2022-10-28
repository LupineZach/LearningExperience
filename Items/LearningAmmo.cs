using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using IL.Terraria;
using Projectile = IL.Terraria.Projectile;
using Recipe = Terraria.Recipe;

namespace LearningExp.Items
{
    public class LearningAmmo : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("LearningBullet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("This is a basic modded bullet.");
        }

        public override void SetDefaults()
        {
            Item.damage = 12;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 8;
            Item.height = 8;
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.knockBack = 1.5f;
            Item.value = 10;
            Item.rare = ItemRarityID.Green;
            Item.shoot = ModContent.ProjectileType<Projectile.LearningAmmo>();
            Items.shootSpeed = 16f;
            Item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(100);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddIngredient(ItemID.MusketBall, 100);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}