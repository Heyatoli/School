using System;
using System.Collections.Generic;
using System.Text;

namespace EntityMapping
{
    public interface IDataService
    {

        Product GetProduct(int id);

        List<Product> GetProductByCategory(int id);

        List<Product> GetProductByName(string name);

        List<object> GetCategories();

        Category GetCategory(int id);

        Category CreateCategory(string name, string description);

        bool UpdateCategory(int id, string name, string description);

        bool DeleteCategory(int id);

    }
}
