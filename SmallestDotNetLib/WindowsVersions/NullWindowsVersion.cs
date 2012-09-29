using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.WindowsVersions
{
    public class NullWindowsVersion : WindowsVersionCheck
    {
        public NullWindowsVersion(WindowsVersionFactory factory) : base(factory) { }
        
        public override string CheckOs(string userAgent)
        {
            return "Unsupported operating system version...";
        }

        protected override WindowsVersion CheckVersion(string userAgent)
        {
            throw new NotImplementedException();
        }

        protected override WindowsVersion NextWindowsVersion
        {
            get { throw new NotImplementedException(); }
        }

        protected override DotNetVersion LatestSupportedDotNet
        {
            get { throw new NotImplementedException(); }
        }
    }
}
