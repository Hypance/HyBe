using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;
using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Wallets;
using HyBe.Application.Features.Wallets.Commands;

namespace HyBe.Application.Features.Wallets.Queries;

public class CreateWalletCommandHandler : IRequestHandler<CreateWalletCommand, IResult>
{
    private readonly IWalletService _walletService;
    private readonly IMapper _mapper;
    public CreateWalletCommandHandler(IWalletService walletService, IMapper mapper)
    {
        _walletService = walletService;
        _mapper = mapper;
    }
    public async Task<IResult> Handle(CreateWalletCommand query, CancellationToken cancellationToken)
    {
        var walletMapper = _mapper.Map<Wallet>(query.Request);
        var result = _walletService.Add(walletMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult(result.Message);
    }
}

