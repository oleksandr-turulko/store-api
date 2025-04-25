
using System.ComponentModel.DataAnnotations.Schema;
using StoreApp.Core.Common;
using StoreApp.Core.Entities;

public class PurchaseItem : BaseEntity
{
    public Guid PurchaseId { get; set; }
    
    [ForeignKey("Product")]
    public Purchase Purchase { get; set; }
    
    public Guid ProductId { get; set; }
    
    [ForeignKey("Purchase")]
    public Product Product { get; set; }
    
    public uint Quantity { get; set; }
    
    [Column(TypeName = "decimal(10,2)")]
    public decimal PricePerUnit { get; set; }
}