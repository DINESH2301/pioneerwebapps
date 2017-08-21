using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTech
{
    public class ProjectDetailsModel
    {
        public long ProjectID { get; set; }
        public long EmployeeID { get; set; }
        public string ProjectName { get; set; }
        public string ClientName { get; set; }
        public string Location { get; set; }
        public string Role { get; set; }
    }
}
