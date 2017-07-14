﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_EventConsoleApplication
{
    public class MessageService
    {

        public void OnAudioEncoded(object source, AudioEventArgs e)
        {
            Console.WriteLine("MessageService : Sending a text messages...."+ e.Audio.Title +e.AudioId);
        }
    }
}
