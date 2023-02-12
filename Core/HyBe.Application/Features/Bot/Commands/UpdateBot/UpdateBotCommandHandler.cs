using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;
using HyBe.Domain.Contracts.Bots;

namespace HyBe.Application.Features.Bot.Commands.UpdateBot
{
    public class UpdateBotCommandHandler : IRequestHandler<UpdateBotCommand, IResult>
    {
        #region Fields
        private readonly IBotService _botService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public UpdateBotCommandHandler(IBotService botService, IMapper mapper)
        {
            _botService = botService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(UpdateBotCommand query, CancellationToken cancellationToken)
        {
            var botMapper = _mapper.Map<Domain.Entities.Bots.Bot>(query.Request);
            var result = _botService.Update(botMapper);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult();
        }
        #endregion
    }
}
