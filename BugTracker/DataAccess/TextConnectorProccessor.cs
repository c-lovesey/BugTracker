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
        
    }
}
