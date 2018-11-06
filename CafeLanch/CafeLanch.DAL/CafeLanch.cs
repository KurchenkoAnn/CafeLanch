namespace CafeLanch.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CafeLanch : DbContext
    {
       
        public CafeLanch()
            : base("name=CafeLanch")
        {
        }

      

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    
}