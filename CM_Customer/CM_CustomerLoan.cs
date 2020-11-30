using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Periodicity;

namespace CM_CustomerLoan
{
    public class CustomerLoan
    {
        private string name;
        private float borrowCapital;
        private int timeInMonth;
        private Periodicity periodicity;
        private double percentageRate;

        public CustomerLoan()
        {
            this.name = "";
            this.borrowCapital = 0.00F;
            this.timeInMonth = 1;
            this.periodicity = Periodicity.Mensuel;
            this.percentageRate = 7;
        }

        public CustomerLoan(string _name, float _borrowCapital, int _timeInMonth, Periodicity _periodicity, double _percentageRate)
        {
            this.name = _name;
            this.borrowCapital = _borrowCapital;
            this.timeInMonth = _timeInMonth;
            this.periodicity = _periodicity;
            this.percentageRate = _percentageRate;
        }

        //public string Name { get => name; set => name = value; }
        public string Name { get { return this.name; } set { this.name = value; } }
        public float BorrowCapital { get { return this.borrowCapital; } set { this.borrowCapital = value; } }
        public int TimeInMonth { get { return this.timeInMonth; } set { this.timeInMonth = value; } }
        public Periodicity Periodicity { get { return this.periodicity; } set { this.periodicity = value; } }
        public double PercentageRate { get { return this.percentageRate; } set { this.percentageRate = value; } }

        public int NumberOfRefund()
        {
            return this.timeInMonth / Convert.ToInt32(this.periodicity);
        }

        public double AmountOfEachSteps()
        {
            /*int numberOfRefund = this.NumberOfRefund();
            double rate = this.percentageRate / (12 / Convert.ToInt32(this.periodicity)) / 100; //  / 100
            return this.borrowCapital * (rate / (1 - Math.Pow(1 + rate, -numberOfRefund)));*/

            double rate = this.percentageRate / 100 / 12 * (int)this.periodicity;
            float repaymentNumber = NumberOfRefund();
            return (float)(this.borrowCapital * (rate / (1 - Math.Pow(1 + rate, -repaymentNumber))));


        }

        public override string ToString()
        {
            return "Name = " + this.name + ", borrowCapital = " + this.borrowCapital;
        }
    }
}
