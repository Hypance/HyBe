using System;
using HyBe.Application.Abstractions.Infrastructure;
using HyBe.Domain.Contracts.Notifications;
using HyBe.SharedKernel.Utilities;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.GettingUpdates;

namespace HyBe.Infrastructure.Services.NotificationService
{
	public class TelegramNotificationService : INotificationService
	{

        #region Fields
        const string token = "5608179374:AAFpwKxuVMbgBm2ZbCFeERufxCesblNohzM";
        const long chatId = 1357802322;
        private readonly BotClient _botClient;
        #endregion

        #region Constructor
        public TelegramNotificationService()
        {
            _botClient = new BotClient(token);
        }
        #endregion

        #region Methods
        public IResult SendNotification(SendNotificationRequest request)
        {
            try
            {
                //chatId ve token User tablosundan alınacak.
                if (string.IsNullOrEmpty(request.Message))
                    throw new Exception("Message is not null!..");

               _botClient.SendMessage(chatId, request.Message);
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

