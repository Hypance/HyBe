using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.FormationSignals.Queries;
using HyBe.Domain.Entities.Formations;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.FormationSignals.Commands.CreateFormationSignal
{
    public class CreateFormationSignalCommandHandler : IRequestHandler<CreateFormationSignalCommand, IResult>
    {
        #region Fields
        private readonly IFormationSignalService _formationSignalService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public CreateFormationSignalCommandHandler(IFormationSignalService FormationSignalService, IMapper mapper)
        {
            _formationSignalService = FormationSignalService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(CreateFormationSignalCommand query, CancellationToken cancellationToken)
        {
            var FormationSignalMapper = _mapper.Map<FormationSignal>(query.Request);
            var result = _formationSignalService.Add(FormationSignalMapper);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult(result.Message);
        }
        #endregion
    }
}
