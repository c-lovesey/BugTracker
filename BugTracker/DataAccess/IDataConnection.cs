using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTrackerLibrary.Models;
using BugTrackerLibrary.Models;

namespace BugTrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        BugModel CreateBugReport(BugModel model);
        EnvironmentModel CreateEnvironment(EnvironmentModel model);
    }
}
