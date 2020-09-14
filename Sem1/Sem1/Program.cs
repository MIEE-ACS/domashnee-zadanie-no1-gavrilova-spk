using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1
{
    class Program
    {
        static double Check(ref string str)  //Проверка на десятичное число, замена точки на запятую
        {
            for (int p = 0; p < str.Length; p++)
            {
                if (str[p] != ',' && str[p] != '.' && str[p] != '-')
                    if (str[p] < '0' || str[p] > '9')
                    {
                        Console.Write("Ошибка: Некорректные данные. Введите число:");
                        str = Console.ReadLine();
                        p = -1;
                        continue;
                    }
            }
            int i = str.IndexOf('.');
            str = str.Replace('.', ',');
            return Double.Parse(str);

        }
        static void Main(string[] args)
        {
            Console.Write("Введите координату точки А:  ");
            string str = Console.ReadLine();
            double A = Check(ref str);
            Console.Write("Введите координату точки B:  ");
            string str1 = Console.ReadLine();
            double B = Check(ref str1);
            Console.Write("Введите координату точки C:  ");
            string str2 = Console.ReadLine();
            double C = Check(ref str2);

            double AC = Math.Abs(A - C);
            double BC = Math.Abs(B - C);
            Console.Write("Длины     АС = {0:N3};     BC = {1:N3};     AC + BC = {2:N3}", AC, BC, AC + BC);
            Console.ReadKey();
        }
    }
}
