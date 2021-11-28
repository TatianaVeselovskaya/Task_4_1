using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, resul = 0;
            string sta;
            Console.WriteLine("Введите N");
            sta = Console.ReadLine();
            if (int.TryParse(sta, out n))
            {
                n = Convert.ToInt32(sta);
                if (n > 0)
                {
                    for (int i = 1; i <= 2 * n - 1; i += 2)
                    {
                        resul = resul + (2 * i - 1);
                        Console.WriteLine("При N=" + i + " значение суммы = " + resul);
                    }
                }
                else
                { Console.WriteLine("Введенное N<=0"); }
            }
            else { Console.WriteLine("Введенное N не является целым число"); }
            Console.ReadKey();
        }
    }
}