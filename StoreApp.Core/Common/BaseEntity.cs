using System.ComponentModel.DataAnnotations;

namespace StoreApp.Core.Common;

public abstract class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
}