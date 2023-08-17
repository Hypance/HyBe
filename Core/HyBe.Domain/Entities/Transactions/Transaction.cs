using HyBe.Domain.Enums;
using HyBe.SharedKernel.Domain;
using System;

namespace HyBe.Domain.Entities.Transactions
{
    public class Transaction : BaseEntity
    {
        public long TranId { get; private set; }
        public string Asset { get; private set; }
        public decimal Amount { get; private set; }
        public decimal Size { get; private set; }
        public DateTimeOffset? StartTime { get; private set; }
        public DateTimeOffset? EndTime { get; private set; }
        public Side Side { get; private set; }
        public decimal EntryPrice { get; private set; }
        public decimal? ExitPrice { get; private set; }
        public bool IsDeleted { get; private set; } = false;
        public decimal Profit { get; set; }
        public bool IsCompleted { get; set; }

        public static Transaction Create(long tranId, string asset, decimal amount, Side side, decimal entryPrice)
        {
            return new Transaction
            {
                TranId = tranId,
                Asset = asset,
                Amount = amount,
                Size = amount / entryPrice,
                StartTime = DateTimeOffset.UtcNow,
                Side = side,
                EntryPrice = entryPrice
            };
        }
        public void CloseTransaction(decimal exitPrice)
        {
            this.ExitPrice = exitPrice;
            this.EndTime = DateTimeOffset.UtcNow;
            this.Profit = Side == Side.LONG
                        ? ((decimal)ExitPrice - EntryPrice) * Size
                        : (EntryPrice - (decimal)ExitPrice) * Size;
            this.IsCompleted = true;
        }
        public void OpenTransaction(decimal exitPrice)
        {
            this.ExitPrice = exitPrice;
            this.EndTime = DateTimeOffset.UtcNow;
            this.Profit = Side == Side.LONG
                        ? ((decimal)ExitPrice - EntryPrice) * Size
                        : (EntryPrice - (decimal)ExitPrice) * Size;
            this.IsCompleted = false;
        }
    }
}