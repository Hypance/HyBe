using HyBe.Domain.Contracts.Transactions;
using HyBe.Domain.Entities.Formations;
using HyBe.Domain.Entities.Transactions;
using HyBe.SharedKernel.Repositories;
using HyBe.SharedKernel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Abstractions.Services
{
    public interface ITransactionService : IRepository<Transaction>
    {
        Task<IResult> CreateMemberTransactionRelationship(MemberTransactionRelationship memberTransactionRelationship);
    }
}
