using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDotNetLib.WindowsVersions
{
    public class WindowsVersionFactory
    {
        public WindowsVersionCheck GetLatestWindows()
        {
            return GetVersion(WindowsVersion.Windows8);
        }

        public WindowsVersionCheck GetVersion(WindowsVersion version)
        {
            switch (version)
            {
                case WindowsVersion.WindowsNt4:
                    return new WindowsNt4(this);
                case WindowsVersion.Windows98:
                    return new Windows98(this);
                case WindowsVersion.WindowsMe:
                    return new WindowsMe(this);
                case WindowsVersion.Windows2000:
                    return new Windows2000(this);
                case WindowsVersion.WindowsXp:
                    return new WindowsXp(this);
                case WindowsVersion.WindowsVista:
                    return new WindowsVista(this);
                case WindowsVersion.Windows7:
                    return new Windows7(this);
                case WindowsVersion.Windows8:
                    return new Windows8(this);
                default:
                    return new NullWindowsVersion(this);
            }
        }
    }
}
