using HyBe.Application.Abstractions.Services;
using AutoMapper;
using MediatR;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Contracts.Symbols;

namespace HyBe.Application.Features.Symbols.Queries.GetListSymbol;

public class GetListSymbolQueryHandler: IRequestHandler<GetListSymbolQuery, IResult>
{
    private readonly ISymbolService _symbolService;
    private readonly IMapper _mapper;

    public GetListSymbolQueryHandler(ISymbolService symbolService, IMapper mapper)
    {
        _symbolService = symbolService;
        _mapper = mapper;
    }

    public async Task<IResult> Handle(GetListSymbolQuery query, CancellationToken cancellationToken)
    {

        var result = _symbolService.GetAll();
        if (result.Success) 
        {
            var symbolMapper = _mapper.Map<List<GetListSymbolResponse>>(result.Data);
            return new SuccessDataResult<List<GetListSymbolResponse>>(symbolMapper);
        }
        return new ErrorDataResult<List<GetListSymbolResponse>>(result.Message);
    }
}

