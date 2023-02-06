using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTrackerLibrary.DataAccess;
using System.Configuration;

namespace BugTrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - setup the sql connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                // TODO - create text connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
        public static string CnnString(string name)//gets the connection string form the App.config file
        {
            if (ConfigurationManager.ConnectionStrings[name] != null)
            {
                return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }
            else
            {
                throw new InvalidOperationException($"Connection string '{name}' not found in app config file.");
            }
        }
    }
    
}
