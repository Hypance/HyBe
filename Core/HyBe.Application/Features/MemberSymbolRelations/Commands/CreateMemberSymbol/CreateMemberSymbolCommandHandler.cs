using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Members;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;

namespace HyBe.Application.Features.MemberSymbolRelations.Commands.CreateMemberSymbol;
public class CreateMemberSymbolCommandHandler : IRequestHandler<CreateMemberSymbolCommand, IResult>
{
    #region Fileds
    private readonly IMemberSymbolService _memberSymbolService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public CreateMemberSymbolCommandHandler(IMemberSymbolService memberSymbolService, IMapper mapper)
    {
        _memberSymbolService = memberSymbolService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(CreateMemberSymbolCommand query, CancellationToken cancellationToken)
    {
        var memberSymbolMapper = _mapper.Map<MemberSymbol>(query.Request);
        var result = _memberSymbolService.Add(memberSymbolMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}