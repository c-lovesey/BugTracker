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
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace BugTrackerLibrary.DataAccess
{

    public class SqlConnector : IDataConnection
    {
        //Stores the name of the Database
        private const string db = "BugTracker";

        public ApplicationModel CreateApplication(ApplicationModel model)
        {
            //Creates connection to database
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                //Creates a new DynamicParameters object
                var p = new DynamicParameters();
                //Adds the parameters to the DynamicParameters object
                p.Add("@ApplicationName", model.ApplicationName);
                p.Add("@ApplicationLetterID", model.ApplicationLetterID);
                //Gets the ID of the newly created application
                int applicationId = connection.QueryFirst<int>("dbo.spApplication_Insert", p, commandType: CommandType.StoredProcedure);
                model.id = applicationId;
                //Closes connection
                connection.Close();
                return model;
            }
        }
        public VersionModel CreateVersion(VersionModel model, int CurrentApplication)
        {
            //Creates connection to database
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                //Creates a new DynamicParameters object
                var p = new DynamicParameters();
                //Adds the parameters to the DynamicParameters object
                p.Add("@VersionName", model.VersionName);
                p.Add("@ApplicationID", CurrentApplication);
                //Gets the ID of the newly created application
                int versionId = connection.QueryFirst<int>("dbo.spVersion_Insert", p, commandType: CommandType.StoredProcedure);
                model.id = versionId;
                //Closes connetion
                connection.Close();
                return model;
            }
        }
        public EnvironmentModel CreateEnvironment(EnvironmentModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@EnvironmentName", model.EnvironmentName);
                int environmentId = connection.QueryFirst<int>("dbo.spEnvironment_Insert", p, commandType: CommandType.StoredProcedure);
                model.id = environmentId;
                return model;
            }
        }
        public BugModel CreateBugReport(BugModel model)
        {
            //uses IDbConnection to create a connection to the database
            //the using staement protects against memory leaks
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                //TODO Create all correct inputs for this from the form or remove some
                var p = new DynamicParameters();
                p.Add("@BugDescription", model.BugDescription);
                p.Add("@EnvironmentID", model.EnvironmentID);
                p.Add("@BugPriority", model.BugPriority);
                p.Add("@BugTitle", model.BugTitle);
                p.Add("@ApplicationID", model.ApplicationID);
                p.Add("@BugLabel", model.BugLabel);
                p.Add("@BugConfirmation", model.BugConfirmation);
                p.Add("@BugCategory", model.BugCategory);
                p.Add("@BugStatus", model.BugStatus);
                p.Add("@BugResolution", model.BugResolution);
                p.Add("@BugFixedVersion", model.BugFixedVersion);
                p.Add("@BugAffectedVersion", model.BugAffectedVersions);


                int bugId = connection.QueryFirst<int>("dbo.spBugReport_Insert", p, commandType: CommandType.StoredProcedure);
                model.id = bugId;
                connection.Close();
                return model;

            }
            
                
            //    model.BugId = 1;
            //return model;
        }

        public List<BugModel> GetBugReport_All()
        {
            List<BugModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<BugModel>("dbo.spBugReport_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        public List<EnvironmentModel> GetEnvironment_All()
        {
            List<EnvironmentModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<EnvironmentModel>("dbo.spEnvironment_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        public List<ApplicationModel> GetApplication_All()
        {
            List<ApplicationModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ApplicationModel>("dbo.spApplication_GetAll").ToList();
            }
            return output;
        }

        public List<VersionModel> GetVersion_All()
        {
            List<VersionModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<VersionModel>("dbo.spVersion_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        public List<VersionModel> GetVersion_Application(int id)
        {
            //TODO Test this
            List<VersionModel> output;
            var p = new DynamicParameters();
            p.Add("@ApplicationId", id);
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<VersionModel>("dbo.spVersions_GetByApplication", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        public List<BugModel> SearchBugReport()
        {
            throw new NotImplementedException();
        }

        public List<BugModel> SearchBugReport(int? ApplicationID, string category, string status, string resolution, string title)
        {
            List<BugModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ApplicationID", ApplicationID);
                p.Add("@BugStatus", status);
                p.Add("@BugResolution", resolution);
                p.Add("@BugCategory", category);
                p.Add("@BugTitle", title);

                output = connection.Query<BugModel>("dbo.spBugReport_Search", p, commandType: CommandType.StoredProcedure).ToList();

            }
            return output;

        }

        public void Delete_Application(int id)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                connection.Execute("spApplication_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete_BugReport(int id)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                connection.Execute("spBugReport_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete_Environment(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete_Version(int id)
        {
            throw new NotImplementedException();
        }


        public EnvironmentModel GetEnvironment_ByID(int id)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("BugTracker")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@EnvironmentID", id);

                EnvironmentModel environment = connection.QuerySingleOrDefault<EnvironmentModel>("spEnvironment_GetByID", parameters, commandType: CommandType.StoredProcedure);

                return environment;
            }
        }

        public void Update_BugReport(int id, int applicationId, string commaSeparatedVersions, int environmentId, string bugStatus, string bugResolution, string bugPriority, string bugDescription, string bugTitle, string bugLabel, string bugCategory, string bugFixedVersion, string bugConfirmation, string affectedVersions)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@id", id);
                p.Add("@BugDescription", bugDescription);
                p.Add("@EnvironmentID", environmentId);
                p.Add("@BugPriority", bugPriority);
                p.Add("@BugTitle", bugTitle);
                p.Add("@ApplicationID", applicationId);
                p.Add("@BugLabel", bugLabel);
                p.Add("@BugConfirmation", bugConfirmation);
                p.Add("@BugCategory", bugCategory);
                p.Add("@BugStatus", bugStatus);
                p.Add("@BugResolution",bugResolution);
                p.Add("@BugFixedVersion", bugFixedVersion);
                p.Add("@BugAffectedVersions",affectedVersions);
                connection.Execute("dbo.spBugReport_Update", p, commandType: CommandType.StoredProcedure);
            }
            return;
        }
    }
}

