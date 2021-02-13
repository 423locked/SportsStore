using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface IProductRepository { IQueryable<Product> Products { get; } }
    // IQueryable<T> -> IEnumerable<T>
    // IQueryable<T> можно преобразовать в ToList() или ToArray()
    // IQueryable<T> проще использовать с БД чем IEnumerable<T> потому что он фильтрует значения из базы
}
