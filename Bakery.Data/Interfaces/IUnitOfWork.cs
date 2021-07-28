using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Data.Interfaces
{
	public interface IUnitOfWork
	{
		ICustomerRepository CustomerRepo { get; }
		IOrderRepository OrderRepo { get; }
		IProductRepository ProductRepo { get; }
		IOrderItemRepository OrderItemRepo { get; }
		IShoppingCartRepository ShoppingCartRepo { get; }
		ICartItemRepository CartItemRepository { get; }
		IProductCategoryRepository ProductCategoryRepo { get; }
		INotificationRepository NotificationRepo { get; }
		IOrderStatusRepository OrderStatusRepo { get; }
		
		void Save();
	}
}

