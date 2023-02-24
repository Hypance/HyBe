using HyBe.Domain.Contracts.Wallets;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Wallets.Queries.GetByIdWallet
{
    public class GetByIdWalletQuery : IRequest<IResult>
    {
        public GetByIdWalletRequest Request { get; set; }

        public GetByIdWalletQuery(GetByIdWalletRequest request)
        {
            Request = request;
        }
    }
}
