using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Backtests.Queries;
using HyBe.Domain.Contracts.Backtests;
using HyBe.SharedKernel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Bot.Queries.GetListBot
{
    public class GetListBotQueryHandler
    {

        #region Fileds
        private readonly IBotService _botService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public GetListBotQueryHandler(IBotService botService, IMapper mapper)
        {
            _botService = botService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(GetListBotQuery query, CancellationToken cancellationToken)
        {

            var result = _botService.GetAll();
            if (result.Success)
            {
                var botMapper = _mapper.Map<List<GetListBotResponse>>(result.Data);
                return new SuccessDataResult<List<GetListBotResponse>>(botMapper);
            }
            return new ErrorDataResult<List<GetListBotResponse>>();
        }
        #endregion
    }
}
