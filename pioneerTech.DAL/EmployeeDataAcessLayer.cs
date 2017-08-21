using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PioneerTech;
using System.Web.Services.Description;


namespace pioneerdataaccess
{
    public class EmployeeDataAcessLayer

    {


        public string SaveEmployee(EmployeeDetailsModel emp)
        {
            int result = 0;
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                        "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "INSERT INTO EMPLOYEEDETAILS(firstname,lastname,EmailId,mobilenumber,alternatemobilenumber,Address1,Address2,currentcountry,Homecountry,zipcode)VALUES('" + emp.Firstname + "'," + "'" + emp.Lastname + "'," + "'" + emp.Email + "'," + "" + emp.MobileNumber + "," + "" + emp.AlternateMobileNumber + "," + "'" + emp.Address1 + "'," + "'" + emp.Address2 + "'," + "'" + emp.CurrentCountry + "'," + "'" + emp.HomeCountry + "'," + "" + emp.Zipcode + ")";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                result= cmd.ExecuteNonQuery();
                if(result>0)
                {
                    return "Success";
                }
                mysqlconnection.Close();
                return "Failed";
            }
            catch (Exception ex)

            {
                return "Error Has been occurred, Please contact Administrator:" + ex.Message;
            }
        
        }

        public string EditEmployee(EmployeeDetailsModel emp)
        {
            int result = 0;
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                        "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "UPDATE EMPLOYEEDETAILS SET FirstName='"+emp.Firstname+"',LastName='"+emp.Lastname+"',EmailId='" + emp.Email + "',MobileNumber=" + emp.MobileNumber + ",AlternateMobileNumber=" + emp.AlternateMobileNumber + ",Address1='" + emp.Address1 + "',Address2='" + emp.Address2 + "',CurrentCountry='" + emp.HomeCountry + "',Zipcode=" + emp.Zipcode + " WHERE EmployeeID=" + emp.EmployeeID;
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                result=cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    return "Success";
                }
                mysqlconnection.Close();
                return "Failed";
            }
            catch (Exception ex)

            {
                return "Error Has been occurred, Please contact Administrator:" + ex.Message;
            }
        }
            
    }
    
    public class CompanyDataAccessLayer
    {
        public string SaveCompany(CompanyDetailsModel com)
        {
            int result = 0;
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "INSERT INTO COMPANY_DETAILS(EmployeeID,Employeename,contactnumber,Location,Website)VALUES(" + com.EmployeeID + "," + "'" + com.Employeename + "'," + com.Contactnumber + "," + "'" + com.Location + "'," + "'" + com.Website + "')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
               result= cmd.ExecuteNonQuery();
            
            if (result > 0)
            {
                return "Success";
            }
            mysqlconnection.Close();
            return "Failed";
            }
            catch (Exception ex)

            {
                return "Error Has been occurred, Please contact Administrator:" + ex.Message;
            }

        }
    public string EditCompany(CompanyDetailsModel com)
        {
            int result = 0;
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "UPDATE COMPANY_DETAILS SET Employeename='" + com.Employeename + "',contactnumber=" + com.Contactnumber + ",Location='" + com.Location + "',website='" + com.Website + "' WHERE EmployeeID=" + com.EmployeeID;
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                result=cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    return "Success";
                }
                mysqlconnection.Close();
                return "Failed";
            }
            catch (Exception ex)

            {
                return "Error Has been occurred, Please contact Administrator:" + ex.Message;
            }
        }
    }

    public class ProjectDataAccessLayer
    {
        public string SaveProject(ProjectDetailsModel pro)
        {
            int result = 0;
            try
            {

                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "INSERT INTO PROJECTDETAILS(ProjectID,EmployeeID,ProjectName,ClientName,Location,Role)VALUES(" + pro.ProjectID + "," + "" + pro.EmployeeID + "," + "'" + pro.ProjectName + "'," + "'" + pro.ClientName + "'," + "'" + pro.Location + "'," + "'" + pro.Role + "')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
               result=cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    return "Success";
                }
                mysqlconnection.Close();
                return "Failed";
            }
            catch (Exception ex)
            {
                return "Error Has been occurred, Please contact Administrator:" + ex.Message;
            }
        }
        public string EditProject(ProjectDetailsModel pro)
        {
            int result = 0;
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "UPDATE PROJECTDETAILS SET Projectname='" + pro.ProjectName + "',clientname='" + pro.ClientName + "',location='" + pro.Location + "',role='" + pro.Role + "' WHERE EmployeeID =" + pro.EmployeeID;
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                result=cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    return "Success";
                }
                mysqlconnection.Close();
                return "Failed";
            }
            catch (Exception ex)
            {
                return "Error Has been occurred, Please contact Administrator:" + ex.Message;
            }

        }
    }
    public class TechnicalDataAccessLayer
    {
        public void SaveTechnical(TechnicalDetailsModel tech)
        {
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open(); string COMMAND = "INSERT INTO TECHNICALDETAILS(EmployeeID,UI,ProgrammingLanguages,ORMTechnologies,Databases)VALUES(" + tech.EmployeeID + "," + "'" + tech.UI + "'," + "'" + tech.ProgrammingLanguages + "'," + "'" + tech.ORMTechnologies + "'," + "'" + tech.Databases + "')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            finally
            {

            }
        }
        public void EditTechnical(TechnicalDetailsModel tech)
        {
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "UPDATE TECHNICALDETAILS SET UI='" + tech.UI + "',programminglanguages='" + tech.ProgrammingLanguages + "',ormtechnologies='" + tech.ORMTechnologies + "',databases='" + tech.Databases + "' WHERE EmployeeID = " + tech.EmployeeID;
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            finally
            {

            }
        }
    }
    
    public class EducationalDataAccessLayer
    {
        public void SaveEducational(EducationDetailsModel edu)
        {
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open(); string COMMAND = "INSERT INTO EDUCATIONDETAILS(EmployeeID,coursetype,Yearofpass,Coursespecialization)VALUES(" + edu.EmployeeID + "," + "'" + edu.Coursetype + "'," + "" + edu.Yearofpass + "," + "'" + edu.CourseSpecialization + "')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            finally
            {
            }
        }
        public void EditEducational(EducationDetailsModel edu)
        {
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "UPDATE EDUCATIONDETAILS SET coursetype='" + edu.Coursetype + "',Yearofpass=" + edu.Yearofpass + ",coursespecialization='" + edu.CourseSpecialization + "' WHERE EmployeeID=" + edu.EmployeeID;
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            finally
            {

            }



        }
    }
}





