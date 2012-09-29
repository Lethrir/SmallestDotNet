using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class Net2Check : DotNetVersionCheck
    {
        public Net2Check(DotNetVersionFactory factory) : base(factory) { }

        protected override bool IsInstalled(string userAgent)
        {
            return userAgent.Contains(".NET CLR 2.0");
        }

        protected override DotNetVersion NextVersion
        {
            get { return DotNetVersion.DotNet1_1; }
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
