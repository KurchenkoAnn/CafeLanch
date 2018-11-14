namespace CafeLanchDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.IngredientPizzas", newName: "PizzaIngredients");
            RenameTable(name: "dbo.DessertIngredients", newName: "IngredientDesserts");
            DropForeignKey("dbo.Orders", "Dessert_ID", "dbo.Desserts");
            DropIndex("dbo.Orders", new[] { "Dessert_ID" });
            DropPrimaryKey("dbo.PizzaIngredients");
            DropPrimaryKey("dbo.IngredientDesserts");
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
            AddPrimaryKey("dbo.IngredientDesserts", new[] { "Ingredient_ID", "Dessert_ID" });
            DropColumn("dbo.Orders", "Dessert_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Dessert_ID", c => c.Int());
            DropForeignKey("dbo.DessertOrders", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.DessertOrders", "Dessert_ID", "dbo.Desserts");
            DropIndex("dbo.DessertOrders", new[] { "Order_ID" });
            DropIndex("dbo.DessertOrders", new[] { "Dessert_ID" });
            DropPrimaryKey("dbo.IngredientDesserts");
            DropPrimaryKey("dbo.PizzaIngredients");
            DropTable("dbo.DessertOrders");
            AddPrimaryKey("dbo.IngredientDesserts", new[] { "Dessert_ID", "Ingredient_ID" });
            AddPrimaryKey("dbo.PizzaIngredients", new[] { "Ingredient_ID", "Pizza_ID" });
            CreateIndex("dbo.Orders", "Dessert_ID");
            AddForeignKey("dbo.Orders", "Dessert_ID", "dbo.Desserts", "ID");
            RenameTable(name: "dbo.IngredientDesserts", newName: "DessertIngredients");
            RenameTable(name: "dbo.PizzaIngredients", newName: "IngredientPizzas");
        }
    }
}
