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
            var bot = _formationService.Get(x => x.Id == query.Request.Id);
            var getBacktest = _formationService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
            if (getBacktest == null)
            {
                return new ErrorResult("Data Not Found!");
            }
            if (!bot.Success)
                return new ErrorResult();
            var result = _formationService.Update(query.Request.Id);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult();
        }
        #endregion
    }
}
