namespace CafeLanch.DAL
{
    using global::CafeLanch.DAL.models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CafeLanch : DbContext
    {
       
        public CafeLanch()
            : base("name=CafeLanch")
        {
        }

      

         public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Drink> Drinks { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

    }


}