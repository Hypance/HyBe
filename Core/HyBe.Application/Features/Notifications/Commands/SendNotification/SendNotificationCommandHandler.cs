using System;
using HyBe.Application.Abstractions.Infrastructure;
using HyBe.Domain.Contracts.Notifications;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Notifications.Commands.SendNotification
{
    public class SendNotificationCommandHandler : IRequestHandler<SendNotificationCommand, IResult>
    {
        #region Fields
        private readonly INotificationService _notificationService;
        #endregion

        #region Constructor
        public SendNotificationCommandHandler(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(SendNotificationCommand command, CancellationToken cancellationToken)
        {
            try
            {
               var result = _notificationService.SendNotification(command.Request);
                if (!result.Success)
                    throw new Exception(result.Message);

                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
        #endregion



    }
}

