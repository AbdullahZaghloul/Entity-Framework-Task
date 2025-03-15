using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task.Models
{
    class Sale
    {
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public DateTime Date { get; set; }


        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Store Store { get; set; }


    }
}
