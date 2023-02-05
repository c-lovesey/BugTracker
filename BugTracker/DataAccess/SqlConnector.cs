using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTrackerLibrary.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace BugTrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreateBugReport method save to the database
        /// <summary>
        /// Saves a new Bug Report to the database
        /// </summary>
        /// <param name="model">Report Information</param>
        /// <returns>The report info, including the unique id</returns>
        public BugModel CreateBugReport(BugModel model)
        {
            //uses IDbConnection to create a connection to the database
            //the using staement protects against memory leaks
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("BugTracker")))
            {
                var p = new DynamicParameters();
                p.Add("@BugID", model.BugId);
                p.Add("@BugTitle", model.BugTitle);
                p.Add("@IssueType", model.IssueType);
                p.Add("@ApplicationID", model.Application);
                p.Add("@BugVersion", model.Version);
                p.Add("@BugConfirmation", model.BugConformation);
                p.Add("@BugCategory", model.BugCategory);
                p.Add("@BugStatus", model.BugStatus);
                p.Add("@BugPriority", model.BugPriority);
                p.Add("@BugResolution", model.BugResolution);
                p.Add("@BugFixedVersion", model.BugFixedVersion);
                p.Add("@BugDescription", model.BugDescription);
                p.Add("@BugReproduce", model.BugReproduce);
                p.Add("@BugObservedBehaviour", model.BugObservedBehaviour);
                p.Add("@BugExpectedBehaviour", model.BugExpextedBehaviour);
                p.Add("@AttatchmentID", model.BugAttatchment);
                p.Add("@EnvironmentID", model.BugEnvironment);
                //p.Add("@DateCreated", model.Date);
                //connection.CreateBugReport(model);
            }

            //    model.BugId = 1;
            //return model;
        }
    }
}
//@ApplicationID int = 0 output,
//	@ApplicationName varchar(50),
//	@ApplicationLetterID varchar(50),
//	@VersionID int
