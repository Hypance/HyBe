using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Contracts.FormationSignals;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.FormationSignals.Queries.GetByIdFormationSignal
{
    public class GetByIdFormationSignalQueryHandler : IRequestHandler<GetByIdFormationSignalQuery, IResult>
    {
        #region Fields
        private readonly IFormationSignalService _formationSignalService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public GetByIdFormationSignalQueryHandler(IFormationSignalService formationSignalService, IMapper mapper)
        {
            _formationSignalService = formationSignalService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(GetByIdFormationSignalQuery query, CancellationToken cancellationToken)
        {

            var result = _formationSignalService.Get(b => b.MemberId.ToString() == query.Request.MemberId && b.Id == query.Request.Id);
            if (result.Success)
            {
                var formationSignalMapper = _mapper.Map<GetByIdFormationSignalResponse>(result.Data);
                return new SuccessDataResult<GetByIdFormationSignalResponse>(formationSignalMapper);
            }
            return new ErrorDataResult<GetByIdFormationSignalResponse>(result.Message);
        }
        #endregion
    }
}
