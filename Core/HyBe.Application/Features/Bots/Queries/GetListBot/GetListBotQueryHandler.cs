using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Bots.Commands.UpdateBot;
using HyBe.Application.Features.Bots.Queries;
using HyBe.Application.Features.Bots.Queries.GetByIdBot;
using HyBe.Domain.Contracts.Bots;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Bots.Queries.GetListBot
{
    public class GetListBotQueryHandler : IRequestHandler<GetListBotQuery, IResult>
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
