using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class Net4Check : DotNetVersionCheck
    {
        protected override string VersionLabel
        {
            get { return "V4.0"; }
        }

        public Net4Check(DotNetVersionFactory factory) : base(factory) { }
        
        protected override bool IsInstalled(string userAgent)
        {
            return Has40C(userAgent) || Has40E(userAgent);
        }

        protected override DotNetVersion NextVersion
        {
            get { return DotNetVersion.DotNet3_5; }
        }

        protected override string LatestVersionMissingMessage
        {
            get { return Constants.GetLatestVersionMissingMessage(VersionLabel, "http://www.microsoft.com/en-us/download/details.aspx?displaylang=en&id=17718", "48MB"); }
        }

        public static bool Has40E(String UserAgent)
        {
            return UserAgent.Contains(Constants.Version40Full);
        }

        public static bool Has40C(String UserAgent)
        {
            return UserAgent.Contains(Constants.Version40Client);
        }


    }
}
