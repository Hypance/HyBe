﻿using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Backtests.Queries;
using HyBe.Domain.Entities.Backtests;
using HyBe.Domain.Entities.Symbols;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Symbols.Commands.UpdateSymbol
{
    public class UpdateSymbolCommandHandler : IRequestHandler<UpdateSymbolCommand, IResult>
    {
        #region Fileds
        private readonly ISymbolService _symbolService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public UpdateSymbolCommandHandler(ISymbolService symbolService, IMapper mapper)
        {
            _symbolService = symbolService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(UpdateSymbolCommand query, CancellationToken cancellationToken)
        {
            var getSymbol = _symbolService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
            if (getSymbol == null)
            {
                return new ErrorResult("Data Not Found!");
            }
            var symbolMapper = _mapper.Map<Symbol>(query.Request);
            var result = _symbolService.Update(symbolMapper);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult();
        }
        #endregion
    }


}
