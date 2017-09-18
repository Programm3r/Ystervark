using System.Diagnostics;
using Ystervark.Providers.Interface;

namespace Ystervark.Providers.Implementation.Mail
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