using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary.Models
{
    public class EnvironmentModel
    {
        public int EnvironmentId { get; set; }
        public string EnvironmentName { get; set; }

        public EnvironmentModel()
        {

        }
        public EnvironmentModel(
            string EnvironmentName
           )
        {
            EnvironmentName = EnvironmentName;
        }
    }
}
