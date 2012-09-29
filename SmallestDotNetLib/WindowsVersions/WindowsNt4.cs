using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.WindowsVersions
{
    public class WindowsNt4 : WindowsVersionCheck
    {
        public WindowsNt4(WindowsVersionFactory factory) : base(factory) { }

        protected override WindowsVersion CheckVersion(string userAgent)
        {
            return userAgent.Contains("Windows NT 4.0") 
                ? WindowsVersion.WindowsNt4 
                : WindowsVersion.Null;
        }

        protected override WindowsVersion NextWindowsVersion
        {
            get { return WindowsVersion.Null; }
        }

        protected override DotNetVersion LatestSupportedDotNet
        {
            get { return DotNetVersion.DotNet1_1; }
        }
    }
}
