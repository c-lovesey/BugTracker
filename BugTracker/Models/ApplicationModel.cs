using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary.Models
{
    public class ApplicationModel
    {
        // this is the representation for applications,
        // has a list of versions associated with the application
        public int ApplicationId { get; set; }//Id for the application
        public string ApplicationName { get; set; }//name of the application
        public List<VersionModel> Version { get; set; }//versions associated with the application

    }
}
