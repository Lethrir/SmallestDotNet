using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class Net2Check : DotNetVersionCheck
    {
        protected override string VersionLabel
        {
            get { return "V2.0"; }
        }

        public Net2Check(DotNetVersionFactory factory) : base(factory) { }

        protected override bool IsInstalled(string userAgent)
        {
            return userAgent.Contains(Constants.Version20Full);
        }

        protected override DotNetVersion NextVersion
        {
            get { return DotNetVersion.DotNet1_1; }
        }

        protected override string LatestVersionMissingMessage
        {
            get { return Constants.GetLatestVersionMissingMessage(VersionLabel, Constants.WindowsUpdate, "23MB"); }
        }
    }
}
