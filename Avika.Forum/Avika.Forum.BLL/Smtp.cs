using Avika.Forum.LogDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Avika.Forum.BLL
{
    public class Smtp: SmtpClient
    {
        Logger _logger;
        public Smtp(Logger logger)
        {
            _logger = logger;
            string  port = WebConfigurationManager.AppSettings["portMail"];
            string  server = WebConfigurationManager.AppSettings["serveMail"];
            string email = WebConfigurationManager.AppSettings["emailMail"];
            string password = WebConfigurationManager.AppSettings["passwordMail"];
            string enableSsl = WebConfigurationManager.AppSettings["enableSsl"];
            this.Port =string.IsNullOrEmpty(port) ?  8889 : int.Parse(port);
            this.EnableSsl = string.IsNullOrEmpty(enableSsl) ? false : bool.Parse(enableSsl);
            this.Credentials = new System.Net.NetworkCredential(email, password);
            this.Host = server;
        }
        public async Task SendEmailAsync(MailMessage message)
        {
            Task.Run(()=>{
                Send(message);
            });
        }
        public string Send(MailMessage mensaje)
        {
            string resp = "Se envio correctamente el correo";
            try
            {
                this.Send(mensaje);
                _logger.EscribirLog(resp);
            }
            catch (Exception e)
            {
                _logger.EscribirError(e.ToString());
            }
            return resp;
        }
    }
}
