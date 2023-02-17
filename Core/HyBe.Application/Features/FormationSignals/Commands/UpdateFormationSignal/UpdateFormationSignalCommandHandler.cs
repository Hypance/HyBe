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
    private readonly IFormationSignalService _FormationSignalService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public UpdateFormationSignalCommandHandler(IFormationSignalService FormationSignalService, IMapper mapper)
    {
        _FormationSignalService = FormationSignalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(UpdateFormationSignalCommand query, CancellationToken cancellationToken)
    {
        var FormationSignalMapper = _mapper.Map<FormationSignal>(query.Request);
        var result = _FormationSignalService.Update(FormationSignalMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult(result.Message);
    }
    #endregion
}

