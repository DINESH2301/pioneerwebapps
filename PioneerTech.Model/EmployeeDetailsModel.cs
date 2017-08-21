using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTech
{
  public class EmployeeDetailsModel
    {
    public long EmployeeID { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public long MobileNumber { get; set; }
    public long AlternateMobileNumber { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string CurrentCountry { get; set; }
    public string HomeCountry { get; set; }
    public int Zipcode { get; set; }
    }
}
