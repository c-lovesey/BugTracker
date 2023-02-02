using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTrackerLibrary.Models;

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
            model.BugId = 1;
            return model;
        }
    }
}
