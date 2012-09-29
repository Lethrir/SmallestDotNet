using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class NullDotNetVersion : DotNetVersionCheck
    {
        protected override string VersionLabel
        {
            get { throw new NotImplementedException(); }
        }

        public NullDotNetVersion(DotNetVersionFactory factory) : base(factory) { }

        public override string CheckDotNet(string userAgent, bool latestVersion)
        {
            return string.Empty;
        }

        protected override bool IsInstalled(string userAgent)
        {
            throw new NotImplementedException();
        }

        protected override DotNetVersion NextVersion
        {
            get { throw new NotImplementedException(); }
        }

        protected override string LatestVersionMissingMessage
        {
            get { throw new NotImplementedException(); }
        }
    }
}
