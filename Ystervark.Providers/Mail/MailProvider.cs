using System.Diagnostics;

namespace Ystervark.Providers.Mail
{
    public class MailProvider : IMailProvider
    {
        #region Implementation of IMailProvider

        public void SendMailMessage()
        {
            Debug.Print("Mail message sent...");
        }

        #endregion
    }
}