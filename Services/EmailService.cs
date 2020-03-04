using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mizgindogancom.Data;
using mizgindogancom.Models;

namespace mizgindogancom.Services
{
    public class EmailService : IEmailService
    {
        private readonly MizginDoganDBContext _context;
        SmtpClient emailClient = new SmtpClient("smtp.gmail.com");
        NetworkCredential SMTPUserInfo = new NetworkCredential("av.mizgindogan@gmail.com", "");
        TInfo mailInfo = new TInfo();

        public EmailService(MizginDoganDBContext context)
        {
            _context = context;
        }     

        private async Task ConfigureMail()
        {
            mailInfo = await _context.TInfo.FirstOrDefaultAsync();
            emailClient.Port = 587;
            emailClient.EnableSsl = true;            
            emailClient.UseDefaultCredentials = false;
            emailClient.Credentials = SMTPUserInfo;
        
        }

        public async Task<bool> MailForComment(TComment comment)
        {
            string header = await FindEntryHeader(comment.EntryId);
            try
            {
               await ConfigureMail();
                MailMessage message = new MailMessage(comment.Email, mailInfo.Mail2,
               comment.Name + " web sitende " + header + " başlıklı yazına yorum yaptı."
               , comment.Email + " adresinden gelen yorum:<br/>" + comment.CommentText);
                message.IsBodyHtml = true;

                emailClient.Send(message);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> MailForMessage(MailModel mailModel)
        {
            try
            {
               await ConfigureMail();
                MailMessage message = new MailMessage(mailModel.Mail, mailInfo.Mail2,
                   mailModel.Name + " web sitene mesaj gönderdi - Konu: " +
                    mailModel.Subject, mailModel.Mail + " adresinden gelen mesaj: " + mailModel.Message +
                    "<br/>Telefon numarası: " + mailModel.PhoneNo);
                message.IsBodyHtml = true;
                emailClient.Send(message);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> MailForReply(TReply reply)
        {
            string header = await FindEntryHeader(reply.EntryId);
            try
            {
               await ConfigureMail();
                MailMessage message = new MailMessage(reply.Email, mailInfo.Mail2,
           reply.Name + " web sitende " + header + " başlıklı yazının " + reply.CommentId +
           " no'lu yorumuna cevap verdi."
           , reply.Email + " adresinden gelen cevap:<br/>" + reply.ReplyText);
                message.IsBodyHtml = true;
                emailClient.Send(message);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<string> FindEntryHeader(int? id)
        {
            var header = await _context.TEntry.Where(x => x.Id == id).FirstOrDefaultAsync();
            return header.Header;
        }
    }
}
