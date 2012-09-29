using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.WindowsVersions
{
    public class Windows8 : WindowsVersionCheck
    {
        public Windows8(WindowsVersionFactory factory) : base(factory) { }

        protected override WindowsVersion CheckVersion(string userAgent)
        {
            return (userAgent.Contains(Constants.Windows8))
                    ? WindowsVersion.Windows8
                    : WindowsVersion.Null;    
        }

        protected override WindowsVersion NextWindowsVersion
        {
            get { return WindowsVersion.Windows7; }
        }

        protected override DotNetVersion LatestSupportedDotNet
        {
            get { return DotNetVersion.DotNet4_5; }
        }
    }
}
