using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace BookHub.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(String email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
