using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.WindowsVersions
{
    public class WindowsVista :WindowsVersionCheck
    {
        public WindowsVista(WindowsVersionFactory factory) : base(factory) { }

        protected override WindowsVersion CheckVersion(string userAgent)
        {
            return (userAgent.Contains("Windows NT 6.0"))
                    ? WindowsVersion.WindowsVista
                    : WindowsVersion.Null;
        }

        protected override WindowsVersion NextWindowsVersion
        {
            get { return WindowsVersion.WindowsXp; }
        }

        protected override DotNetVersion LatestSupportedDotNet
        {
            get { return DotNetVersion.DotNet4_5; }
        }
    }
}
