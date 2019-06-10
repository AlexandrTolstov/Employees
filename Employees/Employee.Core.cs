using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;
        protected BenefitPackage empBenefits = new BenefitPackage();
        public BenefitPackage Benefit
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
        public int Age
        {
            get => empAge;
            set => empAge = value;
        }
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    empName = value;
            }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        public string SocialSecurityNumber
        {
            get { return empSSN; }
            set { empSSN = value; }
        }

        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay, string ssn):this(name, age, id, pay)
        {
            empSSN = ssn;
        }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            ID = id;
            Pay = pay;
            Age = age;
        }
    }
}
