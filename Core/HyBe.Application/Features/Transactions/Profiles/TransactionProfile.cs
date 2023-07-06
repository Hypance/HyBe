using AutoMapper;
using HyBe.Domain.Contracts.Transactions;
using HyBe.Domain.Entities.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Transactions.Profiles
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<Transaction, GetListTransactionResponse>().ReverseMap();
            CreateMap<Transaction, GetByIdTransactionResponse>().ReverseMap();
            CreateMap<CreateTransactionRequest, Transaction>().ReverseMap();
            CreateMap<UpdateTransactionRequest, Transaction>().ReverseMap();
        }
    }
}
