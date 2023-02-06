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
            BugTrackerLibrary.GlobalConfig.InitializeConnections(BugTrackerLibrary.DatabaseType.Sql);

            Application.Run(new AddEnvironmentForm());
            //Application.Run(new BugViewerForm());

        }
    }
}