using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lurog.NET
{
    public enum Severities
    {
        Notice, // 0, for general system information
        Warning, // 1, for depreciated features
        Error, // 2, for removed features
        Critical // 3, for severe errors which crash the application
    }
}
