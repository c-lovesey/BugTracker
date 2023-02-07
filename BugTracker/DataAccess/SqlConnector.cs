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
        //TODO - Make the other creation methods for each model
        // TODO - Make the CreateBugReport method save to the database
        /// <summary>
        /// Saves a new Bug Report to the database
        /// </summary>
        /// <param name="model">Report Information</param>
        /// <returns>The report info, including the unique id</returns>
        /// 

        public ApplicationModel CreateApplication(ApplicationModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("BugTracker")))
            {
                var p = new DynamicParameters();
                p.Add("@ApplicationName", model.ApplicationName);
                p.Add("@ApplicationLetterID", model.ApplicationName);
                int applicationId = connection.QueryFirst<int>("dbo.spApplication_Insert", p, commandType: CommandType.StoredProcedure);
                model.ApplicationId = applicationId;
                return model;
            }
        }
        public VersionModel CreateVersion (VersionModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("BugTracker")))
            {
                var p = new DynamicParameters();
                p.Add("@VersionName", model.VersionName);
                //TODO: Find a way to get the application ID using the name of the application
                //p.Add("@ApplicationID", model.Application);
                int versionId = connection.QueryFirst<int>("dbo.spVersion_Insert", p, commandType: CommandType.StoredProcedure);
                model.VersionId = versionId;
                return model;
            }
        }
        public EnvironmentModel CreateEnvironment(EnvironmentModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("BugTracker")))
            {
                var p = new DynamicParameters();
                p.Add("@EnvironmentName", model.EnvironmentName);
                int environmentId = connection.QueryFirst<int>("dbo.spEnvironment_Insert", p, commandType: CommandType.StoredProcedure);
                model.EnvironmentId = environmentId;
                return model;
            }
        }
        public BugModel CreateBugReport(BugModel model)
        {
            //uses IDbConnection to create a connection to the database
            //the using staement protects against memory leaks
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("BugTracker")))
            {
                //TODO Create all correct inputs for this from the form or remove some
                var p = new DynamicParameters();
                p.Add("@BugID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
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
                //p.Add("@DateModified", model.DateModified);

                //Executes the stored procedure and passes in the information using p
                connection.Execute("dbo.spBugDetails_Insert", p, commandType: CommandType.StoredProcedure);
                //gets the id from the database
                model.BugId = p.Get<int>("@BugID");


                return model;
                
                //connection.CreateBugReport(model);

            }

            //    model.BugId = 1;
            //return model;
        }
    }
}
