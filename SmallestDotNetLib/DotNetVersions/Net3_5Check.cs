using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.DotNetVersions
{
    public class Net3_5Check : DotNetVersionCheck
    {
        protected override string VersionLabel
        {
            get { return "V3.5"; }
        }

        public Net3_5Check(DotNetVersionFactory factory) : base(factory) { }

        protected override bool IsInstalled(string userAgent)
        {
            return Has35(userAgent) || Has35SP1C(userAgent) || Has35SP1E(userAgent);
        }

        protected override DotNetVersion NextVersion
        {
            get { return DotNetVersion.DotNet3; }
        }

        protected override string LatestVersionMissingMessage
        {
            get { return Constants.GetLatestVersionMissingMessage(VersionLabel, Constants.DotNet35Url, "3MB"); }
        }

        private bool Has35SP1E(String userAgent)
        {
            return userAgent.Contains(Constants.Version35SP1Full);
        }

        private bool Has35SP1C(String userAgent)
        {
            return userAgent.Contains(Constants.Version35SP1Client);
        }

        private bool Has35(String userAgent)
        {
            return userAgent.Contains(Constants.Version35Full);
        }

        private string DotNet3_5Message(int build, bool hasDotNet4)
        {
            switch (build)
            {
                case 21022: //RTM
                    return String.Format("Looks like you {2} have <strong>.NET version 3.5</strong>. The latest version is 3.5 SP1. You can upgrade quickly with this small download for {0}. Also, you should make sure your system is setup to get updates from {1} automatically. This will make sure your system is up to date with the latest stuff, including the latest .NET Framework.", Constants.DotNet35Online, Constants.WindowsUpdate, hasDotNet4 ? "also" : "");
                case 30729: //SP1
                    return String.Format("Looks like you {1} have <strong>.NET version 3.5 SP1</strong>. That's the VERY latest .NET Framework. <strong>You don't need to do anything right now.</strong> However, you might make sure your system is setup to get updates from {0} automatically. This will make sure your system is up to date with the latest stuff, including the latest .NET Framework.", Constants.WindowsUpdate, hasDotNet4 ? "also" : "");
                default:
                    return String.Format("Looks like you <i>might</i> {2} have a <em>beta</em> version of <strong>.NET version 3.5 SP1</strong>. Perhaps you're a programmer or you know one? You should probably uninstall that version and run the small setup program for {0}. Also, you might make sure your system is setup to get updates from {1} automatically. This will make sure your system is up to date with the latest stuff, including the latest .NET Framework.", Constants.DotNet35Online, Constants.WindowsUpdate, hasDotNet4 ? "also" : "");
            }
        }
    }
}
