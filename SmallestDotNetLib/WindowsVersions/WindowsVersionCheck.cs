using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallestDotNetLib.DotNetVersions;

namespace SmallestDotNetLib.WindowsVersions
{
    public abstract class WindowsVersionCheck
    {
        private readonly WindowsVersionFactory _factory;
        private readonly DotNetVersionFactory _dotNetFactory;

        protected abstract WindowsVersion CheckVersion(string userAgent);
        protected abstract WindowsVersion NextWindowsVersion { get; }
        protected abstract DotNetVersion LatestSupportedDotNet { get; }
        
        public virtual string CheckOs(string userAgent)
        {
            var version = CheckVersion(userAgent);
            if (version != WindowsVersion.Null)
            {
                var netCheck = _dotNetFactory.GetVersion(LatestSupportedDotNet);
                return netCheck.CheckDotNet(userAgent, true);
            }
            else
            {
                var next = _factory.GetVersion(NextWindowsVersion);
                return next.CheckOs(userAgent);
            }
        }

        public WindowsVersionCheck(WindowsVersionFactory factory)
        {
            _factory = factory;
            _dotNetFactory = new DotNetVersionFactory();
        }
    }
}
