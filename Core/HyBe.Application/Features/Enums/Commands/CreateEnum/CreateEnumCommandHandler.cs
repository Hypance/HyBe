using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Enums;
using MediatR;
using HyBe.Domain.Contracts.Enums;

namespace HyBe.Application.Features.Enums.Commands;

public class CreateEnumCommandHandler : IRequestHandler<CreateEnumCommand, IResult>
{
    #region Fileds
    private readonly IEnumService _enumService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public CreateEnumCommandHandler(IEnumService enumService, IMapper mapper)
    {
        _enumService = enumService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(CreateEnumCommand query, CancellationToken cancellationToken)
    {
        var enumMapper = _mapper.Map<Enum>(query.Request);
        var result = _enumService.Add(enumMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

