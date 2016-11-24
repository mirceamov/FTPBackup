using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Salvator
{
    public static class functiiUtile
    {
        public static void CreeazaDirectorFTP(string _caleDirFTP)
        {
            try
            {
                WebRequest request = WebRequest.Create(_caleDirFTP);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.Credentials = new NetworkCredential(VarGlobal.userFTP, VarGlobal.passFTP);
                request.Timeout = 1000;
                using (var resp = (FtpWebResponse)request.GetResponse())
                {
                    ScrieLog("Director creat : " + _caleDirFTP + "(status : " + resp.StatusCode.ToString() + ")", VarGlobal.fisierLogGeneral);
                }
            }
            catch(Exception ex)
            {
            }
        }
        
        public static void ScrieLog(string _mesajLog, string _fisierLog)
        {
            File.AppendAllText(_fisierLog, _mesajLog + Environment.NewLine);
        }

        public static void TrimiteEmail(string _subiect, string _body)
        {
            var fromAddress = new MailAddress("mimoso.romania@gmail.com", "Aplicatia Salvator");            
            const string fromPassword = "mimoso2015";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage()
            {
                From = fromAddress,
                Subject = _subiect,
                Body = _body
            })
            {
                foreach (var adresa in VarGlobal.adreseMailErori.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                {
                    message.To.Add(adresa);
                }
                smtp.Send(message);
            }
        }
    }
}
