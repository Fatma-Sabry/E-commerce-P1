using AutoMapper;
using E_Commerce.BLL.Interface;
using E_Commerce.BLL.Model;
using E_Commerce.BLL.Reposatiry;
using E_Commerce.DAL.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.PL.Controllers
{
    public class ProductController : Controller
    {
        IProduct product;
        private readonly IMapper mapper;

        public ProductController(IProduct instance,IMapper mapper)
        {
            product = instance;
            this.mapper = mapper;
        }
        public IActionResult Index(ProductVM model)
        {
           var data = product.Get();
          var Model = mapper.Map<IEnumerable<ProductVM>>(data);
            
            return View(Model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                 var Model=   mapper.Map<Product>(model);
                    product.Create(Model);
                    return RedirectToAction("Index");

                }   
                
              return View(model);
            }
            catch (Exception)
            {

                return View(model);
            }

         

        }
        public IActionResult Details(int Id)
        {
            try
            {
                var data = product.GetById(Id);
                var Model = mapper.Map<ProductVM>(data);
                return View(Model);
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }


        }
        [HttpGet]
        public IActionResult Update(int Id) 
        {
            var data = product.GetById(Id);
            var Model = mapper.Map<ProductVM>(data);
            return View(Model);
        }
        [HttpPost ]
        public IActionResult Update(ProductVM model) 
        {
            try
            {
            if (ModelState.IsValid) 
            {
                    var Model = mapper.Map<Product>(model);
                    product.Edit(Model);
                    return RedirectToAction("Index");
            }  
            return View(model);  
            }
            catch (Exception)
            {
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var data = product.GetById(Id);
            var Model = mapper.Map<ProductVM>(data);
            return View(Model);
        }
        [HttpPost]
        public IActionResult Delete(ProductVM model)  
        {
            try
            {
                var Model = mapper.Map<Product>(model);
                product.Delete( Model);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }
           
        }
    }
}
