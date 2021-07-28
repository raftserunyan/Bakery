using Bakery.Data.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Bakery.Data.Injections
{
	public static class Injector
	{
		public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
		{
			services.AddScoped<IUnitOfWork, Bakery.Data.UnitOfWork.UnitOfWork >();

			return services;
		}

		//public static IServiceCollection AddRepositoryInjections(this IServiceCollection services)
		//{
		//	services.AddScoped<IProductRepository, ProductRepository>();
		//	services.AddScoped<IOrderRepository, OrderRepository>();
		//	services.AddScoped<ICustomerRepository, CustomerRepository>();
		//	services.AddScoped<IOrderItemRepository, OrderItemRepository>();

		//	return services;
		//}
	}
}
