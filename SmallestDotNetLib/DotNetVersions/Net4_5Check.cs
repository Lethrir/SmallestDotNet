using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class Net4_5Check : DotNetVersionCheck
    {
        protected override string VersionLabel
        {
            get { return "V4.5"; }
        }

        public Net4_5Check(DotNetVersionFactory factory) :base(factory)
        {
        }

        protected override DotNetVersion NextVersion
        {
            get { return DotNetVersion.DotNet4; }
        }

        protected override bool IsInstalled(string userAgent)
        {
            return userAgent.Contains(Constants.Windows8);
        }

        protected override string UpToDateMessage
        {
            get { return String.Format(Constants.EarlyAdopter, "full install of .NET 4.5"); }
        }

        protected override string LatestVersionMissingMessage
        {
            get { return "Your system supports .NET 4.5 but we are unable to tell if it is installed."; }
        }
    }
}
