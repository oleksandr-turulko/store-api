using MediatR;

namespace StoreApp.Application.Features.Clients.Get;

public class GetClientsByBirthdayRequest: IRequest<IEnumerable<GetClientsByBirthdayResponse>>
{
        public DateOnly Birthday { get; set; }

}