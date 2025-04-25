using System.ComponentModel.DataAnnotations;
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
    
    public DateOnly DateOfBirth { get; set; }
    public DateOnly DateOfRegistration { get; set; }
}