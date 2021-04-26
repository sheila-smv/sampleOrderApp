using Cleverbit.Data.DTO;
using Cleverbit.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleverbit.Data.Services
{
    public class OrderService: IOrderService
    {
        private IRepository<Order> _repository;

        public OrderService(IRepository<Order> repository)
        {
            this._repository = repository;
        }

        public BaseOperationResponse SaveOrder(Guid productId, Guid customerId)
        {
            var response = new BaseOperationResponse { IsSuccess = false, Message = "Order not committed." };
            Order order = new Order
            {
                CreatedDate = DateTime.Now,
                IsActive = true,
                UpdatedDate = DateTime.Now,
                UserId = customerId,
                ProductId = productId
            };

            this._repository.Add(order);
            if(this._repository.SaveChanges() > 0)
            {
                response.IsSuccess = true;
                response.Message = "Order has been placed.";
            }

            return response;
        }
    }
}
