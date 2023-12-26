using Booking.Core.Entities;
using Booking.Core.Repositories;
using Booking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Data.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public List<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }
        public Order GetOrdersById(int id)
        {
            return _context.Orders.ToList().Find(o => o.orderId == id);
        }
        public void AddOrder(Order o)
        {
            _context.Orders.Add(new Order
            {
                orderId = _context.CntOrders++,
                codeZimmer = o.codeZimmer,
                tenantName = o.tenantName,
                tenantPhone = o.tenantPhone,
                orderDate = o.orderDate,
                arrivalDate = o.arrivalDate,
                departureDate = o.departureDate
            });
        }
        public void UpdateOrder(int i,Order o)
        {
            var order = _context.Orders.ToList().Find(e => e.orderId == i);   
            order.codeZimmer = o.codeZimmer;
            order.tenantName = o.tenantName;
            order.tenantPhone = o.tenantPhone;
            order.orderDate = o.orderDate;
            order.arrivalDate = o.arrivalDate;
            order.departureDate = o.departureDate;
        }
        public void DeleteOrder(int id)
        {
            var order = _context.Orders.ToList().Find(o => o.orderId == id);
            _context.Orders.Remove(order);
        }
    }
 

}
