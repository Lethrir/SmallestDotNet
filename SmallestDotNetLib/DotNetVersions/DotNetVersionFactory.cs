using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallestDotNetLib;

namespace SmallestDotNetLib.DotNetVersions
{
    public class DotNetVersionFactory
    {
        public DotNetVersionCheck GetVersion(DotNetVersion version)
        {
            switch (version)
            {
                case DotNetVersion.DotNet1:
                    return new Net1Check(this);
                case DotNetVersion.DotNet1_1:
                    return new Net1_1Check(this);
                case DotNetVersion.DotNet2:
                    return new Net2Check(this);
                case DotNetVersion.DotNet3:
                    return new Net3Check(this);
                case DotNetVersion.DotNet3_5:
                    return new Net3_5Check(this);
                case DotNetVersion.DotNet4:
                    return new Net4Check(this);
                case DotNetVersion.DotNet4_5:
                    return new Net4_5Check(this);
                default:
                    return new NullDotNetVersion(this);
            }
        }
    }
}
