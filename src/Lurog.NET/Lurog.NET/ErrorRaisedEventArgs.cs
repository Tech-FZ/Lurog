using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lurog.NET
{
    public class ErrorRaisedEventArgs : EventArgs
    {
        public int Severity { get; }
        public string? ErrorCode { get; }
        public DateTime TimeOccurence { get; }
        public string? Message { get; }
    }
}
