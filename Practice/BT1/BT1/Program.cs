using System;
//using System.Linq;
//using System.Collections.Generic;

namespace BT1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n;
            int[] mang, mang2;

            Console.Write("Nhap so phan tu: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            mang = new int[n];
            mang2 = new int[n];
           

            

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu {i+1} :");
                mang[i] = Convert.ToInt32(Console.ReadLine());
                mang2[i] = mang[i];

            }

            //  - Tìm giá trị lớn nhất trong mảng.
            int max = mang[0];
            for (int i = 1; i < n; i++)
            {
                if (max < mang[i])
                {
                    max = mang[i];
                }

            }
            Console.WriteLine("Gia tri lon nhat la: " + max);

            
            // -Sắp xếp mảng theo thứ tự tăng dần.
            Console.Write("Mang sau khi duoc sap xep theo thu tu tang dan :");
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (mang2[i] > mang2[j])
                    {

                        int p = mang2[i];
                        mang2[i] = mang2[j];
                        mang2[j] = p;
                    }
                }
            }
            foreach (int i in mang2)
            {
                Console.Write(i + " ");
            }

            // - Tìm và di chuyển k phần thử lớn nhất trong mảng đến trị trí đầu tiên sao cho các phần tử còn lại
            // không thay đổi vị trí của nó.

            Console.Write("\nNhap so phan tu can di chuyen: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMang ban dau: ");
           
            foreach (var item in mang)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nMang sau khi sap xep: ");
            for (int i = 0; i < k; i++)
            {
                mang2[i] = max;
                int indexMax = Array.IndexOf(mang, mang2[i]);
                if (indexMax + 1 < mang.Length)
                {
                    for (int l = indexMax; l < mang.Length - 1; l++)
                    {
                        mang[l] = mang[l+1];
                    }
                }
               
                max = mang[0];
                for (int j = 0; j < mang.Length; j++)
                {
                    if (max < mang[j])
                    {
                        max = mang[j];
                    }

                }


            }
            for (int i = 0; i < mang.Length - k; i++)
            {
                mang2[i + k] = mang[i];
            }
            foreach (int i in mang2)
            {
                Console.Write(i + " ");
            }

        }



    }
}
