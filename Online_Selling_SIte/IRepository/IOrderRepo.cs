using Online_Selling_SIte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.IRepository
{
  public interface IOrderRepo
    {
        Order InsertOrder(Order order);
        Order_Detail InsertOrderDetail(Order_Detail order_Detail);
        void UpdateOrder(Order order);
        Order GetbyId(int id);
        List<Order> GetOrder();
        List<CommanCart> GetMyOrders();
        List<CommanCart> GetOrderDetail();
        List<Order> GetAllOrder();
        List<Order> GetComplateOrder();
        List<CommanCart> OrderHistory();

    }
}
