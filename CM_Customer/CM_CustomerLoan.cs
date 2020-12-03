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

        /// <summary>
        /// Init Customer loan with default informations
        /// </summary>
        public CustomerLoan()
        {
            this.name = "";
            this.borrowCapital = 0.00F;
            this.timeInMonth = 1;
            this.periodicity = Periodicity.Mensuel;
            this.percentageRate = 7;
        }

        /// <summary>
        /// Init Customer loan with advanced informations
        /// </summary>
        /// <param name="_name"></param>
        /// <param borrowCapital="_borrowCapital"></param>
        /// <param timeInMonth="_timeInMonth"></param>
        /// <param periodicity="_periodicity"></param>
        /// <param percentageRate="_percentageRate"></param>
        public CustomerLoan(string _name, float _borrowCapital, int _timeInMonth, Periodicity _periodicity, double _percentageRate)
        {
            this.name = _name;
            this.borrowCapital = _borrowCapital;
            this.timeInMonth = _timeInMonth;
            this.periodicity = _periodicity;
            this.percentageRate = _percentageRate;
        }

        /// <summary>
        /// Getter and setter of each element
        /// </summary>
        public string Name { get { return this.name; } set { this.name = value; } }
        public float BorrowCapital { get { return this.borrowCapital; } set { this.borrowCapital = value; } }
        public int TimeInMonth { get { return this.timeInMonth; } set { this.timeInMonth = value; } }
        public Periodicity Periodicity { get { return this.periodicity; } set { this.periodicity = value; } }
        public double PercentageRate { get { return this.percentageRate; } set { this.percentageRate = value; } }

        /// <summary>
        /// Number of refund for a loan 
        /// </summary>
        public int NumberOfRefund()
        {
            return this.timeInMonth / Convert.ToInt32(this.periodicity);
        }

        /// <summary>
        /// Amount of each step -> each month usually
        /// </summary>
        public double AmountOfEachSteps()
        {
            double rate = this.percentageRate / 100 / 12 * (int)this.periodicity;
            float repaymentNumber = NumberOfRefund();
            return (float)(this.borrowCapital * (rate / (1 - Math.Pow(1 + rate, -repaymentNumber))));
        }

        /// <summary>
        /// Debug with to String function override
        /// </summary>
        public override string ToString()
        {
            return "Name = " + this.name + ", borrowCapital = " + this.borrowCapital;
        }
    }
}
