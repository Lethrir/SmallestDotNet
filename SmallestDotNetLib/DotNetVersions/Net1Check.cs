using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class Net1Check : DotNetVersionCheck
    {
        protected override string VersionLabel { get { return "V1.0"; } }

        public Net1Check(DotNetVersionFactory factory) : base(factory) { }

        protected override bool IsInstalled(string userAgent)
        {
            return userAgent.Contains(Constants.Version10Full);
        }

        protected override DotNetVersion NextVersion
        {
            get { return DotNetVersion.Null; }
        }

        protected override string LatestVersionMissingMessage
        {
            // no version cannot be updated to 1.1
            get { return string.Empty; }
        }
    }
}
