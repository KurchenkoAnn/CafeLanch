namespace CafeLanchDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Drinks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Path = c.String(nullable: false),
                        Category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Category_ID)
                .Index(t => t.Category_ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
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
                "dbo.Ingredients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Path = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sushis",
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
                "dbo.PizzaIngredients",
                c => new
                    {
                        Pizza_ID = c.Int(nullable: false),
                        Ingredient_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Pizza_ID, t.Ingredient_ID })
                .ForeignKey("dbo.Pizzas", t => t.Pizza_ID, cascadeDelete: true)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_ID, cascadeDelete: true)
                .Index(t => t.Pizza_ID)
                .Index(t => t.Ingredient_ID);
            
            CreateTable(
                "dbo.PizzaOrders",
                c => new
                    {
                        Pizza_ID = c.Int(nullable: false),
                        Order_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Pizza_ID, t.Order_ID })
                .ForeignKey("dbo.Pizzas", t => t.Pizza_ID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_ID, cascadeDelete: true)
                .Index(t => t.Pizza_ID)
                .Index(t => t.Order_ID);
            
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
            
            CreateTable(
                "dbo.SushiOrders",
                c => new
                    {
                        Sushi_ID = c.Int(nullable: false),
                        Order_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sushi_ID, t.Order_ID })
                .ForeignKey("dbo.Sushis", t => t.Sushi_ID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_ID, cascadeDelete: true)
                .Index(t => t.Sushi_ID)
                .Index(t => t.Order_ID);
            
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
            
            CreateTable(
                "dbo.OrderDrinks",
                c => new
                    {
                        Order_ID = c.Int(nullable: false),
                        Drink_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Order_ID, t.Drink_ID })
                .ForeignKey("dbo.Orders", t => t.Order_ID, cascadeDelete: true)
                .ForeignKey("dbo.Drinks", t => t.Drink_ID, cascadeDelete: true)
                .Index(t => t.Order_ID)
                .Index(t => t.Drink_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDrinks", "Drink_ID", "dbo.Drinks");
            DropForeignKey("dbo.OrderDrinks", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.DessertOrders", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.DessertOrders", "Dessert_ID", "dbo.Desserts");
            DropForeignKey("dbo.SushiOrders", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.SushiOrders", "Sushi_ID", "dbo.Sushis");
            DropForeignKey("dbo.SushiIngredients", "Ingredient_ID", "dbo.Ingredients");
            DropForeignKey("dbo.SushiIngredients", "Sushi_ID", "dbo.Sushis");
            DropForeignKey("dbo.PizzaOrders", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.PizzaOrders", "Pizza_ID", "dbo.Pizzas");
            DropForeignKey("dbo.PizzaIngredients", "Ingredient_ID", "dbo.Ingredients");
            DropForeignKey("dbo.PizzaIngredients", "Pizza_ID", "dbo.Pizzas");
            DropForeignKey("dbo.IngredientDesserts", "Dessert_ID", "dbo.Desserts");
            DropForeignKey("dbo.IngredientDesserts", "Ingredient_ID", "dbo.Ingredients");
            DropForeignKey("dbo.Drinks", "Category_ID", "dbo.Categories");
            DropIndex("dbo.OrderDrinks", new[] { "Drink_ID" });
            DropIndex("dbo.OrderDrinks", new[] { "Order_ID" });
            DropIndex("dbo.DessertOrders", new[] { "Order_ID" });
            DropIndex("dbo.DessertOrders", new[] { "Dessert_ID" });
            DropIndex("dbo.SushiOrders", new[] { "Order_ID" });
            DropIndex("dbo.SushiOrders", new[] { "Sushi_ID" });
            DropIndex("dbo.SushiIngredients", new[] { "Ingredient_ID" });
            DropIndex("dbo.SushiIngredients", new[] { "Sushi_ID" });
            DropIndex("dbo.PizzaOrders", new[] { "Order_ID" });
            DropIndex("dbo.PizzaOrders", new[] { "Pizza_ID" });
            DropIndex("dbo.PizzaIngredients", new[] { "Ingredient_ID" });
            DropIndex("dbo.PizzaIngredients", new[] { "Pizza_ID" });
            DropIndex("dbo.IngredientDesserts", new[] { "Dessert_ID" });
            DropIndex("dbo.IngredientDesserts", new[] { "Ingredient_ID" });
            DropIndex("dbo.Drinks", new[] { "Category_ID" });
            DropTable("dbo.OrderDrinks");
            DropTable("dbo.DessertOrders");
            DropTable("dbo.SushiOrders");
            DropTable("dbo.SushiIngredients");
            DropTable("dbo.PizzaOrders");
            DropTable("dbo.PizzaIngredients");
            DropTable("dbo.IngredientDesserts");
            DropTable("dbo.Sushis");
            DropTable("dbo.Pizzas");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Desserts");
            DropTable("dbo.Orders");
            DropTable("dbo.Drinks");
            DropTable("dbo.Categories");
        }
    }
}
