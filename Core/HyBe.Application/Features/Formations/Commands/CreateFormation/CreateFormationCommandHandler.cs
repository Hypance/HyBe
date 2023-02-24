using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;
using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Formations;

namespace HyBe.Application.Features.Formations.Commands.CreateFormation;

public class CreateFormationCommandHandler : IRequestHandler<CreateFormationCommand, IResult>
{
    private readonly IFormationService _formationService;
    private readonly IMapper _mapper;
    public CreateFormationCommandHandler(IFormationService formationService, IMapper mapper)
    {
        _formationService = formationService;
        _mapper = mapper;
    }
    public async Task<IResult> Handle(CreateFormationCommand query, CancellationToken cancellationToken)
    {
        var formationMapper = _mapper.Map<Formation>(query.Request);
        var result = _formationService.Add(formationMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult(result.Message);
    }
}

