using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bakery.Data.Interfaces;
using Bakery.Data.Model.Data;
using Bakery.Data.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Data.Repositories
{
	internal class OrderRepository : BaseRepository<Order>, IOrderRepository
	{
		public OrderRepository(BakeryContext context) : base(context)
		{

		}
	}
}
