using Practice.Models;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SalaryCalculator
            //Console.WriteLine("Maas Calculatoru");
            //Console.WriteLine("Zehmet Olmasa Maasinizi Daxil Edin");
            //double salary = Convert.ToDouble(Console.ReadLine());
            //int health = 4;
            //int insurance = 3;
            //Console.WriteLine("===================");
            //double TotalSalary = salary - (health + insurance);
            //Console.WriteLine($"Sizin Maasinizin saqlamliq:{health} AZN ve siqorta :" +
            //    $"{insurance} AZN tutulmalarindan sonraki deyeri {TotalSalary} AZN qederdir");
            //Console.WriteLine("=======================================================================");

            //int choise;
            //do
            //{
            //    Console.WriteLine("=======================================================================");
            //    Console.WriteLine("Dollar Versiyasi ucun - 1");
            //    Console.WriteLine("Avro Versiyasi ucun - 2");
            //    Console.WriteLine("Turk Liresi Versiyasi ucun - 3");
            //    Console.WriteLine("Cixis Ucun - 4");
            //    Console.WriteLine("=======================================================================");
            //    choise = Convert.ToInt32(Console.ReadLine());

            //    switch (choise)
            //    {
            //        case 1:
            //            Console.WriteLine("=======================================================================");
            //            Console.WriteLine($"Sizin maasiniz {TotalSalary}-nin Dollar qarsiliqi {TotalSalary / 1.70} ");
            //            Console.WriteLine("=======================================================================");

            //            break;
            //        case 2:
            //            Console.WriteLine("=======================================================================");
            //            Console.WriteLine($"Sizin maasiniz {TotalSalary}-nin Avro qarsiliqi {TotalSalary / 1.80} ");
            //            Console.WriteLine("=======================================================================");

            //            break;
            //        case 3:
            //            Console.WriteLine("=======================================================================");
            //            Console.WriteLine($"Sizin maasiniz {TotalSalary}-nin Turk Liresi qarsiliqi {TotalSalary * 10.96} ");
            //            Console.WriteLine("=======================================================================");
            //            break;
            //        case 4:
            //            Console.WriteLine("=======================================================================");
            //            Console.WriteLine("Tesekkurler Saqolun . Xeyirli xercleyin");
            //            Console.WriteLine("=======================================================================");
            //            break;
            //        default:
            //            Console.WriteLine("=======================================================================");
            //            Console.WriteLine("Bele Secim Yoxdur");
            //            Console.WriteLine("=======================================================================");

            //            break;
            //    }

            //} while (choise != 4);
            #endregion
            Bus daewoo= new Bus(12,"Daewoo1",100,2,10);
            Bicycle steels= new Bicycle(2,"Insan",100,4,30);

            steels.ShowInfo();
            daewoo.GetSpeed();
        }
    }
}