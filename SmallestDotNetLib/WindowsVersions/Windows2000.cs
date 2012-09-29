using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.WindowsVersions
{
    public class Windows2000 : WindowsVersionCheck
    {
        public Windows2000(WindowsVersionFactory factory) : base(factory) { }

        protected override WindowsVersion CheckVersion(string userAgent)
        {
            return userAgent.Contains("Windows NT 5.0") 
                ? WindowsVersion.Windows2000 
                : WindowsVersion.Null;
        }

        protected override WindowsVersion NextWindowsVersion
        {
            get { return WindowsVersion.WindowsMe; }
        }

        protected override DotNetVersion LatestSupportedDotNet
        {
            get { return DotNetVersion.DotNet2; }
        }
    }
}
