using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTrackerLibrary.Models;
using BugTrackerLibrary.Models;
using static System.Net.Mime.MediaTypeNames;

namespace BugTrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        BugModel CreateBugReport(BugModel model);
        EnvironmentModel CreateEnvironment(EnvironmentModel model);
        ApplicationModel CreateApplication(ApplicationModel model);
        VersionModel CreateVersion(VersionModel model, int ApplicationId);
        List<BugModel> GetBugReport_All();
        List<EnvironmentModel> GetEnvironment_All();
        List<ApplicationModel> GetApplication_All();
        List<VersionModel> GetVersion_All();
        List<VersionModel> GetVersion_Application(int id);
        List<BugModel> SearchBugReport(int? ApplicationID, string category, string status, string resolution, string title);
        void Delete_Application(int id);
        void Delete_BugReport(int id);
    }
}
