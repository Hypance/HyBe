using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;
using HyBe.Domain.Contracts.FormationSignals;
using HyBe.Domain.Contracts.Backtests;
using HyBe.Domain.Contracts.Formations;

namespace HyBe.Application.Features.FormationSignals.Queries;

public class GetListFormationSignalQueryHandler : IRequestHandler<GetListFormationSignalQuery, IResult>
{
    #region Fileds
    private readonly IFormationSignalService _formationSignalService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetListFormationSignalQueryHandler(IFormationSignalService formationSignalService, IMapper mapper)
    {
        _formationSignalService = formationSignalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetListFormationSignalQuery query, CancellationToken cancellationToken)
    {

        var result = _formationSignalService.GetAll(b => b.MemberId.ToString() == query.Request.MemberId);
        if (result.Success)
        {
            var formationSignalMapper = _mapper.Map<List<GetListFormationSignalResponse>>(result.Data);
            return new SuccessDataResult<List<GetListFormationSignalResponse>>(formationSignalMapper);
        }
        return new ErrorDataResult<List<GetListFormationSignalResponse>>(result.Message);
    }
    #endregion
}

