using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Indicators;
using MediatR;
using HyBe.Domain.Contracts.Enums;


namespace HyBe.Application.Features.Enums.Commands;

public class DeleteEnumCommandHandler : IRequestHandler<DeleteEnumCommand, IResult>
{
    #region Fileds
    private readonly IEnumService _enumService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public DeleteEnumCommandHandler(IEnumService enumService, IMapper mapper)
    {
        _enumService = enumService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(DeleteEnumCommand query, CancellationToken cancellationToken)
    {
        var result = _enumService.Delete(query.Request.Id);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

