using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class Net3Check : DotNetVersionCheck
    {
        public Net3Check(DotNetVersionFactory factory) : base(factory) { }

        protected override bool IsInstalled(string userAgent)
        {
            return userAgent.Contains(".NET CLR 3.0");
        }

        protected override DotNetVersion NextVersion
        {
            get { return DotNetVersion.DotNet2; }
        }

        protected override string UpToDateMessage
        {
            get { throw new NotImplementedException(); }
        }

        protected override string LatestVersionMissingMessage
        {
            get { throw new NotImplementedException(); }
        }

        protected override string VersionInstalledMessage
        {
            get { throw new NotImplementedException(); }
        }
    }
}
