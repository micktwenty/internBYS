using System;
using System.Collections.Generic;
using System.Linq;


namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            quanlyPerson quanlyPerson = new quanlyPerson();
            quanlyPerson.addMem();
            bool role = true;
            while (role)
            {

                Console.WriteLine("\nCHUONG TRINH QUAN LY CUA C#");
                Console.WriteLine("\nCHON DOI TUONG: ");
                Console.WriteLine("1. DANH SACH DOI TUONG QUAN LY. ");
                Console.WriteLine("2. HOC SINH. ");
                Console.WriteLine("3. SINH VIEN.");
                Console.WriteLine("4. CONG NHAN.");
                Console.WriteLine("5. NGHE SI.");
                Console.WriteLine("6. THOAT CHUONG TRINH.");

                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                bool role2 = true;
                switch (key)
                {
                    case 2:
                        quanLyHS quanLyHS = new quanLyHS();
                        while (role2)
                        {

                            Console.WriteLine("\nCHUONG TRINH QUAN LY HOC SINH CUA C#");
                            Console.WriteLine("\n1. XEM DANH SACH CHI TIET HOC SINH. ");
                            Console.WriteLine("2. THEM HOC SINH.");
                            Console.WriteLine("3. TIM KIEM HOC SINH BANG TEN.");
                            Console.WriteLine("4. SO LUONG HOC SINH. ");
                            Console.WriteLine("5. THOAT RA MENU CHINH.");

                            Console.Write("Nhap tuy chon: ");
                            int key2 = Convert.ToInt32(Console.ReadLine());
                            switch (key2)
                            {
                                case 1:
                                    quanLyHS.listHSinh(quanlyPerson.listPerson);
                                    Console.ReadKey();

                                    break;
                                case 2:
                                    quanLyHS.addNew(quanLyHS.NhapTT(),quanlyPerson.listPerson);
                                    Console.WriteLine("THEM MOI HOC SINH THANH CONG!");
                                    quanLyHS.listHSinh(quanlyPerson.listPerson);


                                    break;
                                case 3:
                                    Console.Write("Nhap ten can tim kiem: ");
                                    string search = Convert.ToString(Console.ReadLine());
                                    quanLyHS.FindByName(search, quanlyPerson.listPerson);
                                    Console.ReadLine();


                                    break;
                                case 4:
                                    Console.WriteLine($"Danh sach hoc sinh co {quanLyHS.SoluongHS(quanlyPerson.listPerson)} hoc sinh");
                                    Console.ReadKey();


                                    break;
                                case 5:
                                    role2 = false;
                                    break;
                            }
                        }
                       
                        break;
                    case 3:
                        quanLySV quanLySV = new quanLySV();
                        while (role2)
                        {
                            Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN CUA C#");
                            Console.WriteLine("\n1. XEM DANH SACH CHI TIET SINH VIEN. ");
                            Console.WriteLine("2. THEM SINH VIEN.");
                            Console.WriteLine("3. TIM KIEM SINH VIEN BANG TEN.");
                            Console.WriteLine("4. SO LUONG SINH VIEN. ");
                            Console.WriteLine("5. THOAT RA MENU CHINH.");

                            Console.Write("Nhap tuy chon: ");
                            int key3 = Convert.ToInt32(Console.ReadLine());
                            switch (key3)
                            {
                                case 1:
                                    quanLySV.listSV(quanlyPerson.listPerson);
                                    Console.ReadKey();

                                    break;
                                case 2:
                                    quanLySV.addNew(quanLySV.NhapTT(), quanlyPerson.listPerson);
                                    Console.WriteLine("THEM MOI SINH VIEN THANH CONG!");
                                    quanLySV.listSV(quanlyPerson.listPerson);


                                    break;
                                case 3:
                                    Console.Write("Nhap ten can tim kiem: ");
                                    string search = Convert.ToString(Console.ReadLine());
                                    quanLySV.FindByName(search, quanlyPerson.listPerson);
                                    Console.ReadLine();


                                    break;
                                case 4:
                                    Console.WriteLine($"Danh sach co {quanLySV.SoluongSV( quanlyPerson.listPerson)} SINH VIEN");
                                    Console.ReadKey();


                                    break;
                                case 5:
                                    role2 = false;
                                    break;
                            }
                        }

                        break;
                    case 4:
                        quanLyCN quanLyCN = new quanLyCN();
                        while (role2)
                        {
                            Console.WriteLine("\nCHUONG TRINH QUAN LY CONG NHAN CUA C#");
                            Console.WriteLine("\n1. XEM DANH SACH CHI TIET CONG NHAN. ");
                            Console.WriteLine("2. THEM CONG NHAN.");
                            Console.WriteLine("3. TIM KIEM CONG NHAN BANG TEN.");
                            Console.WriteLine("4. SO LUONG CONG NHAN. ");
                            Console.WriteLine("5. THOAT RA MENU CHINH.");

                            Console.Write("Nhap tuy chon: ");
                            int key4 = Convert.ToInt32(Console.ReadLine());
                            switch (key4)
                            {
                                case 1:
                                    quanLyCN.listCN(quanlyPerson.listPerson);
                                    Console.ReadKey();

                                    break;
                                case 2:
                                    quanLyCN.addNew(quanLyCN.NhapTT(), quanlyPerson.listPerson);
                                    Console.WriteLine("THEM MOI CONG NHAN THANH CONG!");
                                    quanLyCN.listCN(quanlyPerson.listPerson);


                                    break;
                                case 3:
                                    Console.Write("Nhap ten can tim kiem: ");
                                    string search = Convert.ToString(Console.ReadLine());
                                    quanLyCN.FindByName(search, quanlyPerson.listPerson);
                                    Console.ReadLine();


                                    break;
                                case 4:
                                    Console.WriteLine($"Danh sach co {quanLyCN.SoluongCN(quanlyPerson.listPerson)} CONG NHAN");
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    role2 = false;
                                    break;
                            }
                        }
                    
                        break;
                    case 5:
                        quanLyNS quanLyNS = new quanLyNS();
                        while (role2)
                        {
                            Console.WriteLine("\nCHUONG TRINH QUAN LY NGHE SI CUA C#");
                            Console.WriteLine("\n1. XEM DANH SACH CHI TIET NGHE SI. ");
                            Console.WriteLine("2. THEM CONG NHAN.");
                            Console.WriteLine("3. TIM KIEM NGHE SI BANG TEN.");
                            Console.WriteLine("4. SO LUONG NGHE SI. ");
                            Console.WriteLine("5. THOAT RA MENU CHINH.");
                            Console.Write("Nhap tuy chon: ");
                            int key5 = Convert.ToInt32(Console.ReadLine());
                            switch (key5)
                            {
                                case 1:
                                    quanLyNS.listNSi(quanlyPerson.listPerson);
                                    Console.ReadKey();

                                    break;
                                case 2:
                                    quanLyNS.addNew(quanLyNS.NhapTT(), quanlyPerson.listPerson);
                                    Console.WriteLine("THEM MOI NGHE SI THANH CONG!");
                                    quanLyNS.listNSi(quanlyPerson.listPerson);


                                    break;
                                case 3:
                                    Console.Write("Nhap ten can tim kiem: ");
                                    string search = Convert.ToString(Console.ReadLine());
                                    quanLyNS.FindByName(search, quanlyPerson.listPerson);
                                    Console.ReadLine();


                                    break;
                                case 4:
                                    Console.WriteLine($"Danh sach co {quanLyNS.SoluongNS(quanlyPerson.listPerson)} NGHESI");
                                    Console.ReadKey();

                                    break;
                                case 5:
                                    role2 = false;
                                    break;
                            };
                        }
                        
                        break;
                    case 6:
                        return;
             
                    case 1:
                        quanlyPerson.listPS(quanlyPerson.listPerson);
                        Console.ReadKey();
                        break;


                }

            }    


        }
    }
}
