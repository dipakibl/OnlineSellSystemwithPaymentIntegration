using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public string Status { get; set; }
        public string PayAmount { get; set; }
        public int UserId { get; set; }
        public string PaymentStatus { get; set; }
        public string Payment_TransactionId { get; set; }
        public string ReceiptUrl { get; set; }

    }
}
