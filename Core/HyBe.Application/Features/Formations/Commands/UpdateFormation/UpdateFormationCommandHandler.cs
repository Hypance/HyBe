using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;

using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Formations;

namespace HyBe.Application.Features.Formations.Commands.UpdateFormation
{
    public class UpdateFormationCommandHandler : IRequestHandler<UpdateFormationCommand, IResult>
    {
        #region Fields
        private readonly IFormationService _formationService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public UpdateFormationCommandHandler(IFormationService formationService, IMapper mapper)
        {
            _formationService = formationService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(UpdateFormationCommand query, CancellationToken cancellationToken)
        {
            var formationMapper = _mapper.Map<Formation>(query.Request);
            var result = _formationService.Update(formationMapper);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult();
        }
        #endregion
    }
}
