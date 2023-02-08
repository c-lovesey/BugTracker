using BugTrackerLibrary.Models;
using BugTrackerLibrary;
using Dapper;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

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

            Application.Run(new BugReportForm());
            //Application.Run(new BugViewerForm());

            //using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            //{
            //    var p = new DynamicParameters();
            //    p.Add("@SearchString", searchString);

            //    List<BugModel> bugReports = connection.Query<BugModel>("spBugReports_Search", p, commandType: CommandType.StoredProcedure).ToList();

            //    return bugReports;
            //}
        }
    }
}