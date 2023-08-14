using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Entities
{
    internal class Employee
    {
        public string name { get; set; }
        public int hours { get; set; }
        public double valuePerHour { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            this.name = name;
            this.hours = hours;
            this.valuePerHour = valuePerHour;
        }

        public virtual double payment()
        {
            return valuePerHour*hours;
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("Name: "+name);
        //    sb.AppendLine("")
        //    return "";
        //}
    }
}
