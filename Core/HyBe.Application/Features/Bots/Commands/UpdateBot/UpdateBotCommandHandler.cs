using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;
using HyBe.Domain.Entities;

namespace HyBe.Application.Features.Bots.Commands.UpdateBot
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
            var bot = _botService.Get(x => x.Id == query.Request.Id);
            var getBacktest = _botService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
            if (getBacktest == null)
            {
                return new ErrorResult("Data Not Found!");
            }
            if (!bot.Success)
                return new ErrorResult();
            var result = _botService.Update(query.Request.Id);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult();
        }
        #endregion
    }
}
