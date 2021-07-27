using Bakery.Data.Interfaces;
using Bakery.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Bakery.Data.Injections
{
	public static class Injector
	{
		public static IServiceCollection AddRepositoryInjections(this IServiceCollection services)
		{
			services.AddScoped<IProductRepository, ProductRepository>();
			services.AddScoped<IOrderRepository, OrderRepository>();
			services.AddScoped<ICustomerRepository, CustomerRepository>();
			services.AddScoped<IOrderItemRepository, OrderItemRepository>();

			return services;
		}
	}
}
