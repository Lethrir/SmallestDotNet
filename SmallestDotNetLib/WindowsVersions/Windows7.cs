using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.WindowsVersions
{
    public class Windows7 : WindowsVersionCheck
    {
        public Windows7(WindowsVersionFactory factory) : base(factory) { }
        
        protected override WindowsVersion CheckVersion(string userAgent)
        {
            return (userAgent.Contains("Windows NT 6.1"))
                    ? WindowsVersion.Windows7
                    : WindowsVersion.Null;
        }

        protected override WindowsVersion NextWindowsVersion
        {
            get { return WindowsVersion.WindowsVista; }
        }

        protected override DotNetVersion LatestSupportedDotNet
        {
            get { return DotNetVersion.DotNet4_5; }
        }
    }

}
