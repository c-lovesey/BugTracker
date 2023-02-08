using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary.Models
{
    public class VersionModel
    {
        // this is the model for creating the version, this represents
        // one version which is tied to an application

        public int id { get; set; }//version id
        public string VersionName { get; set; }//version name
        public string ApplicationId { get; set; }//what application does it occur in


        public VersionModel()
        {

        }
        public VersionModel(
            string versionName,
            string application
           )
        {
            VersionName = versionName;
            ApplicationId = application;
        }
    }
}