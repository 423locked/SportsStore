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
                TotalItems = category == null
                    ? repository.Products.Count()
                    : repository.Products.Where(x => x.Category == category).Count()
                /* Если категория пуста, т.е. вывод главной страницы с товарами всех категорий, 
                 * иначе - посчитай количество товаров, для которых категория равна текущей категории category. */
            },

            CurrentCategory = category
        });
            
    }
}
