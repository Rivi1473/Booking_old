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
            return _context.OrdersList;
        }
        public Order GetOrdersById(int id)
        {
            return _context.OrdersList.Find(o => o.codeOrder == id);
        }
        public void AddOrder(Order o)
        {
            _context.OrdersList.Add(new Order
            {
                codeOrder = _context.CntOrders++,
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
            var order = _context.OrdersList.Find(e => e.codeOrder == i);   
            order.codeZimmer = o.codeZimmer;
            order.tenantName = o.tenantName;
            order.tenantPhone = o.tenantPhone;
            order.orderDate = o.orderDate;
            order.arrivalDate = o.arrivalDate;
            order.departureDate = o.departureDate;
        }
        public void DeleteOrder(int id)
        {
            var order = _context.OrdersList.Find(o => o.codeOrder == id);
            _context.OrdersList.Remove(order);
        }
    }
 

}
