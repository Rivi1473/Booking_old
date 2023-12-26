using Booking.Core.Entities;
using Booking.Core.Repositories;
using Booking.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Service
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }
        public Order GetOrderById(int id) 
        {
            return _orderRepository.GetOrdersById(id);
        }
        public void AddOrder(Order order)
        {
            _orderRepository.AddOrder(order);
        }
        public void UpdateOrder(int i,Order order)
        {
            _orderRepository.UpdateOrder(i,order);
        }
        public void DeleteOrder(int id)
        {
            _orderRepository.DeleteOrder(id);
        }
    }
}
