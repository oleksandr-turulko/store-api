namespace StoreApp.Application.Features.Clients.Get;

public sealed record GetClientsByBirthdayResponse
{
    public Guid ClientId { get; set; }
    public string FullName { get; set; }
    public DateOnly Birthday { get; set; }
}