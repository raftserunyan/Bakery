using System;
using System.Threading.Tasks;
using Bakery.Data.Interfaces;

namespace Bakery.Data.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		ICustomerRepository CustomerRepository { get; }
		IOrderRepository OrderRepository { get; }
		IProductRepository ProductRepository { get; }
		IOrderItemRepository OrderItemRepository { get; }
		IShoppingCartRepository ShoppingCartRepository { get; }
		ICartItemRepository CartItemRepository { get; }
		IProductCategoryRepository ProductCategoryRepository { get; }
		INotificationRepository NotificationRepository { get; }
		IOrderStatusRepository OrderStatusRepository { get; }
		
		Task SaveAsync();
	}
}

