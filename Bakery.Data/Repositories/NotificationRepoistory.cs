using Bakery.Data.Interfaces;
using Bakery.Data.Model.Data;
using Bakery.Data.Model.Models;

namespace Bakery.Data.Repositories
{
	internal class NotificationRepository : BaseRepository<Notification>, INotificationRepository
	{
		public NotificationRepository(BakeryContext context) : base(context)
		{

		}
	}
}
