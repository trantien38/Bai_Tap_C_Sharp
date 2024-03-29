﻿using System;

namespace BT_Diem_Danh_10_05
{
    class Program
    {
        public static void NhapMang()
        {
            int i_252, j_252, tam_252;
            int[] a_252 = new int[10];

            for(i_252 = 0; i_252 < 10; i_252++)
            {
                Console.Write("Nhap so thu " + (i_252 + 1) + ": ");
                a_252[i_252] = int.Parse(Console.ReadLine());
            }
            int min_252 = a_252[0], max_252 = a_252[0];

            #region Sắp xếp tăng
            for (i_252 = 0; i_252 < 10; i_252++)
            {
                for (j_252 = i_252 + 1; j_252 < 10; j_252++)
                {
                    if (a_252[i_252] > a_252[j_252])
                    {
                        tam_252 = a_252[i_252];
                        a_252[i_252] = a_252[j_252];
                        a_252[j_252] = tam_252;
                    }
                }
            }
            Console.Write("Sap xep tang dan: ");
            for (i_252 = 0; i_252 < 10; i_252++)
            {
                Console.Write(" " + a_252[i_252]);
            }
            #endregion
            
            #region Sắp xếp giảm
            for (i_252 = 0; i_252 < 10; i_252++)
            {
                for (j_252 = i_252 + 1; j_252 < 10; j_252++)
                {
                    if (a_252[i_252] < a_252[j_252])
                    {
                        tam_252 = a_252[i_252];
                        a_252[i_252] = a_252[j_252];
                        a_252[j_252] = tam_252;
                    }
                }
            }
            Console.Write("\nSap xep giam dan: ");
            for (i_252 = 0; i_252 < 10; i_252++)
            {
                Console.Write(" " + a_252[i_252]);
            }
            #endregion
            
            #region  Tim min max
            for (i_252 = 0; i_252 < 10; i_252++)
            {
                if (a_252[i_252] < min_252)
                {
                    min_252 = a_252[i_252];
                }
                if (a_252[i_252] > max_252)
                {
                    max_252 = a_252[i_252];
                }
            }
            Console.WriteLine("\nGia tri min: " + min_252);
            Console.WriteLine("Gia tri max: " + max_252);
            #endregion

        }



        static void Main(string[] args)
        {
            NhapMang();
            Console.ReadKey();
        }
    }
}
