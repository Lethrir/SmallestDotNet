using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class Net1Check : DotNetVersionCheck
    {
        public Net1Check(DotNetVersionFactory factory) : base(factory) { }

        protected override bool IsInstalled(string userAgent)
        {
            return userAgent.Contains(".NET CLR 1.0");
        }

        protected override DotNetVersion NextVersion
        {
            get { return DotNetVersion.Null; }
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
