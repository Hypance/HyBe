using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;
using HyBe.Domain.Entities.Formations;
using HyBe.Application.Features.FormationSignals.Commands.UpdateFormationSignal;

namespace HyBe.Application.Features.FormationSignals.Queries;

public class UpdateFormationSignalCommandHandler : IRequestHandler<UpdateFormationSignalCommand, IResult>
{
    #region Fields
    private readonly IFormationSignalService _formationSignalService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public UpdateFormationSignalCommandHandler(IFormationSignalService FormationSignalService, IMapper mapper)
    {
        _formationSignalService = FormationSignalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(UpdateFormationSignalCommand query, CancellationToken cancellationToken)
    {
        var bot = _formationSignalService.Get(x => x.Id == query.Request.Id);
        var getBacktest = _formationSignalService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
        if (getBacktest == null)
        {
            return new ErrorResult("Data Not Found!");
        }
        if (!bot.Success)
            return new ErrorResult();
        var result = _formationSignalService.Update(query.Request.Id);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

