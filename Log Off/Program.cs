using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Log_Off
{
    class Program
    {
        static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        static void Main(string[] args)
        {
            ExitWindowsEx(0, 0);
        }
    }
}
