using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        // инициализация интерфейса IProductRepository как repository
        // объекты Product --> IProductRepository --> FakeProductRepository (DB)
        private IProductRepository repository;

        public ProductController(IProductRepository repo) { repository = repo; }
    }
}
