using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        // инициализация интерфейса IProductRepository как repository
        // объекты Product --> IProductRepository --> FakeProductRepository (DB)
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repo) { repository = repo; }

        // Передаем в представление repository.Products (по сути таблицу продуктов из БД)
        public ViewResult List(string category, int productPage = 1) => View(new ProductsListViewModel
        {
            Products = repository.Products
            .Where(p => category == null || category == p.Category)
            .OrderBy(p => p.ProductID)
            .Skip((productPage - 1) * PageSize)
            .Take(PageSize),

            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = repository.Products.Count()
            },

            CurrentCategory = category
        });
            
    }
}
