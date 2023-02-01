using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary
{
    public class TextConnection : IDataConnection
    {

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
    }
}
