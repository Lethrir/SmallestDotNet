using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SmallestTest
{
    [TestClass]
    public class OperatingSystemCheckTests
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }

    public class Windows8Check : WindowsVersionCheck
    {
        protected override WindowsVersion CheckVersion(string userAgent)
        {
            throw new NotImplementedException();
        }

        protected override WindowsVersionCheck GetNextVersion()
        {
            throw new NotImplementedException();
        }
    }

    public class Windows7Check : WindowsVersionCheck
    {
        protected override WindowsVersion CheckVersion(string userAgent)
        {
            throw new NotImplementedException();
        }

        protected override WindowsVersionCheck GetNextVersion()
        {
            throw new NotImplementedException();
        }
    }

    public class NullWindowsVersion : WindowsVersionCheck
    {
        protected override WindowsVersion CheckVersion(string userAgent)
        {
            throw new NotImplementedException();
        }

        protected override WindowsVersionCheck GetNextVersion()
        {
            throw new NotImplementedException();
        }

        public override string CheckOs(string userAgent)
        {
            return string.Empty;
        }
    }

    public abstract class WindowsVersionCheck
    {
        protected abstract WindowsVersion CheckVersion(string userAgent);
        protected abstract WindowsVersionCheck GetNextVersion();

        public virtual string CheckOs(string userAgent)
        {
            var version = CheckVersion(userAgent);
            if (version != WindowsVersion.NoMatch)
            {
                var netCheck = new Net4_5Check();
                return netCheck.CheckDotNet(userAgent, version);
            }
            else
            {
                var next = GetNextVersion();
                return next.CheckOs(userAgent);
            }
        }
    }

    public class Net4_5Check : DotNetVersionCheck
    {
        protected override bool SupportsWindows(WindowsVersion version)
        {
            switch (version)
            {
                case WindowsVersion.Windows8:
                case WindowsVersion.Windows7:
                case WindowsVersion.WindowsVista:
                    return true;
                default:
                    return false;
            }
        }

        protected override string GetSupportedMessage(string userAgent)
        {
            return string.Empty;
        }

        protected override DotNetVersionCheck GetNextVersion()
        {
            return new Net4Check();
        }
    }

    public class Net4Check : DotNetVersionCheck
    {
    }

    public class Net3Check : DotNetVersionCheck
    {
    }

    public class Net2Check : DotNetVersionCheck
    {
    }

    public class Net1_1Check : DotNetVersionCheck
    {
    }

    public class Net1Check : DotNetVersionCheck
    {
    }

    public class NullDotNetVersion : DotNetVersionCheck
    {
    }

    public abstract class DotNetVersionCheck
    {
        protected abstract bool SupportsWindows(WindowsVersion version);
        protected abstract string GetSupportedMessage(string userAgent);
        protected abstract DotNetVersionCheck GetNextVersion();

        public string CheckDotNet(string userAgent, WindowsVersion version)
        {
            if (SupportsWindows(version))
            {
                return GetSupportedMessage(userAgent) +
                    NextVersionMessage(userAgent, version);
            }
            else
            {
                return NextVersionMessage(userAgent, version);
            }
        }

        private string NextVersionMessage(string userAgent, WindowsVersion version)
        {
            return GetNextVersion().CheckDotNet(userAgent, version);
        }
    }

    public enum WindowsVersion
    {
        Windows8,
        Windows7,
        WindowsVista,
        WindowsXp,
        Windows2000,
        NoMatch
    }
}
