using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1.BL
{
    public class StaffBL : PersonBL
    {
        private string school;
        private double pay;

        public StaffBL(string name, string address, string school, double pay)
            : base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }

        public string GetSchool()
        {
            return school;
        }

        public void SetSchool(string school)
        {
            this.school = school;
        }

        public double GetPay()
        {
            return pay;
        }

        public void SetPay(double pay)
        {
            this.pay = pay;
        }

        public override string ToString()
        {
            return $"Staff: {base.ToString()}, School: {school}, Pay: {pay}";
            
        }
    }
}
