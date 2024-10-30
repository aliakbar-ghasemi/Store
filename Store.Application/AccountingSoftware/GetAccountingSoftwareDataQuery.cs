using MediatR;
using Store.Domain.Interfaces;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.AccountingSoftware
{
    public record GetAccountingSoftwareDataQuery(): IRequest<AccountingSoftwareResponseModel>;

    public class GetAccountingSoftwareDataQueryHandler(IAccountingSoftwareRepository accountingSoftwareRepository) : IRequestHandler<GetAccountingSoftwareDataQuery, AccountingSoftwareResponseModel>
    {
        public async Task<AccountingSoftwareResponseModel> Handle(GetAccountingSoftwareDataQuery request, CancellationToken cancellationToken)
        {
            return await accountingSoftwareRepository.GetData();
        }
    }
}
