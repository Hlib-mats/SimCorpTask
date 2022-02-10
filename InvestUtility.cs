using System;

namespace SimCorpTask
{
    class InvestUtility
    {
        private DateTime agreementDate;
        private DateTime calculationDate;
        private double x; //base payment
        private double r; //rate

        public int N
        {
            get 
            { 
                return CalculationDate.Year - AgreementDate.Year; 
            }
        }

        public double R
        {
            get { return r; }
            set { r = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public DateTime CalculationDate
        {
            get { return calculationDate; }
            set { calculationDate = value; }
        }

        public DateTime AgreementDate
        {
            get { return agreementDate; }
            set { agreementDate = value; }
        }

        public InvestUtility( double rate, double basePayment, DateTime calculationDate, DateTime agreementDate)
        {
            R = rate;
            X = basePayment;
            CalculationDate = calculationDate;
            AgreementDate = agreementDate;
        }

        public static double GetProfit(double rate, double basePayment, DateTime calculationDate, DateTime agreementDate)
        {
            double profit;
            double N = calculationDate.Year - agreementDate.Year;
            double percents = 1 + ((rate/100) / 12);
            profit = Math.Pow(percents, 12 * N);
            profit = profit * basePayment;
            return profit;
        }

        public double GetProfit()
        {
            return GetProfit(R, X, CalculationDate, AgreementDate);
        }
    }
}
