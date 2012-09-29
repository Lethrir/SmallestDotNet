using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class Net3_5Check : DotNetVersionCheck
    {
        public Net3_5Check(DotNetVersionFactory factory) : base(factory) { }

        protected override bool IsInstalled(string userAgent)
        {
            return Has35(userAgent) || Has35SP1C(userAgent) || Has35SP1E(userAgent);
        }

        protected override DotNetVersion NextVersion
        {
            get { return DotNetVersion.DotNet3; }
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

        private bool Has35SP1E(String userAgent)
        {
            return userAgent.Contains(".NET CLR 3.5.30729");
        }

        private bool Has35SP1C(String userAgent)
        {
            return userAgent.Contains(".NET Client 3.5");
        }

        private bool Has35(String userAgent)
        {
            return userAgent.Contains(".NET CLR 3.5.21022");
        }
    }
}
