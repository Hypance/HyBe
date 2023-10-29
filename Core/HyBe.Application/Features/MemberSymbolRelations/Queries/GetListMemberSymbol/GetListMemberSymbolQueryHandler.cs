using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.MemberSymbolRelations.Queries.GetListMemberSymbol;
using HyBe.Domain.Contracts.IndicatorSignals;
using HyBe.Domain.Contracts.MemberSymbols;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.MemberSymbolRelations.Queries.GetListMemberSymbol;
public class GetListMemberSymbolQueryHandler : IRequestHandler<GetListMemberSymbolQuery, IResult>
{
    #region Fileds
    private readonly IMemberSymbolService _memberSymbolService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetListMemberSymbolQueryHandler(IMemberSymbolService memberSymbolService, IMapper mapper)
    {
        _memberSymbolService = memberSymbolService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetListMemberSymbolQuery query, CancellationToken cancellationToken)
    {

        var result = _memberSymbolService.GetAll(b => b.MemberId.ToString() == query.Request.MemberId);
        if (result.Success)
        {
            var memberSymbolMapper = _mapper.Map<List<GetListMemberSymbolResponse>>(result.Data);
            return new SuccessDataResult<List<GetListMemberSymbolResponse>>(memberSymbolMapper);
        }
        return new ErrorDataResult<List<GetListMemberSymbolResponse>>(result.Message);
    }
    #endregion
}
