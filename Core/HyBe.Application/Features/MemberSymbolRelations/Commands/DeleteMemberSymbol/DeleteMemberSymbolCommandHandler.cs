using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.MemberSymbolRelations.Commands.DeleteMemberSymbol;

public class DeleteMemberSymbolCommandHandler : IRequestHandler<DeleteMemberSymbolCommand, IResult>
{
    #region Fileds
    private readonly IMemberSymbolService _memberSymbolService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public DeleteMemberSymbolCommandHandler(IMemberSymbolService memberSymbolService, IMapper mapper)
    {
        _memberSymbolService = memberSymbolService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(DeleteMemberSymbolCommand query, CancellationToken cancellationToken)
    {
        var getMemberSymbol = _memberSymbolService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
        if (getMemberSymbol.Success == false)
        {
            return new ErrorResult("Data Not Found!");
        }
        var result = _memberSymbolService.Delete(query.Request.Id);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult(result.Message);
    }
    #endregion
}
