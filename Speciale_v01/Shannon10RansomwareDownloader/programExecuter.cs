using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shannon10RansomwareDownloader
{
    class programExecuter
    {
        public static void executeProgram(string programPath)
        {
            Process.Start(programPath);
        }
    }
}
