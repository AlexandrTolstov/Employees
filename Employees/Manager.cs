using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager:Employee
    {
        public int StockOption { get; set; }
        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numpOfOpts):base(fullName, age, empID, currPay, ssn)
        {
            ID = empID;
            Age = age;
            Name = fullName;
            Pay = currPay;

            StockOption = numpOfOpts;
        }
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOption += r.Next(500);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOption);
        }
    }
}
