using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lurog.NET
{
    public interface ILogger
    {
        public void Log(int severity, string errCode, string message);
    }
}
