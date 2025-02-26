using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using webApiTestGitCommands.Models;

namespace webApiTestGitCommands.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();

        Task AddProduct(Product product);
    }
}
