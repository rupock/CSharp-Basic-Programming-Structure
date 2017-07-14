using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate_EventConsoleApplication
{
    public class AudioEncoder
    {
        /// <summary>
        /// 1. Define a delegate
        /// 2. Define a event based on that delegate
        /// 3. Raise the event
        /// </summary>
        /// <param name="audio"></param>


        public delegate void AudioEncodedEventHandler(object source, AudioEventArgs args);
        public event AudioEncodedEventHandler AudioEncoded;
        public void Encode(Audio audio)
        {
            Console.WriteLine("Encoding audio.....");
            Thread.Sleep(2000);
            OnAudioEncoded(audio);
        }
        protected virtual void OnAudioEncoded(Audio audio)
        {
            if(AudioEncoded!=null)
            {
                AudioEncoded(this, new AudioEventArgs() { Audio=audio});
            }
        }
    }
}
