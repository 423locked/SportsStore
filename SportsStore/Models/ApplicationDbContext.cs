using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SportsStore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        
        public DbSet<Product> Products { get; set; }

        /********************************************************************
         * Базовый класс DbContext предоставляет доступ к лежащей в основе
         * функциональности EFCore.
         * Свойство Products обеспечивает доступ к объектам Product в БД.
         * Класс ApplicationDbContext является производным от DbContext и
         * добавляет свойства, которые будут применяться для чтения/записи 
         * данных.
        ********************************************************************/
    }
}
