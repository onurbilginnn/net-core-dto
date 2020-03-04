using mizgindogancom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mizgindogancom.Services
{
   public interface IEmailService
    {
         Task<bool> MailForMessage(MailModel mailModel);
         Task<bool> MailForComment(TComment comment);
         Task<bool> MailForReply(TReply reply);
    }
}
