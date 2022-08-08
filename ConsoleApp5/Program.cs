// See https://aka.ms/new-console-template for more information
namespace Spleet
{
    class Program
    {
        static void Main(string[] args) {
            PartTimeEmployee pte = new PartTimeEmployee();
            pte.ID = 205;
            pte.firstName = "Ama";
            pte.lastName = "Tasha";
            pte.AnnualSalary = 150000;
            
            Console.WriteLine(pte.GetFullName(pte.firstName,pte.lastName));
            Console.WriteLine(pte.GetMonthlySalary());

          
            pte.hourlyPay = 1000;
            pte.totalHours = 40;
            pte.payment = 40000;
            Console.WriteLine(pte.GetMonthlySalary());
          }  
        
            
    }
}
            


        
            

    



