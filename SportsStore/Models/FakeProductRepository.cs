using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        /********************************************************************************************/
        // public class ClassName : InheritedClass
        // IProductRepository fields, properties, methods and events are inherited
        // New Manager fields, properties, methods and events go here...
        // по сути, класс FakeProductRepository унаследован (основан) на классе IProductRepository
        /********************************************************************************************/

        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Football", Price = 25 },
            new Product { Name = "Surf board", Price = 179 },
            new Product { Name = "Running shoes", Price = 95 }
        }.AsQueryable<Product>();


        /********************************************************************************/
        // Класс FakeProductRepository реализует интерфейс IProductRepository, возвращая
        // в качестве значения свойства Products фиксированную коллекцию объектов Product
        // Метод .AsQueryable() применяется для преобразования фиксированной коллекции
        // объектов в IQueryable<Product>, чтобы работать с хранилищем IProductRepository
        /********************************************************************************/
    }
}
