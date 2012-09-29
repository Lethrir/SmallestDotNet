using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class Net3Check : DotNetVersionCheck
    {
        protected override string VersionLabel
        {
            get { return "V3.0"; }
        }

        public Net3Check(DotNetVersionFactory factory) : base(factory) { }

        protected override bool IsInstalled(string userAgent)
        {
            return userAgent.Contains(Constants.Version30Full);
        }

        protected override DotNetVersion NextVersion
        {
            get { return DotNetVersion.DotNet2; }
        }

        protected override string LatestVersionMissingMessage
        {
            // never latest
            get { return string.Empty; }
        }

    }
}
