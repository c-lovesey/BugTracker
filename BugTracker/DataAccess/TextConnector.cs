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

        // TODO: - Make the CreateBugReport method save to text file
        /// <summary>
        /// Saves a new Bug Report to a text file
        /// </summary>
        /// <param name="model">Report Information</param>
        /// <returns>The report info, including the unique id</returns>
        public BugModel CreateBugReport(BugModel model)
        {
            model.BugId = 1;
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
