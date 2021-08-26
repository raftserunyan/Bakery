using Microsoft.EntityFrameworkCore;
using Bakery.Data.Model.Models;

namespace Bakery.Data.Model.Data
{
	public class BakeryContext : DbContext
	{
		public BakeryContext(DbContextOptions<BakeryContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<Customer>()
				.HasOne<ShoppingCart>(c => c.ShoppingCart)
				.WithOne(sc => sc.Customer)
				.HasForeignKey<Customer>(c => c.ShoppingCartId);

			builder.Entity<ShoppingCart>()
				.HasOne<Customer>(sc => sc.Customer)
				.WithOne(c => c.ShoppingCart)
				.HasForeignKey<ShoppingCart>(sc => sc.CustomerId);

		}

		public DbSet<Customer> Customers { get; set; }

		public DbSet<Notification> Notifications { get; set; }

		public DbSet<Order> Orders { get; set; }
		public DbSet<ShoppingCart> ShoppingCarts { get; set; }

		public DbSet<OrderItem> OrderItems { get; set; }
		public DbSet<CartItem> CartItems { get; set; }

		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> Categories { get; set; }
	}
}
