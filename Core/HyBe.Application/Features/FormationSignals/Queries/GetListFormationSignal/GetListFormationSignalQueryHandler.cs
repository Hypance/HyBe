using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;
using HyBe.Domain.Contracts.FormationSignals;

namespace HyBe.Application.Features.FormationSignals.Queries;

public class GetListFormationSignalQueryHandler : IRequestHandler<GetListFormationSignalQuery, IResult>
{
    #region Fileds
    private readonly IFormationSignalService _FormationSignalService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetListFormationSignalQueryHandler(IFormationSignalService FormationSignalService, IMapper mapper)
    {
        _FormationSignalService = FormationSignalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetListFormationSignalQuery query, CancellationToken cancellationToken)
    {

        var result = _FormationSignalService.GetAll();
        if (result.Success)
        {
            var FormationSignalMapper = _mapper.Map<List<GetListFormationSignalResponse>>(result.Data);
            return new SuccessDataResult<List<GetListFormationSignalResponse>>(FormationSignalMapper);
        }
        return new ErrorDataResult<List<GetListFormationSignalResponse>>(result.Message);
    }
    #endregion
}

