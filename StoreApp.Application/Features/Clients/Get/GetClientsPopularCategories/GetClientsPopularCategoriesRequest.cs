using MediatR;

namespace StoreApp.Application.Features.Clients.Get.GetClientsPopularCategories;

public class GetClientsPopularCategoriesRequest : IRequest<List<GetClientsPopularCategoryResponse>>
{
    public Guid Id { get; set; }
}