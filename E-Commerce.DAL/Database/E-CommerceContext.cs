using E_Commerce.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Database
{
  public  class E_CommerceContext : DbContext
    {
        public E_CommerceContext(DbContextOptions<E_CommerceContext> obt) :base(obt)
        {

        }
        public DbSet<Product> Products { get;set ;}
    }
}
