using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.WindowsVersions
{
    public class Windows98 : WindowsVersionCheck
    {
        public Windows98(WindowsVersionFactory factory) : base(factory) { }

        protected override WindowsVersion CheckVersion(string userAgent)
        {
            return userAgent.Contains("Windows 98") && !userAgent.Contains("Win 9x 4.90") 
                ? WindowsVersion.Windows98 
                : WindowsVersion.Null;
        }

        protected override WindowsVersion NextWindowsVersion
        {
            get { return WindowsVersion.WindowsNt4; }
        }

        protected override DotNetVersion LatestSupportedDotNet
        {
            get { return DotNetVersion.DotNet2; }
        }
    }
}
