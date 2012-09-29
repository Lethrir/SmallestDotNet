using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.WindowsVersions
{
    public class WindowsMe:WindowsVersionCheck
    {
        public WindowsMe(WindowsVersionFactory factory) : base(factory) { }

        protected override WindowsVersion CheckVersion(string userAgent)
        {
            return userAgent.Contains("Win 9x 4.90") 
                ? WindowsVersion.WindowsMe 
                : WindowsVersion.Null;
        }

        protected override WindowsVersion NextWindowsVersion
        {
            get { return WindowsVersion.Windows98; }
        }

        protected override DotNetVersion LatestSupportedDotNet
        {
            get { return DotNetVersion.DotNet2; }
        }
    }
}
