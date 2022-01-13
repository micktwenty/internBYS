using System;
using System.Collections.Generic;
using System.Linq;


namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY CUA C#");
            Console.WriteLine("\nCHON DOI TUONG: ");

            Console.WriteLine("1. HOC SINH. ");
            Console.WriteLine("2. SINH VIEN.");
            Console.WriteLine("3. CONG NHAN.");
            Console.WriteLine("4. NGHE SI.");
            Console.WriteLine("5. THOAT.");

            Console.Write("Nhap tuy chon: ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch(key)
            {
                case 1:
                    
                    hocsinh newHS = new hocsinh();
                    newHS.addMem();
                    Console.WriteLine("1. XEM DANH SACH CHI TIET HOC SINH. ");
                    Console.WriteLine("2. THEM HOC SINH.");
                    Console.WriteLine("3. TIM KIEM HOC SINH BANG TEN.");
                    Console.WriteLine("4. SO LUONG HOC SINH. ");
                    Console.WriteLine("5. THOAT.");

                    Console.Write("Nhap tuy chon: ");
                    int key2 = Convert.ToInt32(Console.ReadLine());
                    switch (key2)
                    {
                        case 1:
                          
                            newHS.listHSinh(newHS.GetHocsinhs());
                            Console.ReadKey();
                            Main(args);
                            break;
                        case 2:
                            newHS.NhapTT();
                            Console.WriteLine("THEM MOI HOC SINH THANH CONG!");
                            newHS.listHSinh(newHS.GetHocsinhs());
                            Main(args);

                            break;
                        case 3:
                            Console.Write("Nhap ten can tim kiem: ");
                            string search = Convert.ToString(Console.ReadLine());
                            newHS.FindByName(search);
                            Console.ReadLine();
                            Main(args);

                            break;
                        case 4:
                            Console.WriteLine($"Danh sach hoc sinh co {newHS.SoluongHS()} hoc sinh");
                            Console.ReadKey();
                            Main(args);

                            break;
                        case 5:
                            break;
                    }
                    break;
                case 2:
                    sinhvien newSV = new sinhvien();
                    newSV.addMem();
                    Console.WriteLine("1. XEM DANH SACH CHI TIET SINH VIEN. ");
                    Console.WriteLine("2. THEM SINH VIEN.");
                    Console.WriteLine("3. TIM KIEM SINH VIEN BANG TEN.");
                    Console.WriteLine("4. SO LUONG SINH VIEN. ");
                    Console.WriteLine("5. THOAT.");

                    Console.Write("Nhap tuy chon: ");
                    int key3 = Convert.ToInt32(Console.ReadLine());
                    switch (key3)
                    {
                        case 1:
                            newSV.listSV(newSV.Getsinhviens());
                            Console.ReadKey();
                            Main(args);

                            break;
                        case 2:
                            newSV.NhapTT();
                            Console.WriteLine("THEM MOI SINH VIEN THANH CONG!");
                            newSV.listSV(newSV.Getsinhviens());
                            Console.ReadKey();
                            Main(args);

                            break;
                        case 3:
                            Console.Write("Nhap ten can tim kiem: ");
                            string search = Convert.ToString(Console.ReadLine());
                            newSV.FindByName(search);
                            Console.ReadLine();
                            Main(args);

                            break;
                        case 4:
                            Console.WriteLine($"Danh sach sinh vien co {newSV.SoLuongSinhVien()} sinh vien");
                            Console.ReadLine();
                            Main(args);

                            break;
                        case 5:
                            break;
                    }
                    break;
                case 3:
                    congnhan newCN = new congnhan();
                    newCN.addMem();
                    Console.WriteLine("1. XEM DANH SACH CHI TIET CONG NHAN. ");
                    Console.WriteLine("2. THEM CONG NHAN.");
                    Console.WriteLine("3. TIM KIEM CONG NHAN BANG TEN.");
                    Console.WriteLine("4. SO LUONG CONG NHAN. ");
                    Console.WriteLine("5. THOAT.");

                    Console.Write("Nhap tuy chon: ");
                    int key4 = Convert.ToInt32(Console.ReadLine());
                    switch (key4)
                    {
                        case 1:
                            newCN.listCNhan(newCN.GetCNhan());
                            Console.ReadKey();
                            Main(args);

                            break;
                        case 2:
                            newCN.NhapTT();
                            Console.WriteLine("THEM MOI CONG NHAN THANH CONG!");
                            newCN.listCNhan(newCN.GetCNhan());
                            Console.ReadKey();
                            Main(args);

                            break;
                        case 3:
                            Console.Write("Nhap ten can tim kiem: ");
                            string search = Convert.ToString(Console.ReadLine());
                            newCN.FindByName(search);
                            Console.ReadLine();
                            Main(args);

                            break;
                        case 4:
                            Console.WriteLine($"Danh sach CONG NHAN co {newCN.SoluongCN()} CONG NHAN");
                            Console.ReadLine();
                            Main(args);

                            break;
                        case 5:
                            break;
                    }
                    break;
                case 4:
                    nghesi newNS = new nghesi();
                    newNS.addMem();
                    Console.WriteLine("1. XEM DANH SACH CHI TIET NGHE SI. ");
                    Console.WriteLine("2. THEM NGHE SI.");
                    Console.WriteLine("3. TIM KIEM NGHE SI BANG TEN.");
                    Console.WriteLine("4. SO LUONG NGHE SI. ");
                    Console.WriteLine("5. THOAT.");

                    Console.Write("Nhap tuy chon: ");
                    int key5 = Convert.ToInt32(Console.ReadLine());
                    switch (key5)
                    {
                        case 1:
                            newNS.listNSi(newNS.GetNS());
                            Console.ReadKey();
                            Main(args);

                            break;
                        case 2:
                            newNS.NhapTT();
                            Console.WriteLine("THEM MOI NGHE SI THANH CONG!");
                            newNS.listNSi(newNS.GetNS());
                            Console.ReadKey();
                            Main(args);
                            break;
                        case 3:
                            Console.Write("Nhap ten can tim kiem: ");
                            string search = Convert.ToString(Console.ReadLine());
                            newNS.FindByName(search);
                            Console.ReadLine();
                            Main(args);

                            break;
                        case 4:
                            Console.WriteLine($"Danh sach nghe si co {newNS.SoluongNS()} NGHE SI");
                            Console.ReadKey();
                            Main(args);
                            break;
                        case 5:
                            break;
                    }
                    break;
                case 5:
                    break;


            }    


        }
    }
}
