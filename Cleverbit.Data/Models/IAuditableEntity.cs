using System;

namespace Cleverbit.Data.Models
{
    public interface IAuditableEntity
    {
        bool IsActive { get; set; }
        DateTime UpdatedDate { get; set; }
        DateTime CreatedDate { get; set; }
    }
}