namespace StoreApp.Application.Features.Clients.Get;

public sealed record GetClientsByBirthdayResponse
{
    public Guid ClientId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateOnly Birthday { get; set; }
}