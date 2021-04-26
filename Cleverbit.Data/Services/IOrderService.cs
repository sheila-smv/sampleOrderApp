using Cleverbit.Data.DTO;
using System;
using System.Collections.Generic;

namespace Cleverbit.Data.Services
{
    public interface IOrderService
    {
        BaseOperationResponse SaveOrder(Guid productId, Guid customerId);
    }
}