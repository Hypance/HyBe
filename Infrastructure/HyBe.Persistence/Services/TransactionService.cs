using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Transactions;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;
using HyBe.SharedKernel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Persistence.Services
{
    public class TransactionService : EfRepository<Transaction>, ITransactionService
    {
        private readonly HypanceDbContext _context;
        public TransactionService(HypanceDbContext hypanceDbContext) : base(hypanceDbContext)
        {
            _context = hypanceDbContext;
        }

        public async Task<IResult> CreateMemberTransactionRelationship(MemberTransactionRelationship memberTransactionRelationship)
        {
            try
            {
                var result = _context.MemberTransactionRelationships.Add(memberTransactionRelationship);
                _context.SaveChanges();
                return new SuccessDataResult<MemberTransactionRelationship>();
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<Exception>(ex);
            }
        }
    }
}
