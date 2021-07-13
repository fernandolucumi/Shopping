using Shop.Web.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Web.Data
{
    public interface IRepository
    {
        void AddProduct(Product product);

        Product GetProduct(int id);

        IEnumerable<Product> GetProducts();

        bool ProductExist(int id);

        void RemoveProduct(Product product);

        Task<bool> SaveAllChangesAsync();

        void UpdateProduct(Product product);
    }
}