using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Backtests.Queries;
using HyBe.Domain.Contracts.Backtests;
using HyBe.Domain.Contracts.IndicatorSignals;
using HyBe.Domain.Contracts.Symbols;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Symbols.Queries.GetListSymbol
{
    public class GetListSymbolQueryHandler : IRequestHandler<GetListSymbolQuery, IResult>
    {
        #region Fileds
        private readonly ISymbolService _symbolService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public GetListSymbolQueryHandler(ISymbolService symbolService, IMapper mapper)
        {
            _symbolService = symbolService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
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
        #endregion
    }

}
