using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.Models
{
    public class CommanCart
    {
        public int productid { get; internal set; }
        public string Name { get; internal set; }
        public string Image { get; internal set; }
        public string discription { get; internal set; }
        public int Qnt { get; internal set; }
        public string saleprice { get; internal set; }
        public string total { get; internal set; }
        public string GrandTotal { get; internal set; }
        public string OrderName { get; internal set; }
        public string Address { get; internal set; }
        public string state { get; internal set; }
        public string City { get; internal set; }
        public string phone { get; internal set; }
        public DateTime? orderDate { get; internal set; }
        public string pincode { get; internal set; }
        public string Status { get; internal set; }
        public int OrderId { get; internal set; }
        public int CartId { get; internal set; }
        public string PaymentStatus { get; internal set; }
        public string TransactionId { get; internal set; }
    }

    public class StripeSettings
    {
        public string SecretKey { get; set; }
        public string Publishablekey { get; set; }
    }
    public class payModel
    {
        public string Token { get; set; }
        public string Total { get; set; }
        public int Id { get; set; }
    }

    public class DashboardCards
    {
        public string TotalOrders { get; set; }
        public string TotalUsers { get; set; }
        public string TotalComplateOrder { get; set; }
        public string TotalProduct { get; set; }
    }
}
