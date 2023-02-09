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
                currentId = applications.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentId;

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
                currentId = versions.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentId;
            
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
                currentId = bugReports.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentId;

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
                currentId = environment.OrderByDescending(x => x.id).First().id + 1;
            }
            //Add the new record with the new id (max + 1)
            model.id = currentId;

            environment.Add(model);
            //Convert the List<EnvironmentModel> to a list<string>
            //Save the list<string> to the text file
            environment.SaveToEnvironmentFile(EnvironmentFile);

            return model;
        }

        public List<BugModel> GetBugReport_All()
        {
            return BugReportFile.FullFilePath().LoadFile().ConvertToBugModels();
        }

        public List<EnvironmentModel> GetEnvironment_All()
        {
            return EnvironmentFile.FullFilePath().LoadFile().ConvertToEnvironmentModels();
        }

        public List<ApplicationModel> GetApplication_All()
        {
            return ApplicationFile.FullFilePath().LoadFile().ConvertToApplicationModels();
        }

        public List<VersionModel> GetVersion_All()
        {
            return VersionFile.FullFilePath().LoadFile().ConvertToVersionModels();
        }

        public List<VersionModel> GetVersion_Application(ApplicationModel model)
        {
            //TODO - Get all versions for a specific application with text connection
            //TODO - Test this
            List<VersionModel> versions = VersionFile.FullFilePath().LoadFile().ConvertToVersionModels();
            List<VersionModel> output = new List<VersionModel>();
            foreach (VersionModel version in versions)
            {
                if (version.ApplicationId == model.ApplicationName)
                {
                    output.Add(version);
                }
            }
            return output;
        }

        public VersionModel CreateVersion(VersionModel model, int ApplicationId)
        {
            throw new NotImplementedException();
        }

        public List<VersionModel> GetVersion_Application(int id)
        {
            throw new NotImplementedException();
        }

        public List<BugModel> SearchBugReport()
        {
            throw new NotImplementedException();
        }

        public List<BugModel> SearchBugReport(int ApplicationID, string category, string status, string resolution, string title)
        {
            throw new NotImplementedException();
        }
    }
}
