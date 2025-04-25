

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StoreApp.Core.Common;

public class Product : BaseEntity
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Category{ get; set; }
    
    [Required]
    [MaxLength(100)]
    public string SKU { get; set; }
    
    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }
    
    public ICollection<PurchaseItem> PurchaseItems { get; set; }
}