using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Customer
{
    public class CM_Customer
    {
        private string name;

        public CM_Customer()
        {
            name = "";
        }

        public CM_Customer(string _name)
        {
            name = _name;
        }

        public string Name
        {
            get => name;
            //set => name = value; 
        }
    }
}
