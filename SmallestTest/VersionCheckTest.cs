using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Drawing;
using SmallestDotNetLib;

namespace SmallestTest
{
    [TestClass]
    public class VersionCheckTest
    {
        private static List<string> CLRVersionStrings()
        {
            return new List<string> 
            {
                ".NET4.0E"
                , ".NET4.0C"
                , ".NET CLR 3.5.30729"
                , ".NET Client 3.5"
                , ".NET CLR 3.5.21022"
                , ".NET CLR 2.0"
                , ".NET CLR 1.1"
                , ".NET CLR 1.0"
            };
        }
        
    }
}
