using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class Net4_5Check : DotNetVersionCheck
    {
        public Net4_5Check(DotNetVersionFactory factory) :base(factory)
        {
        }

        protected override DotNetVersion NextVersion
        {
            get { return DotNetVersion.DotNet4; }
        }

        protected override bool IsInstalled(string userAgent)
        {
            throw new NotImplementedException();
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
