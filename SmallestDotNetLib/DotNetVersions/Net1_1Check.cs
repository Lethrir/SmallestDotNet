﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class Net1_1Check : DotNetVersionCheck
    {
        public Net1_1Check(DotNetVersionFactory factory) : base(factory) { }
        
        protected override bool IsInstalled(string userAgent)
        {
            return userAgent.Contains(".NET CLR 1.1");
        }

        protected override DotNetVersion NextVersion
        {
            get { return DotNetVersion.DotNet1; }
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
