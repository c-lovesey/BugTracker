using BugTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProccessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        
        public static List<EnvironmentModel> ConvertToEnvironmentModels(this List<string> lines)
        {
            List<EnvironmentModel> output = new List<EnvironmentModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                EnvironmentModel e = new EnvironmentModel();
                e.EnvironmentId = int.Parse(cols[0]);
                e.EnvironmentName = cols[1];
                output.Add(e);
            }

            return output;
            
        }
        
        public static void SaveToEnvironmentFile(this List<EnvironmentModel> models,string fileName)
        {
            List<string> lines = new List<string>();

            foreach (EnvironmentModel e in models)
            {
                lines.Add($"{e.EnvironmentId},{e.EnvironmentName}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<VersionModel> ConvertToVersionModels(this List<string> lines)
        {
            List<VersionModel> output = new List<VersionModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                VersionModel v = new VersionModel();
                v.VersionId = int.Parse(cols[0]);
                v.VersionName = cols[1];
                v.Application = cols[2];
                output.Add(v);
            }

            return output;
        }

        public static void SaveToVersionFile(this List<VersionModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (VersionModel v in models)
            {
                lines.Add($"{v.VersionId},{v.VersionName},{v.Application}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<ApplicationModel> ConvertToApplicationModels(this List<string> lines)
        {
            List<ApplicationModel> output = new List<ApplicationModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                ApplicationModel a = new ApplicationModel();
                a.ApplicationId = int.Parse(cols[0]);
                a.ApplicationName = cols[1];
                a.ApplicationLetterID = cols[2];
                output.Add(a);
            }

            return output;
        }

        public static void SaveToApplicationFile(this List<ApplicationModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (ApplicationModel a in models)
            {
                lines.Add($"{a.ApplicationId},{a.ApplicationName},{a.ApplicationLetterID}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<BugModel> ConvertToBugModels(this List<string> lines)
        {
            List<BugModel> output = new List<BugModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                BugModel b = new BugModel();
                b.BugId = int.Parse(cols[0]);
                //b.BugName = cols[1];
               // b.BugLetterID = cols[2];
                b.BugDescription = cols[3];
                //b.BugStatus = cols[4];
                b.BugPriority = cols[5];
                //b.BugSeverity = cols[6];
                b.BugEnvironment = cols[7];
                //b.BugVersion = cols[8];
                //b.BugApplication = cols[9];
               //b.BugDate = DateTime.Parse(cols[10]);
               // b.BugReporter = cols[11];
               // b.BugAssignee = cols[12];
               //b.BugComments = cols[13];
                output.Add(b);
            }

            return output;
        }

        public static void SaveToBugFile(this List<BugModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (BugModel b in models)
            {
                //lines.Add($"{b.BugId},{b.BugName},{b.BugLetterID},{b.BugDescription},{b.BugStatus},{b.BugPriority},{b.BugSeverity},{b.BugEnvironment},{b.BugVersion},{b.BugApplication},{b.BugDate},{b.BugReporter},{b.BugAssignee},{b.BugComments}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
