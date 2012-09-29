using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.WindowsVersions
{
    public class WindowsXp : WindowsVersionCheck
    {
        public WindowsXp(WindowsVersionFactory factory) : base(factory) { }

        protected override WindowsVersion CheckVersion(string userAgent)
        {
            return userAgent.Contains("Windows NT 5.1") 
                ? WindowsVersion.WindowsXp 
                : WindowsVersion.Null;
        }

        protected override WindowsVersion NextWindowsVersion
        {
            get { return WindowsVersion.Windows2000; }
        }

        protected override DotNetVersion LatestSupportedDotNet
        {
            get { return DotNetVersion.DotNet4; }
        }
    }
}
