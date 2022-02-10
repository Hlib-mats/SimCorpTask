using System;

namespace SimCorpTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime agreementDate;
            DateTime calculationDate;
            double x; 
            double r;

            GetInfo(out r,out x,out calculationDate,out agreementDate);
            var investUtility = new InvestUtility(r,x,calculationDate,agreementDate);
            Console.WriteLine(investUtility.GetProfit());
        }

        static void GetInfo(out double rate,out double basePayment,out DateTime calculationDate,out DateTime agreementDate)
        {
            Console.WriteLine("Enter R(% per year)");
            double.TryParse(Console.ReadLine(),out rate);
            Console.WriteLine("Enter base payment");
            double.TryParse(Console.ReadLine(), out basePayment);
            Console.WriteLine("Enter agreement date(DD/MM/YYYY)");
            agreementDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter calculation date(DD/MM/YYYY)");
            calculationDate = Convert.ToDateTime(Console.ReadLine());
        }
    }
}
