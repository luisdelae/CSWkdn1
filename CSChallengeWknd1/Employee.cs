using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSChallengeWknd1
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return EmpID + "\t\t" + FirstName + "\t\t" + LastName + "\t\t" + Title + "\t\t" + Salary;
        }
    }
}
