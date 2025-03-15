using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task.Models
{
    class Product
    {
        public int ProductId { get; set; }

        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; }

        [Column(TypeName = "real")]
        public double Quantity { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public List<Sale> Sales { get; set; }

    }
}
