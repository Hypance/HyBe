using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;
using HyBe.Domain.Entities;
using HyBe.Application.Features.Bots.Commands.CreateBot;

namespace HyBe.Application.Features.Bots.Queries;

public class CreateBotCommandHandler : IRequestHandler<CreateBotCommand, IResult>
{
    #region Fileds
    private readonly IBotService _botService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public CreateBotCommandHandler(IBotService botService, IMapper mapper)
    {
        _botService = botService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(CreateBotCommand query, CancellationToken cancellationToken)
    {
        var botMapper = _mapper.Map<Bot>(query.Request);
        var result = _botService.Add(botMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult(result.Message);
    }
    #endregion
}

