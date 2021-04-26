using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleverbit.Data.DTO
{
    public class BaseOperationResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
