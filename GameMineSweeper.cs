using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Cols = 10;
            int Rows = 10;
            int[,]Map =new int[Cols, Rows];
            Random random = new Random();
            int SoluongBOM = 10;
            //
            for (int i = 0;i<SoluongBOM;i++)
            {
                int ColBOM, RowBOM;
                
                do { ColBOM = random.Next(Cols);
                    RowBOM = random.Next(Rows); }
                while (Map[RowBOM,ColBOM]==-1);
                Map[RowBOM, ColBOM] = -1;
            }
            //tinh so Bom lan can
            for(int row = 0; row < Rows; row++)
            {
                for(int colum = 0; colum < Cols; colum++)
                {
                    if (Map[row, colum] == -1) { continue; }

                    //dem so Bom xung quanh
                    int SoBOM = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int RowXQuanh = row + i;
                            int ColXQuanh = colum + j;

                            if(RowXQuanh >= 0 && RowXQuanh < Rows && ColXQuanh >= 0 && ColXQuanh < Cols)
                            {
                                if (Map[RowXQuanh, ColXQuanh] == -1)
                                {
                                    SoBOM++;
                                }
                            }
                        }
                    }
                    Map[row, colum] = SoBOM;

                }

                
                
            }
            Console.WriteLine("Ban do tro choi MineSweeper:");
            for(int row = 0;row < Rows; row++)
            {
                for( int colum = 0;colum < Cols; colum++)
                {
                    if (Map[row, colum] == -1)
                    {
                        Console.Write("* "); // Hiển thị mìn
                    }
                    else
                    {
                        Console.Write(Map[row, colum] + " "); // Hiển thị số lượng mìn lân cận
                    }

                }
                Console.WriteLine(); // Xuống dòng sau mỗi hàng
            }
        }
    }
}
