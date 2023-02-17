using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.FormationSignals.Commands.DeleteFormationSignal
{
    public class DeleteFormationSignalCommandHandler : IRequestHandler<DeleteFormationSignalCommand, IResult>
    {
        #region Fields
        private readonly IFormationSignalService _FormationSignalService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public DeleteFormationSignalCommandHandler(IFormationSignalService FormationSignalService, IMapper mapper)
        {
            _FormationSignalService = FormationSignalService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(DeleteFormationSignalCommand query, CancellationToken cancellationToken)
        {
            var result = _FormationSignalService.Delete(query.Request.Id);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult(result.Message);
        }
        #endregion
    }
}
