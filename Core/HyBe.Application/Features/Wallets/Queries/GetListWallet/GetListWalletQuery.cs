using HyBe.Domain.Contracts.Wallets;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Wallets.Queries.GetListWallet
{
    public class GetListWalletQuery : IRequest<IResult>
    {
        public GetListWalletRequest Request { get; set; }

        public GetListWalletQuery(GetListWalletRequest request)
        {
            Request = request;
        }
    }
}
