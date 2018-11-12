namespace CafeLanchDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ingredients", "Sushi_ID", "dbo.Sushis");
            DropIndex("dbo.Ingredients", new[] { "Sushi_ID" });
            CreateTable(
                "dbo.SushiIngredients",
                c => new
                    {
                        Sushi_ID = c.Int(nullable: false),
                        Ingredient_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sushi_ID, t.Ingredient_ID })
                .ForeignKey("dbo.Sushis", t => t.Sushi_ID, cascadeDelete: true)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_ID, cascadeDelete: true)
                .Index(t => t.Sushi_ID)
                .Index(t => t.Ingredient_ID);
            
            DropColumn("dbo.Ingredients", "Sushi_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ingredients", "Sushi_ID", c => c.Int());
            DropForeignKey("dbo.SushiIngredients", "Ingredient_ID", "dbo.Ingredients");
            DropForeignKey("dbo.SushiIngredients", "Sushi_ID", "dbo.Sushis");
            DropIndex("dbo.SushiIngredients", new[] { "Ingredient_ID" });
            DropIndex("dbo.SushiIngredients", new[] { "Sushi_ID" });
            DropTable("dbo.SushiIngredients");
            CreateIndex("dbo.Ingredients", "Sushi_ID");
            AddForeignKey("dbo.Ingredients", "Sushi_ID", "dbo.Sushis", "ID");
        }
    }
}
