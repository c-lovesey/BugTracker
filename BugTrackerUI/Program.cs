using System.Data.Entity;

namespace BugTrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //initialize database connections
            BugTrackerLibrary.GlobalConfig.InitializeConnections(true,true);

            Application.Run(new BugReportForm());
            //Application.Run(new BugViewerForm());

        }
    }
}