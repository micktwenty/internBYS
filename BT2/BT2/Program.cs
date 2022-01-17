using System;
using System.Collections.Generic;
using System.Linq;


namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
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
                switch (key)
                {
                    case 1:
                        quanLyHS quanLyHS = new quanLyHS();
                        quanLyHS.addMem();
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
                                quanLyHS.listHSinh(quanLyHS.listHS);
                                Console.ReadKey();

                                break;
                            case 2:
                                quanLyHS.addNew(quanLyHS.NhapTT());
                                Console.WriteLine("THEM MOI HOC SINH THANH CONG!");
                                quanLyHS.listHSinh(quanLyHS.listHS);


                                break;
                            case 3:
                                Console.Write("Nhap ten can tim kiem: ");
                                string search = Convert.ToString(Console.ReadLine());
                                quanLyHS.FindByName(search);
                                Console.ReadLine();


                                break;
                            case 4:
                                Console.WriteLine($"Danh sach hoc sinh co {quanLyHS.SoluongHS()} hoc sinh");
                                Console.ReadKey();


                                break;
                            case 5:
                                break;
                        }
                        break;
                    case 2:
                        quanLySV quanLySV = new quanLySV();
                        quanLySV.addMem();
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
                                quanLySV.listSV(quanLySV.listSvien);
                                Console.ReadKey();

                                break;
                            case 2:
                                quanLySV.addNew(quanLySV.NhapTT());
                                Console.WriteLine("THEM MOI SINH VIEN THANH CONG!");
                                quanLySV.listSV(quanLySV.listSvien);


                                break;
                            case 3:
                                Console.Write("Nhap ten can tim kiem: ");
                                string search = Convert.ToString(Console.ReadLine());
                                quanLySV.FindByName(search);
                                Console.ReadLine();


                                break;
                            case 4:
                                Console.WriteLine($"Danh sach co {quanLySV.SoluongSV()} SINH VIEN");
                                Console.ReadKey();


                                break;
                            case 5:
                                break;
                        }
                        break;
                    case 3:
                        quanLyCN quanLyCN = new quanLyCN();
                        quanLyCN.addMem();
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
                                quanLyCN.listCN(quanLyCN.listCNhan);
                                Console.ReadKey();

                                break;
                            case 2:
                                quanLyCN.addNew(quanLyCN.NhapTT());
                                Console.WriteLine("THEM MOI CONG NHAN THANH CONG!");
                                quanLyCN.listCN(quanLyCN.listCNhan);


                                break;
                            case 3:
                                Console.Write("Nhap ten can tim kiem: ");
                                string search = Convert.ToString(Console.ReadLine());
                                quanLyCN.FindByName(search);
                                Console.ReadLine();


                                break;
                            case 4:
                                Console.WriteLine($"Danh sach co {quanLyCN.SoluongCN()} CONG NHAN");
                                Console.ReadKey();
                                break;
                            case 5:
                                break;
                        }
                        break;
                    case 4:
                        quanLyNS quanLyNS = new quanLyNS();
                        quanLyNS.addMem();
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
                                quanLyNS.listNSi(quanLyNS.listNS);
                                Console.ReadKey();

                                break;
                            case 2:
                                quanLyNS.addNew(quanLyNS.NhapTT());
                                Console.WriteLine("THEM MOI NGHE SI THANH CONG!");
                                quanLyNS.listNSi(quanLyNS.listNS);


                                break;
                            case 3:
                                Console.Write("Nhap ten can tim kiem: ");
                                string search = Convert.ToString(Console.ReadLine());
                                quanLyNS.FindByName(search);
                                Console.ReadLine();


                                break;
                            case 4:
                                Console.WriteLine($"Danh sach co {quanLyNS.SoluongNS()} NGHESI");
                                Console.ReadKey();

                                break;
                            case 5:
                                break;
                        };
                        break;
                    case 5:
                        break;


                }

            }    


        }
    }
}
