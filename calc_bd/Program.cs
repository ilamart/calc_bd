using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_bd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите выражение: "); //Предлагаем ввести выражение
            string exp = Console.ReadLine();
            Console.WriteLine("{0} = {1}", exp, new System.Data.DataTable().Compute(exp, ""));
            Console.ReadKey();
        }
    }
}
