using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cleverbit.Data.Models
{
    public class Order: AuditableEntity
    {
        public int Id { get; set; }
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        //public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
