using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Enums;
using MediatR;
using HyBe.Domain.Contracts.Enums;

namespace HyBe.Application.Features.Enums.Commands;

public class UpdateEnumCommandHandler : IRequestHandler<UpdateEnumCommand, IResult>
{
    #region Fileds
    private readonly IEnumService _enumService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public UpdateEnumCommandHandler(IEnumService enumService, IMapper mapper)
    {
        _enumService = enumService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(UpdateEnumCommand query, CancellationToken cancellationToken)
    {
        var enumMapper = _mapper.Map<Enum>(query.Request);
        var result = _enumService.Update(enumMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

