﻿using AutoMapper;
using MediatR;
using StoreApp.Application.Features.Clients.Get.Common;
using StoreApp.Application.Features.Clients.Get.GetClientsPopularCategories;
using StoreApp.Application.Repository.Clients;


public class GetClientsPopularCategoriesHandler:BaseClientRequestHandler, IRequestHandler<GetClientsPopularCategoriesRequest, List<GetClientsPopularCategoryResponse>>
{
    private readonly IMapper _mapper;
    private readonly IClientsRepository _clientsRepository;

    public GetClientsPopularCategoriesHandler(IClientsRepository clientsRepository, IMapper mapper):base(clientsRepository, mapper)
    {}

    public async Task<List<GetClientsPopularCategoryResponse>> Handle(GetClientsPopularCategoriesRequest request, CancellationToken cancellationToken)
    {
        var categories = await _clientsRepository.GetClientsPopularCategoryResponseAsync(request.Id, cancellationToken);
        return categories;
    }
}