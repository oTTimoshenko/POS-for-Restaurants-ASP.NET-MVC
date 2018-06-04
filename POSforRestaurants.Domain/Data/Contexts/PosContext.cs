using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using POSforRestaurants.Domain.Data.Entities;

namespace POSforRestaurants.Domain.Data.Contexts
{
    public class PosContext:DbContext
    {
        static PosContext()
        {
            Database.SetInitializer<PosContext>(new DropCreateDatabaseIfModelChanges<PosContext>());
        }

        public PosContext(string connectionString)
            : base(connectionString)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
            .HasMany(p => p.Items)
            .WithMany(c => c.Orders)
            .Map(m =>
            {
                m.ToTable("ItemOrders");
                m.MapLeftKey("OrderId");
                m.MapRightKey("ItemId");
            });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Seat> Seats { get; set; }
    }
}
