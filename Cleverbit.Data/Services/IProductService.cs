using Cleverbit.Data.DTO;
using System.Collections.Generic;

namespace Cleverbit.Data.Services
{
    public interface IProductService
    {
        List<ProductDTO> GetProducts();
    }
}