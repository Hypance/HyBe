using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Backtests.Queries;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Symbols.Commands.DeleteSymbol
{
    public class DeleteSymbolCommandHandler : IRequestHandler<DeleteSymbolCommand, IResult>
    {
        #region Fileds
        private readonly ISymbolService _symbolService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public DeleteSymbolCommandHandler(ISymbolService symbolService, IMapper mapper)
        {
            _symbolService = symbolService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(DeleteSymbolCommand query, CancellationToken cancellationToken)
        {
            var getSymbol = _symbolService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
            if (getSymbol.Success == false)
            {
                return new ErrorResult("Data Not Found!");
            }
            var result = _symbolService.Delete(query.Request.Id);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult(result.Message);
        }
        #endregion
    }
}
