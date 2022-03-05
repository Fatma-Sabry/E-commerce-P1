using E_Commerce.BLL.Interface;
using E_Commerce.BLL.Model;
using E_Commerce.DAL.Database;
using E_Commerce.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BLL.Reposatiry
{
    public class ProductRep : IProduct
    {
        E_CommerceContext db ;
        public ProductRep(E_CommerceContext db)
        {
            this.db = db; 
        }
        public void Create(Product Model)
        {
           
            db.Products.Add(Model);
            db.SaveChanges();
        }

        public void Delete(Product Model)
        {
     
            db.Products.Remove(Model);
            db.SaveChanges();
        }

        public void Edit(Product Model)
        {
             db.Entry(Model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Product> Get()
        {
            var model = db.Products.Select(a => a);
            return (model);
        }

        public Product GetById(int Id)
        {
            var model = db.Products.Where(a=>a.ID==Id).FirstOrDefault();
            return (model);
        }
    }
}
