using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TimMax
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap co cot cua mang: ");
            int Colum =int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so hang cua mang: ");
            int Row =int.Parse(Console.ReadLine());
            int[,] MaTran = new int[Colum, Row];

            //nhap gia tri ma tran
            Console.WriteLine("Nhap gia tri cho ma tran: ");
            for (int i = 0; i < MaTran.GetLength(0); i++)
            {
                for (int j = 0; j < MaTran.GetLength(1); j++)
                {
                    Console.Write($"nhap gia tri cho phan tu tai vi tri ({i};{j})");
                    MaTran[i,j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Ma tran da nhap: ");
            for(int i = 0;i < MaTran.GetLength(0); i++)
            {
                for(int j = 0;j < MaTran.GetLength(1); j++)
                {
                    Console.Write(MaTran[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int Max = MaTran[0, 0];
            int maxRow = 0;
            int maxColumn = 0;
            for (int i = 0; i < MaTran.GetLength(0); i++)
            {
                for (int j = 0; j < MaTran.GetLength(1); j++)
                {
                    if(MaTran[i, j] > Max)
                    {
                        Max = MaTran[i, j];
                         maxRow = i;
                         maxColumn = j;

                    }
                }

            }
            Console.WriteLine("Gia tri max trong Mang la: " + Max + $" tai vi tri: ({maxRow},{maxColumn})");

        }
    }
}
