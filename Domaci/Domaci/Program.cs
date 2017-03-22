using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domaci
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //TemperatureConvertor TC = new TemperatureConvertor();
            int Option = 1;
            while (Option != 0)
            {
                menu();
                Option = Convert.ToInt32(System.Console.ReadLine());
                double tmp;

                switch (Option)
                {
                    case 1: 
                        Console.WriteLine("Input temperature value in farenheit:");
                        try
                        {
                            tmp = Convert.ToDouble(Console.ReadLine());
                            TemperatureConvertor TC = new TemperatureConvertor(tmp);
                            Console.WriteLine(TC.CelsiusToFaren());
                        }
                        catch
                        {
                            Console.WriteLine("Greska u parametrima!");
                        }
                        break;
                    case 2: 
                        Console.WriteLine("Input temperature value in celsius:");
                        try
                        {
                            tmp = Convert.ToDouble(Console.ReadLine());
                            TemperatureConvertor TC1 = new TemperatureConvertor(tmp);
                            Console.WriteLine(TC1.FarenToCelsius());
                        }
                        catch
                        {
                            Console.WriteLine("Greska u parametrima!");
                        }
                        break;
                    default: break;
                }
            }
        }

        static void menu()
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1)Celsius to Farenheit");
            Console.WriteLine("2)Farenheit to celsius");
            Console.WriteLine("0)Exit");
        }
    }
}
