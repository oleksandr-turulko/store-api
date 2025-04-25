namespace StoreApp.Application.Features.Products.Get;

public class GetClientsByRecentPurchasesResponse
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public DateOnly LastPurchaseDate { get; set; }
}