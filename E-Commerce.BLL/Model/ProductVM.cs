using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BLL.Model
{
    public class ProductVM
    {
        
        public int ID { get; set; }
        [Required(ErrorMessage ="This Fialed Is Required")]
        public double Price { get; set; }
        [Required(ErrorMessage = "This Fialed Is Required")]
        public string Color { get; set; }
        [Required(ErrorMessage = "This Fialed Is Required")]
        [MaxLength(30,ErrorMessage = "This Fialed MaxLength Is 30")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Fialed Is Required")]
        public string Size { get; set; }
        [Required(ErrorMessage = "This Fialed Is Required")]
        public int Quantity { get; set; }
        public string Describtion { get; set; }
        public string ProductUser { get; set; }
    }
}
