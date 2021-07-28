using System.Threading.Tasks;
using Bakery.Data.Interfaces;
using Bakery.Data.Model.Data;
using Bakery.Data.Repositories;

namespace Bakery.Data.UnitOfWork
{
	public  class UnitOfWork : IUnitOfWork
	{
		public UnitOfWork(BakeryContext context)
		{
			_context = context;
		}

		private ICustomerRepository _customerRepo;
		private IOrderRepository _orderRepo;
		private IProductRepository _productRepo;
		private IOrderItemRepository _orderItemRepo;
		private IShoppingCartRepository _shoppingCartRepo;
		private ICartItemRepository _cartItemRepository;
		private IProductCategoryRepository _productCategoryRepo;
		private INotificationRepository _notificationRepo;
		private IOrderStatusRepository _orderStatusRepo;
		private readonly BakeryContext _context;

		public ICustomerRepository CustomerRepository
		{
			get {
				if (_customerRepo == null)
					_customerRepo = new CustomerRepository(_context);

				return _customerRepo;
			}
		}
		public IOrderRepository OrderRepository
		{
			get
			{
				if (_orderRepo == null)
					_orderRepo = new OrderRepository(_context);

				return _orderRepo;
			}
		}
		public IProductRepository ProductRepository
		{
			get
			{
				if (_productRepo == null)
					_productRepo = new ProductRepository(_context);

				return _productRepo;
			}
		}
		public IOrderItemRepository OrderItemRepository
		{
			get
			{
				if (_orderItemRepo == null)
					_orderItemRepo = new OrderItemRepository(_context);

				return _orderItemRepo;
			}
		}
		public IShoppingCartRepository ShoppingCartRepository
		{
			get
			{
				if (_shoppingCartRepo == null)
					_shoppingCartRepo = new ShoppingCartRepository(_context);

				return _shoppingCartRepo;
			}
		}
		public ICartItemRepository CartItemRepository
		{
			get
			{
				if (_cartItemRepository == null)
					_cartItemRepository = new CartItemRepository(_context);

				return _cartItemRepository;
			}
		}
		public IProductCategoryRepository ProductCategoryRepository
		{
			get
			{
				if (_productCategoryRepo == null)
					_productCategoryRepo = new ProductCategoryRepository(_context);

				return _productCategoryRepo;
			}
		}
		public INotificationRepository NotificationRepository
		{
			get
			{
				if (_notificationRepo == null)
					_notificationRepo = new NotificationRepository(_context);

				return _notificationRepo;
			}
		}
		public IOrderStatusRepository OrderStatusRepository
		{
			get
			{
				if (_orderStatusRepo == null)
					_orderStatusRepo = new OrderStatusRepository(_context);

				return _orderStatusRepo;
			}
		}
		
		public async Task SaveAsync()
		{
			await _context.SaveChangesAsync();
		}

		public void Dispose()
		{
		}
	}
}
