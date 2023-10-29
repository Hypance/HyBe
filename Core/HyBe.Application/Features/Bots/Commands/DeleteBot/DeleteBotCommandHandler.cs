﻿using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Bots.Commands.DeleteBot;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;

namespace HyBe.Application.Features.Bots.Commands.DeleteBot
{
    public class DeleteBotCommandHandler : IRequestHandler<DeleteBotCommand, IResult>
    {
        private readonly IBotService _botService;
        private readonly IMapper _mapper;

        public DeleteBotCommandHandler(IBotService botService, IMapper mapper)
        {
            _botService = botService;
            _mapper = mapper;
        }
        public async Task<IResult> Handle(DeleteBotCommand query, CancellationToken cancellationToken)
        {
            var getBot = _botService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
            if (getBot.Success == false)
            {
                return new ErrorResult("Data Not Found!");
            }
            var result = _botService.Delete(query.Request.Id);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult(result.Message);
        }
    }
}
