using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CMFacture
{
    public class ClassMetierFacture
    {
        private string name;
        private DateTime date;
        private double amount;
        private int zipCode;

        public ClassMetierFacture()
        {
            name = "";
            date = DateTime.Now;
            amount = 0;
            zipCode = 0;
        }

        public ClassMetierFacture(string _name, DateTime _date, double _amount, int _zipcode)//int
        {
            name = _name;
            date = _date;//DateTime.Parse(_date, CultureInfo.CurrentCulture);
            amount = _amount;//double.Parse(_amount, CultureInfo.CurrentCulture);
            zipCode = _zipcode;
        }

        public string Name
        {
            get => name;
            //set => name = value; 
        }
        public DateTime Date
        {
            get => date;
            //set => date = value; 
        }
        public double Amount
        {
            get => amount;
            //set => amount = value; 
        }
        public int Code
        {
            get => zipCode;
            //set => zipCode = value; 
        }

        /// <summary>
        ///     
        /// </summary>
        public override string ToString()
        {
            return
                $"Name : {name}\n" +
                $"Date : {date:dd/MM/yyyy}\n" +
                $"Amount : {Math.Round(amount, 2)}\n" +
                $"Zip Code : {zipCode}";
        }
    }
}
