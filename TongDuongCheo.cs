using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TongDuongCheo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap co cot,hang cua mang hinh vuong: ");
            int Colum = int.Parse(Console.ReadLine());
            int Row = Colum;
            int[,] MaTran = new int[Colum, Row];

            //nhap gia tri ma tran
            Console.WriteLine("Nhap gia tri cho ma tran: ");
            for (int i = 0; i < MaTran.GetLength(0); i++)
            {
                for (int j = 0; j < MaTran.GetLength(1); j++)
                {
                    Console.Write($"nhap gia tri cho phan tu tai vi tri ({i};{j})");
                    MaTran[i, j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Ma tran da nhap: ");
            for (int i = 0; i < MaTran.GetLength(0); i++)
            {
                for (int j = 0; j < MaTran.GetLength(1); j++)
                {
                    Console.Write(MaTran[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int Tong = 0;
            for (int i = 0; i < MaTran.GetLength(0); i++)
            {
                for (int j = 0; j < MaTran.GetLength(1); j++)
                {
                        if (i == j)
                        {
                            Tong += MaTran[i, j];
                        }
                    
                }

            }
            Console.WriteLine("Gia tri tong cua duong cheo trong Mang la: " + Tong);
        }
    }
}
