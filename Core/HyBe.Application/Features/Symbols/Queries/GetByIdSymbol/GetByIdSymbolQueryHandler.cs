using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Backtests.Queries;
using HyBe.Domain.Contracts.Backtests;
using HyBe.Domain.Contracts.Symbols;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Symbols.Queries.GetByIdSymbol
{
    public class GetByIdSymbolQueryHandler : IRequestHandler<GetByIdSymbolQuery, IResult>
    {
        #region Fileds
        private readonly ISymbolService _symbolService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public GetByIdSymbolQueryHandler(ISymbolService symbolService, IMapper mapper)
        {
            _symbolService = symbolService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(GetByIdSymbolQuery query, CancellationToken cancellationToken)
        {

            var result = _symbolService.Get(b => b.Id == query.Request.Id);
            if (result.Success)
            {
                var symbolMapper = _mapper.Map<GetByIdSymbolResponse>(result.Data);
                return new SuccessDataResult<GetByIdSymbolResponse>(symbolMapper);
            }
            return new ErrorDataResult<GetByIdSymbolResponse>(result.Message);
        }
        #endregion
    }

}
