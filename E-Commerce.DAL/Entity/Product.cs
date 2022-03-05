using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Entity
{
    [Table("Products")]
  public  class Product
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public string Describtion { get; set; }
        public string ProductUser { get; set; }
    }
}
