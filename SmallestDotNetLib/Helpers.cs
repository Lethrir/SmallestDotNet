using System;
using System.Collections.Generic;
using System.Web;
using SmallestDotNetLib.WindowsVersions;

/// <summary>
/// Summary description for Helpers
/// </summary>
public class Helpers
{
    public static string GetUpdateInformation(string UserAgent, Version version)
    {
        if (UserAgent.Contains("Mac"))
        {
            return "It looks like you're running a Mac. There's no .NET Framework download from Microsoft for the Mac, but you might check out either <a href=\"http://www.microsoft.com/silverlight/resources/install.aspx\">Silverlight</a> which is a browser plugin that includes a small version of the .NET Framework. You could also check out <a href=\"http://www.go-mono.com/mono-downloads/download.html\">Mono</a>, which is an Open Source platform that can run .NET code on a Mac.";
        }

        if (UserAgent.Contains("nix"))
        {
            return "It looks like you're running a Unix machine. There's no .NET Framework download from Microsoft for Unix, but you might check out <a href=\"http://www.go-mono.com/mono-downloads/download.html\">Mono</a>, which is an Open Source platform that can run .NET code on Unix.";
        }

        if (UserAgent.Contains("fox"))
        {
            return MessageForBrowser("Firefox");
        }
        else if (UserAgent.Contains("Chrome"))
        {
            return MessageForBrowser("Chrome");
        }
        else if (UserAgent.Contains("Safari")) // Chrome also uses safari in the user agent so this check must come after
        {
            return MessageForBrowser("Safari");
        }
        else if(!UserAgent.Contains("MSIE"))
        {
            return UnknownBrowserMessage();
        }

        var windowsFactory = new WindowsVersionFactory();
        var latest = windowsFactory.GetLatestWindows();
        return latest.CheckOs(UserAgent);
    }
    
    private static string MessageForBrowser(string browser)
    {
        return String.Format(@"Looks like you're running {2}. That's totally cool, but I can't tell if you've got .NET installed from {2}. 
                  Consider visiting this site, just once, using Internet Explorer, which will tell me more about if your system has .NET on it or not. 
                  Alternatively, if you're running Windows, you can go <strong>download the 2.8 meg installer for {0}.</strong> 
                  Also, you might make sure your system is setup to get updates from {1} automatically. 
                  This will make sure your system is up to date with the latest stuff, including the latest .NET Framework.", Constants.DotNet35Online, Constants.WindowsUpdate, browser);
    }

    private static string UnknownBrowserMessage()
    {
        string explain = String.Format(Constants.WhyItIsSmall, 60);
        return String.Format(@"I can't tell if you've got .NET installed. Perhaps you don't have .NET installed or perhaps 
                  your browser isn't letting me know. Consider visiting this site using Internet Explorer, which will tell me more about if your system has .NET on it or not. Alternatively, if you're running Windows, you can go <strong>download the 2.8 meg installer for {0}.</strong> {1}
                  Also, you might make sure your system is setup to get updates from {2} automatically. 
                  This will make sure your system is up to date with the latest stuff, including the latest .NET Framework.", Constants.DotNet35Online, explain, Constants.WindowsUpdate);
    }
        
}
