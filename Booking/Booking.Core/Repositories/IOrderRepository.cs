using Booking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Booking.Core.Repositories
{
    public interface IOrderRepository
    {
        public List<Order> GetAllOrders();
        public Order GetOrdersById(int id);
        public void AddOrder(Order o);
        public void UpdateOrder(int id,Order o);
        public void DeleteOrder(int id);
        
        
    }
}
