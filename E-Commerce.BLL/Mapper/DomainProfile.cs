using AutoMapper;
using E_Commerce.BLL.Model;
using E_Commerce.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BLL.Mapper
{
  public  class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<Product,ProductVM>();
            CreateMap<ProductVM, Product>();
        }
    }
}
