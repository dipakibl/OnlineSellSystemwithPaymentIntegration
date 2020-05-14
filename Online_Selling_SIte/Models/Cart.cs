using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Qnt { get; set; }
        public string Total { get; set; }
        public string Discription { get; set; }
        public int UserId { get; set; }
    }
}
