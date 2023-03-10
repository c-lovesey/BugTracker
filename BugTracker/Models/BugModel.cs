using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary.Models
{
    public class BugModel
    {
        //model for a bug report
        public int id { get; set; }
        public int ApplicationID { get; set; }
        public string BugAffectedVersions { get; set; }
        public string BugStatus { get; set; }
        public string BugResolution { get; set; }
        public int EnvironmentID { get; set; }
        public string BugPriority { get; set; }
        public string BugDescription { get; set; }
        public string BugTitle { get; set; }
        public string BugLabel { get; set; }
        public string BugCategory { get; set; }
        public string BugFixedVersion { get; set; }
        public string BugConfirmation { get; set; }


        //public int BugId { get; set; }//Id for bug report
        //public string BugTitle { get; set; }//name of repoprt
        //public string IssueType { get; set; }//the type of issue exploit/vulnerability
        //public string Application { get; set; }//what applications the bug occurs in
        //public string Version { get; set; }//what versions it takes place in
        //public string BugConfirmation { get; set; }//is the bug confirmed/reproducable
        //public string BugCategory { get; set; }//what is causing the bug maths/code error
        //public bool BugStatus { get; set; }//is the bug still around/causing errors
        //public string BugPriority { get; set; }//what is the priority of the bug
        //public string BugResolution { get; set; }//is the bug resolved
        //public string BugFixedVersion { get; set; }//in which version is it fixed
        //public string BugDescription { get; set; }//description of the bug
        //public string BugReproduce { get; set; }//steps to reproduce the bug
        //public string BugObservedBehaviour { get; set; }//what the bug does
        //public string BugExpextedBehaviour { get; set; }//what should happen instead
        //public string BugAttatchment { get; set; }//pictures about the bug
        //public string BugEnvironment { get; set; }//what environment does it take place windows10/11 linux

        public BugModel()
        {

        }
        public BugModel(
            int applicationID,
            string bugAffectedVersions,
            int environmentID,
            string bugStatus,
            string bugResolution,
            string bugPriority,
            string bugDescription,
            string bugTitle,
            string bugLabel,
            string bugCategory,
            string bugFixedVersion,
            string bugConfirmation
            )
        {
            ApplicationID = applicationID;
            BugAffectedVersions = bugAffectedVersions;
            EnvironmentID = environmentID;
            BugStatus = bugStatus;
            BugResolution = bugResolution;
            BugPriority = bugPriority;
            BugDescription = bugDescription;
            BugTitle = bugTitle;
            BugLabel = bugLabel;
            BugCategory = bugCategory;
            BugFixedVersion = bugFixedVersion;
            BugConfirmation = bugConfirmation;

        }
    }
}
