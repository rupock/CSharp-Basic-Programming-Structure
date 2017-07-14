using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_EventConsoleApplication
{
    public class AudioEventArgs :EventArgs
    {
        public Audio Audio { get; set; }
        public int AudioId { get; set; }
    }
}
