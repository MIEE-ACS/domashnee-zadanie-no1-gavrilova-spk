using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1
{
    class Program
    {
        static float Check(ref string str)  //Проверка на десятичное число, замена точки на запятую
        {
            float num;

            int i = str.IndexOf('.');
            str = str.Replace('.', ',');

            if (!float.TryParse(str, out num))
            {
                Console.WriteLine("Вводить надо число. Конец программы.");
                Environment.Exit(37707);
            }
        
            
            return num;

        }
        static void Main(string[] args)
        {
            Console.Write("Введите координату точки А:  ");
            string str = Console.ReadLine();
            float A = Check(ref str);
            Console.Write("Введите координату точки B:  ");
            string str1 = Console.ReadLine();
            float B = Check(ref str1);
            Console.Write("Введите координату точки C:  ");
            string str2 = Console.ReadLine();
            float C = Check(ref str2);

            float AC = Math.Abs(A - C);
            float BC = Math.Abs(B - C);
            Console.WriteLine("Длины     АС = {0:N3};     BC = {1:N3};     AC + BC = {2:N3}", AC, BC, AC + BC);
            Console.ReadKey();
            
        }
    }
}
