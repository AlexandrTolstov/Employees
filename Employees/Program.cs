using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();

            object frank = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            Hexagon hex;
            try
            {
                hex = (Hexagon)frank;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thing";

            foreach (object item in things)
            {
                Hexagon h = item as Hexagon;
                if(h==null)
                    Console.WriteLine("Item is not a hexagon");
                else
                {
                    h.Draw();
                }
            }

            Console.ReadLine();
        }
        static void CastingExamples()
        {
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            GivePromotion((Manager)frank);

            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);
            SalesPerson jil = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
            GivePromotion(jil);
        }
        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was prometed", emp.Name);
            //if(emp is SalesPerson s)
            //{
            //    Console.WriteLine("{0} made {1} sales(s)!", emp.Name, s.SalesNumber);
            //    Console.WriteLine();
            //}
            //if(emp is Manager m)
            //{
            //    Console.WriteLine("{0} had {1} stock option...", emp.Name, m.StockOption);
            //    Console.WriteLine();
            //}
            Console.WriteLine("{0} was promoted!", emp.Name);
            switch (emp)
            {
                case SalesPerson s:
                    Console.WriteLine($"{emp.Name} made {s.SalesNumber} sale(s)!");
                    break;
                case Manager m:
                    Console.WriteLine($"{emp.Name} stock option...", emp.Name, m.StockOption);
                    break;
                case null:
                    break;
            }
        }
    }
}
