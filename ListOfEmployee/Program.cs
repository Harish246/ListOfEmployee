using ListOfEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployee
{
    internal class Employee
    {

        public int empId { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public int empSalary { get; set; }
        public string empMail { get; set; }
        public long empAadhar { get; set; }
        public string empJoiningDate { get; set; }
        public string empHireDate { get; set; }
        public string empLpa { get; set; }
        public string empcity { get; set; }


    }


    internal class Program
    {
        static void Main(string[] args)
        {

        Employee objemp = new Employee();
        objemp.empId = 114;
        objemp.empName = "chandhu";
        objemp.empDesignation = "saleExe";
        objemp.empSalary = 64000;
        objemp.empMail = "hell@mail.com";
        objemp.empAadhar = 12232333;
        objemp.empJoiningDate = "05/05/2010";
        objemp.empHireDate = "27/04/2010";
        objemp.empLpa = "5.4lpa";
        objemp.empcity = "velluru";



        Employee objemp1 = new Employee();
        objemp1.empId = 112;
        objemp1.empName = "chandini";
        objemp1.empDesignation = "hr";
        objemp1.empSalary = 44000;
        objemp1.empMail = "hell0@mail.com";
        objemp1.empAadhar = 132333;
        objemp1.empJoiningDate = "05/06/2011";
        objemp1.empHireDate = "27/05/2011";
        objemp1.empLpa = "3.7lpa";
        objemp1.empcity = "alluru";

        Employee objemp2 = new Employee();
         objemp2.empId = 113;
         objemp2.empName = "nadhu";
         objemp2.empDesignation = "admin";
         objemp2.empSalary = 34000;
         objemp2.empMail = "hell0h@mail.com";
         objemp2.empAadhar = 1222333;
         objemp2.empJoiningDate = "05/07/2010";
         objemp2.empHireDate = "27/06/2010";
         objemp2.empLpa = "2.8lpa";
         objemp2.empcity = "ravlooru";

        Employee objemp3 = new Employee();
        objemp3.empId = 115;
        objemp3.empName = "nandhini";
        objemp3.empDesignation = "manager";
        objemp3.empSalary = 84000;
        objemp3.empMail = "helloha@mail.com";
        objemp3.empAadhar = 12233;
        objemp3.empJoiningDate = "05/04/2010";
        objemp3.empHireDate = "27/03/2010";
        objemp3.empLpa = "7lpa";
        objemp3.empcity = "saluroo";

        Employee objemp4 = new Employee();
        objemp4.empId = 116;
        objemp4.empName = "hari";
        objemp4.empDesignation = "assistant manager";
        objemp4.empSalary = 74000;
        objemp4.empMail = "hellohar@mail.com";
        objemp4.empAadhar = 1224433;
        objemp4.empJoiningDate = "08/05/2010";
        objemp4.empHireDate = "30/04/2010";
        objemp4.empLpa = "6.2lpa";
        objemp4.empcity = "monaguruu";


        List<Employee> list = new List<Employee>();
        list.Add(objemp);
        list.Add(objemp1);
        list.Add(objemp2);
        list.Add(objemp3);
        list.Add(objemp4);

            Dictionary<int, Employee> keyValuePairs = new Dictionary<int, Employee>();
            keyValuePairs.Add(121, objemp);
            keyValuePairs.Add(142, objemp1);
            keyValuePairs.Add(123, objemp2);
            keyValuePairs.Add(133, objemp3);
            keyValuePairs.Add(155, objemp4);


        foreach(var details in list) 
            {
                Console.WriteLine("Employee Id is : {0}, Employee Name is : {1}, Employee Designation is : {2}, Employee Salary is : {3},Employee mail is : {4},Employee Aadhar is : {5},Employee joinDate is : {6},Employee hireDate is : {7} ,Employee LPA is : {8},Employee City is : {9}", details.empId, details.empName, details.empDesignation, details.empSalary, details.empMail, details.empJoiningDate, details.empHireDate, details.empAadhar, details.empLpa,details.empcity);
            }

            foreach (KeyValuePair<int, Employee> item in keyValuePairs)
            {
                Employee work = item.Value;
                Console.WriteLine("Employee Id is : {0}, Employee Name is : {1}, Employee Designation is : {2}, Employee Salary is : {3},Employee mail is : {4},Employee Aadhar is : {5},Employee joinDate is : {6},Employee hireDate is : {7} ,Employee LPA is : {8},Employee City is : {9}", work.empId, work.empName, work.empDesignation, work.empSalary, work.empMail, work.empJoiningDate, work.empHireDate, work.empAadhar, work.empLpa, work.empcity);
            }
            Console.ReadLine();



        }
    }
}
