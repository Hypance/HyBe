using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Enums;
using MediatR;
using HyBe.Domain.Contracts.Enums;

namespace HyBe.Application.Features.Enums.Queries;

public class GetByIdEnumQueryHandler : IRequestHandler<GetByIdEnumQuery, IResult>
{
    #region Fileds
    private readonly IEnumService _enumService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetByIdEnumQueryHandler(IEnumService enumService, IMapper mapper)
    {
        _enumService = enumService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetByIdEnumQuery query, CancellationToken cancellationToken)
    {

        var result = _enumService.Get(b => b.Id == query.Request.Id);
        if (result.Success)
        {
            var enumMapper = _mapper.Map<GetByIdEnumResponse>(result.Data);
            return new SuccessDataResult<GetByIdEnumResponse>(enumMapper);
        }
        return new ErrorDataResult<GetByIdEnumResponse>();
    }
    #endregion
}