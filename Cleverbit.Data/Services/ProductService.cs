using Cleverbit.Data.DTO;
using Cleverbit.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleverbit.Data.Services
{
    public class ProductService : IProductService
    {
        private IRepository<Product> _repository;
        private IRepository<Order> _orderRepository;
        public ProductService(IRepository<Product> repository, IRepository<Order> orderRepository)
        {
            this._repository = repository;
            this._orderRepository = orderRepository;
        }

        public List<ProductDTO> GetProducts()
        {
            var productQuery = this._repository.Find(e => e.IsActive);
            var orderQuery = this._orderRepository.Find(e => e.IsActive);

            var qry = productQuery.GroupJoin(
                      orderQuery,
                      p => p.Id,
                      o => o.ProductId,
                      (p, o) => new { Product = p, IsPopular = o.Count() >= 5 });

            var products = qry.Select(e => new ProductDTO
            {
                Description = e.Product.Description,
                Id = e.Product.Id,
                Name = e.Product.Name,
                Price = e.Product.Price,
                IsPopular = e.IsPopular
            }).OrderBy(e => e.Name).ToList();

            return products;
        }
    }
}
