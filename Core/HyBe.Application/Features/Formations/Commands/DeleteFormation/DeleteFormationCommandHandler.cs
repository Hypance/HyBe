using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Formations.Commands.DeleteFormation;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;

namespace HyBe.Application.Features.Formations.Commands.DeleteFormation
{
    public class DeleteFormationCommandHandler : IRequestHandler<DeleteFormationCommand, IResult>
    {
        private readonly IFormationService _formationService;
        private readonly IMapper _mapper;

        public DeleteFormationCommandHandler(IFormationService formationService, IMapper mapper)
        {
            _formationService = formationService;
            _mapper = mapper;
        }
        public async Task<IResult> Handle(DeleteFormationCommand query, CancellationToken cancellationToken)
        {
            var result = _formationService.Delete(query.Request.Id);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult();
        }
    }
}
