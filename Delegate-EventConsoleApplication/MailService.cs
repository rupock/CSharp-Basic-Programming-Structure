using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_EventConsoleApplication
{
    public class MailService
    {
        public void OnAudioEncoded(object source,AudioEventArgs e)
        {
            Console.WriteLine("MailService : Sending an email..."+ e.Audio.Title +e.AudioId);
        }

    }
}
