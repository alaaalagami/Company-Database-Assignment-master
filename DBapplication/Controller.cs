using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager 
                                 // (Initially NULL; NO DBManager Object is created yet)

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }

        //checks the username/password and returns the priviledges associated with this user
        //Returns 0 in case of error
        public int CheckPassword_Basic(string username, string password)
        {
            string q = "SELECT Priv FROM USERS_BASIC WHERE username = '" + username + "' AND password = '" + password + "';";
            object priv = dbMan.ExecuteScalar(q);
            if (priv == null) return 0;
            else return (int)priv;
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable SelectAllEmp()
        {
            string q = "SELECT * FROM Employee";
            return dbMan.ExecuteReader(q);
        }


        public int InsertProject(string Pname, int pnumber, string Plocation, int Dnum)
        {
            string query = "INSERT INTO Project (Pname, Pnumber, Plocation, Dnum)" +
                            "Values ('" + Pname + "'," + pnumber + ",'" + Plocation + "'," + Dnum + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectDepNum()
        {
            string q = "SELECT Dnumber FROM Department;";
            return dbMan.ExecuteReader(q);
        }

        public DataTable SelectDepNum_and_Name()
        {
            string q = "SELECT Dnumber, Dname FROM Department;";
            return dbMan.ExecuteReader(q);
        }

        public DataTable SelectDepartments()
        {
            string q = "SELECT * FROM Department;";
            return dbMan.ExecuteReader(q);
        }

        public DataTable SelectDepLoc()
        {
            string q = "SELECT Dlocation FROM Dept_Locations;";
            return dbMan.ExecuteReader(q);
        }

        public DataTable SelectProject(string loc)
        {
            string q = "SELECT Pname, Dname FROM Project P, Department D, Dept_Locations L"
                + " WHERE D.Dnumber = L.Dnumber AND P.Dnum = D.Dnumber AND  Dlocation ='" + loc + "';";
            return dbMan.ExecuteReader(q);
        }

        public DataTable SelectEmployeeNames()
        {
            string q = "SELECT SSN, Fname+' '+Minit+'. '+Lname AS Name FROM Employee;";
            return dbMan.ExecuteReader(q);
         }

        public DataTable SelectEmployeeNamesBySearch(string name, string sex, bool? isManager, List<int> departments)
        {
            string q = "SELECT SSN, Fname+' '+Minit+'. '+Lname AS Name FROM Employee"
               + " WHERE (Fname+' '+Minit+'. '+Lname) LIKE '" + name + "'";
            if (sex != "")
                q += " AND Sex ='" + sex + "'";
            if (isManager != null)
                q += " AND SSN " + (isManager.GetValueOrDefault() ? "" : "NOT ") + "IN (SELECT Mgr_SSN FROM Department)";
            if (departments.Count > 0)
                q += " AND Dno IN (" + String.Join(",", departments)+");";
            return dbMan.ExecuteReader(q);
        }

        public DataTable SelectEmployeeBySSN(int ssn)
        {
            string q = "SELECT * FROM Employee WHERE SSN = " + ssn;
            return dbMan.ExecuteReader(q);
        }

        public int UpdateEmployee(int ssn, string fname, char minit, string lname, DateTime bdate, String address, String sex, int salary, int dno, int? super_ssn)
        {
            string q = "UPDATE Employee SET Fname = '" + fname + "', Minit = '" + minit + "', Lname = '" + lname +"', Bdate = '" + bdate 
                + "', Address = '" + address + "', Salary = '" + salary + "', Dno = '" + dno + "'";
            if (sex != "") q += ", Sex = '" + sex + "'";
            if (super_ssn != null) q += ", Super_SSN = '" + super_ssn + "'";
            q += " WHERE SSN = '" + ssn + "';";
            return dbMan.ExecuteNonQuery(q);
        }

        public int InsertEmployee(int ssn, string fname, char minit, string lname, DateTime bdate, String address, String sex, int salary, int dno, int? super_ssn)
        {
            string q = "INSERT INTO Employee Values ('" + fname + "', '" + minit + "', '" + lname + "', '" + ssn + "', '" + bdate + "', '" + address + "', '" + sex
                + "', '" + salary + "', " + (super_ssn == null ? "NULL" : ("'"+super_ssn.ToString()+"'")) + ", '" + dno + "');";
            return dbMan.ExecuteNonQuery(q);
        }

        public int DeleteEmployee(int ssn)
        {
            string q = "DELETE FROM Employee WHERE SSN = '" + ssn + "';";
            return dbMan.ExecuteNonQuery(q);
        }

        public DataTable SelectProjectsEmployeeWorksOn(int ssn)
        {
            string q = "SELECT Pname FROM Project, Works_On WHERE Pno = Pnumber AND ESSN = '" + ssn + "';";
            return dbMan.ExecuteReader(q);
        }

        //////////////////////////////////////////////////////// OUR FUNCTIONS ///////////////////////////////////////////////////////////////////////
        public DataTable SelectProjects()
        {
            string q = "SELECT Pname, Pnumber, Plocation, Dname FROM Project, Department WHERE Dnum = Dnumber;";
            return dbMan.ExecuteReader(q);
        }

        public DataTable SelectDepartmentsMgr()
        {
            string q = "SELECT Dname, Dnumber, Mgr_Start_Date, Fname+' '+Minit+'. '+Lname AS ManagerName FROM Employee, Department WHERE Mgr_SSN = SSN;";
            return dbMan.ExecuteReader(q);
        }

        public DataTable SelectEmployees()
        {
            string q = "SELECT Fname+' '+Minit+'. '+Lname AS Name, SSN FROM Employee;";
            return dbMan.ExecuteReader(q);
        }

        public int InsertDepartment(string dname, int dnum, int mgrssn, DateTime mgrstartdate)
        {
            string q = "INSERT INTO Department Values('" + dname + "', '" + dnum + "', '" + mgrssn + "', '" + mgrstartdate + "');";
            return dbMan.ExecuteNonQuery(q);
        }

        public DataTable SelectAllProjects()
        {
            string q = "SELECT Pname, Pnumber FROM Project;";
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetCountHoursProject(int Pno)
        {
            string q = "SELECT Count(*) AS EmpCount, Sum(Hours) AS TotHrs FROM Works_On WHERE Pno = " + Pno + ";";
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetCountDepartment(int Dno)
        {
            string q = "SELECT Count(*) AS EmpCount FROM Employee, Department WHERE Dnumber = Dno AND Dnumber = " + Dno + ";";
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetProjectsDepartment(int Dno)
        {
            string q = "SELECT Pname FROM Project WHERE Dnum = " + Dno + ";";
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetAllStats()
        {
            string q = "Select Count(*), Avg(Salary), Min(Salary), Max(Salary) From Employee;"; 
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetFStats()
        {
            string q = "Select Count(*), Avg(Salary), Min(Salary), Max(Salary) From Employee Where Sex = 'F';";
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetMStats()
        {
            string q = "Select Count(*), Avg(Salary), Min(Salary), Max(Salary) From Employee Where Sex = 'M';";
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetManagersCount()
        {
            string q = "Select Count(DISTINCT Mgr_SSN) From Department"; 
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetSupervisorsCount()
        {
            string q = "Select Count(DISTINCT Super_SSN) From Employee";
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetOthersCount()
        {
            string q = "Select Count(*) From Employee Where SSN NOT IN (Select Mgr_SSN From Department Union Select Super_SSN from Employee Where Super_SSN IS NOT NULL)";
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetSeniorsCount()
        {
            string q = "Select Count(*) From Employee Where DateAdd(yy, 50, Bdate) < GETDATE()";
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetProjectsCount()
        {
            string q = "Select Count(*) From Project";
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetDepartmentsCount()
        {
            string q = "Select Count(*) From Department";
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetEmployeeOfSalary(int salary, int index)
        {
            string q = "";

            if (index == 0)
                q = "Select Fname+' ' + Minit + '. ' + Lname AS Name From Employee Where Salary = " + salary;
            else if (index == 1)
                q = "Select Fname+' ' + Minit + '. ' + Lname AS Name From Employee Where Salary <> " + salary;
            else if (index == 2)
                q = "Select Fname+' ' + Minit + '. ' + Lname AS Name From Employee Where Salary < " + salary;
            else if (index == 3)
                q = "Select Fname+' ' + Minit + '. ' + Lname AS Name From Employee Where Salary > " + salary;

            return dbMan.ExecuteReader(q);
        }

        public DataTable SelectProjectByNum(int Pno)
        {
            string q = "SELECT Plocation, Dnum FROM Project WHERE Pnumber = " + Pno + ";";
            return dbMan.ExecuteReader(q);
        }

        public int UpdateProject(string pname, int pnumber, string plocation, int dnum)
        {
            string q = "UPDATE Project SET Pnumber = '" + pnumber + "', Plocation = '" + plocation + "', Dnum = '" + dnum + "' WHERE Pname = '" + pname + "';";
            return dbMan.ExecuteNonQuery(q);
        }

        public DataTable SelectDepartmentByNum(int Dno)
        {
            string q = "SELECT Mgr_SSN, Mgr_Start_Date FROM Department WHERE Dnumber = " + Dno + ";";
            return dbMan.ExecuteReader(q);
        }
        public int UpdateDepartment(string dname, int dnumber, int managerssn, DateTime mgrstartdate)
        {
            string q = "UPDATE Department SET Dnumber = '" + dnumber + "', Mgr_SSN = '" + managerssn + "', Mgr_Start_Date = '" + mgrstartdate + "' WHERE Dname = '" + dname + "';";
            return dbMan.ExecuteNonQuery(q);
        }
    }


}
