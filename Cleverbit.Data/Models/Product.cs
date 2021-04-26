using System;
using System.Collections.Generic;
using System.Text;

namespace Cleverbit.Data.Models
{
    public class Product: AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
