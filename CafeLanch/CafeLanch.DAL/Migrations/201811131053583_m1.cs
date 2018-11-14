namespace CafeLanch.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.IngredientPizzas", newName: "PizzaIngredients");
            DropPrimaryKey("dbo.PizzaIngredients");
            CreateTable(
                "dbo.Desserts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Path = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.IngredientDesserts",
                c => new
                    {
                        Ingredient_ID = c.Int(nullable: false),
                        Dessert_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ingredient_ID, t.Dessert_ID })
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_ID, cascadeDelete: true)
                .ForeignKey("dbo.Desserts", t => t.Dessert_ID, cascadeDelete: true)
                .Index(t => t.Ingredient_ID)
                .Index(t => t.Dessert_ID);
            
            CreateTable(
                "dbo.DessertOrders",
                c => new
                    {
                        Dessert_ID = c.Int(nullable: false),
                        Order_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Dessert_ID, t.Order_ID })
                .ForeignKey("dbo.Desserts", t => t.Dessert_ID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_ID, cascadeDelete: true)
                .Index(t => t.Dessert_ID)
                .Index(t => t.Order_ID);
            
            AddPrimaryKey("dbo.PizzaIngredients", new[] { "Pizza_ID", "Ingredient_ID" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DessertOrders", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.DessertOrders", "Dessert_ID", "dbo.Desserts");
            DropForeignKey("dbo.IngredientDesserts", "Dessert_ID", "dbo.Desserts");
            DropForeignKey("dbo.IngredientDesserts", "Ingredient_ID", "dbo.Ingredients");
            DropIndex("dbo.DessertOrders", new[] { "Order_ID" });
            DropIndex("dbo.DessertOrders", new[] { "Dessert_ID" });
            DropIndex("dbo.IngredientDesserts", new[] { "Dessert_ID" });
            DropIndex("dbo.IngredientDesserts", new[] { "Ingredient_ID" });
            DropPrimaryKey("dbo.PizzaIngredients");
            DropTable("dbo.DessertOrders");
            DropTable("dbo.IngredientDesserts");
            DropTable("dbo.Desserts");
            AddPrimaryKey("dbo.PizzaIngredients", new[] { "Ingredient_ID", "Pizza_ID" });
            RenameTable(name: "dbo.PizzaIngredients", newName: "IngredientPizzas");
        }
    }
}
