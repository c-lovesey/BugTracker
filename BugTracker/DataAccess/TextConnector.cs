using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTrackerLibrary.Models;
using BugTrackerLibrary.DataAccess.TextHelpers;

namespace BugTrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {

        private const string BugReportFile = "BugReportFile.csv";
        private const string EnvironmentFile = "EnvironmentFile.csv";
        private const string VersionFile = "VersionFile.csv";
        private const string ApplicationFile = "ApplicationFile.csv";

        // TODO: - Make the CreateBugReport method save to text file
        /// <summary>
        /// Saves a new Bug Report to a text file
        /// </summary>
        /// <param name="model">Report Information</param>
        /// <returns>The report info, including the unique id</returns>
        /// 
        public ApplicationModel CreateApplication(ApplicationModel model)
        {
            List<ApplicationModel> applications = new List<ApplicationModel>();

            int currentId = 1;

            if (applications.Count > 0)
            {
                currentId = applications.OrderByDescending(x => x.ApplicationId).First().ApplicationId + 1;
            }
            model.ApplicationId = currentId;

            applications.Add(model);
            applications.SaveToApplicationFile(ApplicationFile);
            return model;
        }

        public VersionModel CreateVersion(VersionModel model)
        {
            List<VersionModel> versions = new List<VersionModel>();

            int currentId = 1;

            if (versions.Count > 0)
            {
                currentId = versions.OrderByDescending(x => x.VersionId).First().VersionId + 1;
            }
            model.VersionId = currentId;
            
            versions.Add(model);
            versions.SaveToVersionFile(VersionFile);
            return model;


        }
        public BugModel CreateBugReport(BugModel model)
        {
            //Load the text file and convert the text to List<BugModel>
            List<BugModel> bugReports = BugReportFile.FullFilePath().LoadFile().ConvertToBugModels();

            //Find the max ID
            int currentId = 1;

            if (bugReports.Count > 0)
            {
                currentId = bugReports.OrderByDescending(x => x.BugId).First().BugId + 1;
            }
            model.BugId = currentId;

            //Add the new record with the new ID (max + 1)
            bugReports.Add(model);

            //Convert the bugReports to a list<string>
            //Save the list<string> to the text file
            bugReports.SaveToBugFile(BugReportFile);

            return model;
        }
        public EnvironmentModel CreateEnvironment(EnvironmentModel model)
        {
            //Load txt file
            //Convert txt file to List<EnvironmentModel>
            List<EnvironmentModel> environment = EnvironmentFile.FullFilePath().LoadFile().ConvertToEnvironmentModels();

            int currentId = 1;

            //Find the max id
            if (environment.Count > 0)
            {
                currentId = environment.OrderByDescending(x => x.EnvironmentId).First().EnvironmentId + 1;
            }
            //Add the new record with the new id (max + 1)
            model.EnvironmentId = currentId;

            environment.Add(model);
            //Convert the List<EnvironmentModel> to a list<string>
            //Save the list<string> to the text file
            environment.SaveToEnvironmentFile(EnvironmentFile);

            return model;
        }
    }
}
