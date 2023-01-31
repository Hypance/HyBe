using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Backtests;
using HyBe.SharedKernel.Repositories;

namespace HyBe.Application.Abstractions.Services
{
	public interface IBacktestService: IRepository<Backtest>
    {
	}
}

