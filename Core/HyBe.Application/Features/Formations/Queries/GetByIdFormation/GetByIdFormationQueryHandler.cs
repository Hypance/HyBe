using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Contracts.Formations;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Formations.Queries.GetByIdFormation
{
    public class GetByIdFormationQueryHandler : IRequestHandler<GetByIdFormationQuery, IResult>
    {
        private readonly IFormationService _formationService;
        private readonly IMapper _mapper;

        public GetByIdFormationQueryHandler(IFormationService formationService, IMapper mapper)
        {
            _formationService = formationService;
            _mapper = mapper;
        }
        public async Task<IResult> Handle(GetByIdFormationQuery query, CancellationToken cancellationToken)
        {

            var result = _formationService.Get(b => b.MemberId.ToString() == query.Request.MemberId && b.Id == query.Request.Id);
            if (result.Success)
            {
                var formationMapper = _mapper.Map<GetByIdFormationResponse>(result.Data);
                return new SuccessDataResult<GetByIdFormationResponse>(formationMapper);
            }
            return new ErrorDataResult<GetByIdFormationResponse>(result.Message);
        }
    }
}
