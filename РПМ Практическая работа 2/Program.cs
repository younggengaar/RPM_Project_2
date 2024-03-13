using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace РПМ_Практическая_работа_2
{
    internal class Program
    {
        static int Binary(int[]array, int a)
        {
            int lf = 0;
            int rt = array.Length - 1;
            while (lf <= rt)
            {
                int seredina = lf + (rt - lf) / 2;
                if(array[seredina] == a)
                {
                    return seredina;
                }
                if (array[seredina] < a)
                {
                    lf=seredina+1;
                }
                else
                {
                    rt = seredina - 1;
                }
            }return-1;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во элементов:");
            int kol=int.Parse(Console.ReadLine());
            try
            {
                int[] array = new int[kol];
                Console.Write("Введите число,которое хотите найти:");
                int a = int.Parse(Console.ReadLine());
                int s = -1;
                for(int i=0; i<array.Length; i++)
                {
                    Console.Write("Введите элемент массива:");
                    array[i] = int.Parse(Console.ReadLine());
                }
                for(int j=0; j<array.Length; j++)
                {
                    while (j > 0 && array[j] < array[j-1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                        j = j - 1;
                    }
                }
                foreach(var element in array)
                {
                    Console.Write($"array={element}");
                }
                Console.Write("Выберите линейный(1) или бинарный(2):");
                int p = int.Parse(Console.ReadLine());
                switch(p)
                {
                    case 1:
                        {
                            for(int i=0; i<kol;i++)
                            {
                                if (array[i] == a)
                                {
                                    s = i;
                                    Console.WriteLine($"array [{s}]={array[s]}");
                                }
                            }
                        }
                        break;
                    case 2:
                        {
                            int b = Binary(array, a);
                            if(b == -1)
                            {
                                Console.WriteLine("Этих элементов в массиве нет.");
                            }
                            else
                            {
                                Console.WriteLine($"array[{b}]={array[b]}");
                            }
                        }
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Введено не то число.");
            }
            Console.ReadKey();
        }
    }
}
