using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spleet
{
    public abstract class FullTimeEmployee
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int AnnualSalary { get; set; }
        public abstract string GetFullName(string firstName, string lastName);
        
        
        public int GetMonthlySalary() { return AnnualSalary / 12; }


    }
    public class PartTimeEmployee : FullTimeEmployee
    {

        public int hourlyPay { get; set; }
        public int totalHours { get; set; }

        public override string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
                    }

        public  string GetFullName(string firstName, string lastName,string middleName)
        {
            return firstName + " " + lastName;
        }


        public int payment { get; set; }
        public int GetPayment() { return totalHours * hourlyPay; }
    }
}
  
