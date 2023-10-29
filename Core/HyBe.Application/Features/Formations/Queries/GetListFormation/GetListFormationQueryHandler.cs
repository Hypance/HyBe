using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Formations.Queries.GetListFormation;
using HyBe.Domain.Contracts.Backtests;
using HyBe.Domain.Contracts.Formations;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Bots.Queries.GetListBot
{
    public class GetListFormationQueryHandler : IRequestHandler<GetListFormationQuery, IResult>
    {

        private readonly IFormationService _formationService;
        private readonly IMapper _mapper;

        public GetListFormationQueryHandler(IFormationService formationService, IMapper mapper)
        {
            _formationService = formationService;
            _mapper = mapper;
        }
        public async Task<IResult> Handle(GetListFormationQuery query, CancellationToken cancellationToken)
        {

            var result = _formationService.GetAll(b => b.MemberId.ToString() == query.Request.MemberId);
            if (result.Success)
            {
                var formationMapper = _mapper.Map<List<GetListFormationResponse>>(result.Data);
                return new SuccessDataResult<List<GetListFormationResponse>>(formationMapper);
            }
            return new ErrorDataResult<List<GetListFormationResponse>>(result.Message);
        }
    }
}