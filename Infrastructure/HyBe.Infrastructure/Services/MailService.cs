using HyBe.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyBe.Infrastructure.Services
{
	public class MailService : IMailService
	{
		public Task SendMailAsync(string to, string subject, string body, bool isBodyHtml = true)
		{
			throw new NotImplementedException();
		}

		public Task SendMailAsync(string[] tos, string subject, string body, bool isBodyHtml = true)
		{
			throw new NotImplementedException();
		}

		public Task SendPasswordResetMailAsync(string to, string userId, string resetToken)
		{
			throw new NotImplementedException();
		}
	}
}