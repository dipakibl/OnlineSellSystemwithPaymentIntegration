using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int Qnt { get; set; }
        public string Price { get; set; }
        public string Total { get; set; }
        public string Saleprice { get; set; }
        public string Image { get; set; }
        public DateTime UploadDate { get; set; }
        public bool IsActive { get; set; }
        public string Discription { get; set; }


    }
}
