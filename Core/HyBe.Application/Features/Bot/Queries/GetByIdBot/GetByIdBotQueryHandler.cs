using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Contracts.Bots;
using HyBe.SharedKernel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Bot.Queries.GetByIdBot
{
    public class GetByIdBotQueryHandler
    {
        #region Fields
        private readonly IBotService _botService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public GetByIdBotQueryHandler(IBotService botService, IMapper mapper)
        {
            _botService = botService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(GetByIdBotQuery query, CancellationToken cancellationToken)
        {

            var result = _botService.Get(b => b.Id == query.Request.Id);
            if (result.Success)
            {
                var botMapper = _mapper.Map<GetByIdBotResponse>(result.Data);
                return new SuccessDataResult<GetByIdBotResponse>(botMapper);
            }
            return new ErrorDataResult<GetByIdBotResponse>();
        }
        #endregion
    }
}
