using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double aditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double aditionalCharge) : base (name,hours, valuePerHour)
        {
            this.aditionalCharge = aditionalCharge;
        }

        override public double payment()
        {
            return (aditionalCharge*1.1 ) + base.payment();
        }


    }
}
