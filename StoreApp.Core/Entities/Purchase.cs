using System.ComponentModel.DataAnnotations.Schema;
using StoreApp.Core.Common;

namespace StoreApp.Core.Entities;

public class Purchase : BaseEntity
{
    [ForeignKey("Client")]
    public Guid ClientId { get; set; }

    public Client Client { get; set; }
    
    [Column(TypeName = "date")]
    public DateOnly PurchaseDate{ get; set; }
    
    [Column(TypeName = "decimal(10,2)")]
    public decimal TotalAmount { get; set; }

    public ICollection<PurchaseItem> PurchaseItems { get; set; }
}