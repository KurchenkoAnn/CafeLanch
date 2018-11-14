namespace CafeLanchDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ingredients", "Dessert_ID", "dbo.Desserts");
            DropIndex("dbo.Ingredients", new[] { "Dessert_ID" });
            CreateTable(
                "dbo.DessertIngredients",
                c => new
                    {
                        Dessert_ID = c.Int(nullable: false),
                        Ingredient_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Dessert_ID, t.Ingredient_ID })
                .ForeignKey("dbo.Desserts", t => t.Dessert_ID, cascadeDelete: true)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_ID, cascadeDelete: true)
                .Index(t => t.Dessert_ID)
                .Index(t => t.Ingredient_ID);
            
            DropColumn("dbo.Ingredients", "Dessert_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ingredients", "Dessert_ID", c => c.Int());
            DropForeignKey("dbo.DessertIngredients", "Ingredient_ID", "dbo.Ingredients");
            DropForeignKey("dbo.DessertIngredients", "Dessert_ID", "dbo.Desserts");
            DropIndex("dbo.DessertIngredients", new[] { "Ingredient_ID" });
            DropIndex("dbo.DessertIngredients", new[] { "Dessert_ID" });
            DropTable("dbo.DessertIngredients");
            CreateIndex("dbo.Ingredients", "Dessert_ID");
            AddForeignKey("dbo.Ingredients", "Dessert_ID", "dbo.Desserts", "ID");
        }
    }
}
