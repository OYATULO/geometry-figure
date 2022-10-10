using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary.Tests;
using Geometry_Library;

namespace WorkWithGeometry
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\tВыберите ? ");
            string[] Select = { "Сумма 2-элеменета", "Площадь круга по радиусу", "площадь  треугольника по трем сторонам" };
            int n;
            string exit = "y";
            do
            {
                for (int i = 0; i < Select.GetLength(0); i++)
                {
                    Console.Write($"{i + 1}: {Select[i]}\n");
                }
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        SummaTwoElements(); //Сумма 2 элемента
                        break;
                    case 2:
                        PloshadKrugaPoRadiusa();//Площадь круга по радиусу
                        break;
                    case 3:
                        PloshadTreugolnikaPoTriStr();//площадь  треугольника по трем сторонам
                        break;
                    default:
                        Console.WriteLine("Default");
                        break;
                }
                Console.Write("Хотите продольжать y/n : ");
                exit = Console.ReadLine();

            } while (exit != "n");

            Console.WriteLine("Вы отменили !!!");
            Console.ReadKey();
        }

        //Region
        #region Все функция

        //Сумма 2 элемента
        static void SummaTwoElements()
        {
            Console.Write("a=  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=  ");
            int b = Convert.ToInt32(Console.ReadLine());
            int summ = ClassGeometry.SumTwo(a, b);
            Console.WriteLine(summ);
            UnitTestGeometry Test = new UnitTestGeometry();
            Test.TestSumTwo();
            Console.WriteLine(Test.ToString() + "  Работает");
        }

        //Площадь круга по радиусу
        static void PloshadKrugaPoRadiusa()
        {
            Console.Write("r= ");
            double r = Convert.ToDouble(Console.ReadLine());
            double result = ClassGeometry.PloKruPoRadiusa(r);
            Console.WriteLine(result);
            UnitTestGeometry test = new UnitTestGeometry();
            test.TestPloshadKrugaPoRadiusa();
            Console.WriteLine(test.ToString() + "  Работает");
        }
        //площадь  треугольника по трем сторонам
        static void PloshadTreugolnikaPoTriStr()
        {
            Console.Write("a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c= ");
            double c = Convert.ToDouble(Console.ReadLine());
            double result = ClassGeometry.PloTriPoTriSto(a, b, c);
            Console.WriteLine(result);
            UnitTestGeometry test = new UnitTestGeometry();
            test.TestPloshadTreugolnikaPoTriStr();
            Console.WriteLine(test.ToString() + "  Работает");
        }
        #endregion
    }
}
