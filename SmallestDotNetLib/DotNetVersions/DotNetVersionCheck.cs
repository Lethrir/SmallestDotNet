using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public abstract class DotNetVersionCheck
    {
        private readonly DotNetVersionFactory _factory;

        protected abstract bool IsInstalled(string userAgent);
        protected abstract DotNetVersion NextVersion { get; }
        protected abstract string UpToDateMessage { get; }
        protected abstract string LatestVersionMissingMessage { get; }
        protected abstract string VersionInstalledMessage { get; }

        public DotNetVersionCheck(DotNetVersionFactory factory)
        {
            _factory = factory;
        }

        public virtual string CheckDotNet(string userAgent, bool latestVersion)
        {
            var installed = IsInstalled(userAgent);

            if (installed && latestVersion)
            {
                return UpToDateMessage;
            }

            if (latestVersion)
            {
                return NextVersionMessage(userAgent) + LatestVersionMissingMessage;
            }

            if (installed)
            {
                return VersionInstalledMessage;
            }

            return NextVersionMessage(userAgent);
        }

        private string NextVersionMessage(string userAgent)
        {
            return _factory.GetVersion(NextVersion).CheckDotNet(userAgent, false);
        }
    }
}
