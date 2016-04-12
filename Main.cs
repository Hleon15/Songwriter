using System.Collections.Generic;
using UIKit;

namespace Songwriter3
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{

            Xamarin.Insights.Initialize ("651640899460c6bff8330659e66a127e622f9f4f");
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.

            var manyInfos = new Dictionary<string, string> {
    {"Email", "john.doe@company.com"} ,
    {"Name", "Jesse Dietrichson"}
            };
Xamarin.Insights.Identify ("JesseTestID", manyInfos);


			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}
