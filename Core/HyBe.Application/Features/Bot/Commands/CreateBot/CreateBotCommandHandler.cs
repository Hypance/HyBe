using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using AutoMapper;
using HyBe.Domain.Contracts.Bots;
using HyBe.Domain.Entities.Bots;


namespace HyBe.Application.Features.Bot.Commands.CreateBot
{
    public class CreateBotCommandHandler : IRequestHandler<CreateBotCommand, IResult>
    {
        #region Fields
        private readonly IBotService _botService;
        private readonly IMapper _mapper;
        #endregion


        #region Constructor
        public CreateBotCommandHandler(IBotService botService, IMapper mapper) 
        {
            _botService= botService;
            _mapper= mapper;
        }
        #endregion

        #region Methods

        public async Task<IResult> Handle(CreateBotCommand query, CancellationToken cancellationToken)
        {
            var botMapper = _mapper.Map<Domain.Entities.Bots.Bot>(query.Request);
            var result = _botService.Add(botMapper);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult();
        }
        #endregion
    }
}
