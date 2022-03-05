using E_Commerce.BLL.Model;
using E_Commerce.DAL.Entity;
using System.Collections.Generic;

namespace E_Commerce.BLL.Interface
{
    public interface IProduct
    {
        public IEnumerable<Product> Get();
        public Product GetById(int Id);
        public void Create(Product Model);
        public void Edit(Product Model);
        public void Delete(Product Model);
    }
}
