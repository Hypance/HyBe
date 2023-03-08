using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Enums;
using MediatR;
using HyBe.Domain.Contracts.Enums;

namespace HyBe.Application.Features.Enums.Queries;

public class GetListEnumQueryHandler : IRequestHandler<GetListEnumQuery, IResult>
{
    #region Fileds
    private readonly IEnumService _enumService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetListEnumQueryHandler(IEnumService enumService, IMapper mapper)
    {
        _enumService = enumService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetListEnumQuery query, CancellationToken cancellationToken)
    {

        var result = _enumService.GetAll();
        if (result.Success)
        {
            var enumMapper = _mapper.Map<List<GetListEnumResponse>>(result.Data);
            return new SuccessDataResult<List<GetListEnumResponse>>(enumMapper);
        }
        return new ErrorDataResult<List<GetListEnumResponse>>();
    }
    #endregion
}

