using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NLog;

namespace PlantITTestingNewZealand.Utilities
{

        public class ExtentManager
        {
            private static readonly Lazy<ExtentReports> _lazy = new Lazy<ExtentReports>(() => new ExtentReports());

            public static ExtentReports Instance { get { return _lazy.Value; } }

            public static NLog.Logger logger;

            /// <summary>
            /// Constructor of ExtentTest Manager
            ///     - Creates ExtentHTMLReporter
            ///     - Add System Info to the Report
            /// </summary>
            static ExtentManager()
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

                logger = LogManager.GetCurrentClassLogger();
                OperatingSystem os = Environment.OSVersion;
                PlatformID pid = os.Platform;
                var htmlReporter    = new ExtentHtmlReporter(projectDirectory + "\\WebHTMLLogs\\index.html");
                switch (pid) {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    htmlReporter = new ExtentHtmlReporter(projectDirectory + "\\WebHTMLLogs\\index.html");
                    break;
                case PlatformID.MacOSX:
                    htmlReporter = new ExtentHtmlReporter(projectDirectory + "/WebHTMLLogs/index.html");
                    break;
                default:
                    htmlReporter = new ExtentHtmlReporter(projectDirectory + "/WebHTMLLogs/index.html");
                    Console.WriteLine("No Idea what I'm on!");
                    break;
                }

                 logger.Info(projectDirectory);


                htmlReporter.Config.Theme = Theme.Dark;
                htmlReporter.Config.ReportName = "This is a report";
                htmlReporter.Config.DocumentTitle = "This is a document";

                Instance.AttachReporter(htmlReporter);
                Instance.AddSystemInfo("Environment", "QA");
                Instance.AddSystemInfo("Host", "Localhost");
                Instance.AddSystemInfo("User", "Allan");

            }

            private ExtentManager()
            {
            }
        }
 
}

