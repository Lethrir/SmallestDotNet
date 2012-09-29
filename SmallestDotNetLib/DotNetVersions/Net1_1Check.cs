using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class Net1_1Check : DotNetVersionCheck
    {
        protected override string VersionLabel { get { return "V1.1"; } }

        public Net1_1Check(DotNetVersionFactory factory) : base(factory) { }
        
        protected override bool IsInstalled(string userAgent)
        {
            return userAgent.Contains(Constants.Version11Full);
        }

        protected override DotNetVersion NextVersion
        {
            get { return DotNetVersion.DotNet1; }
        }

        protected override string LatestVersionMissingMessage
        {
            get { return Constants.GetLatestVersionMissingMessage(VersionLabel, "http://www.microsoft.com/en-us/download/details.aspx?displaylang=en&id=26", "23MB"); }
        }
    }
}
