using HyBe.SharedKernel.Domain;

namespace HyBe.Domain.Entities.Transactions
{
    public class MemberTransactionRelationship : BaseEntity
    {
        public string MemberId { get; set; }
        public long TranId { get; set; }
    }
}