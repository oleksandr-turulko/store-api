using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StoreApp.Core.Common;

namespace StoreApp.Core.Entities;

public class Client: BaseEntity
{
    [MaxLength(100)]
    public string FirstName { get; set; }
    
    [MaxLength(100)]
    public string LastName { get; set; }
    
    [MaxLength(100)]
    public string MiddleName { get; set; }
    
    [Column(TypeName = "date")]
    public DateOnly DateOfBirth { get; set; }
    
    [Column(TypeName = "date")]
    public DateOnly DateOfRegistration { get; set; }
    
    public ICollection<Purchase> Purchases { get; set; }
}