using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class sinhvien : Person
    {
        private string truongDH { get; set; }
        private string chuyennganh { get; set; }
        private string masv { get; set; }
        public void addMem()
        {
            listSVien = new List<sinhvien>() {
                new sinhvien(){ ten = "Nguyen Quoc Thien", diachi = "TDP2b, Eakar, DakLak", gioitinh="nam", 
                                truongDH = "DUE",chuyennganh="MIS", masv = "181121521137"
                },
                new sinhvien(){ ten = "Nguyen Tran Hien Thuc", diachi = "TDP2b, Eakar, DakLak", gioitinh="nu", 
                                truongDH = "DUT", chuyennganh="MIS", masv= "79624WFFF"
                },
                new sinhvien(){ ten = "Truong Quoc Thinh", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nam", 
                                truongDH = "DTU", chuyennganh="MIS",masv= "79WWWFF"
                },
                new sinhvien(){ ten = "Tran Thi Son", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nu",
                                truongDH = "UFN", chuyennganh="MIS", masv= "FW5S5S82W"
                },
                new sinhvien(){ ten="Nguyen Van Hoai Nam", diachi = "xa Eadar, Eakar, DakLak", gioitinh="nam",
                                truongDH = "UEF", chuyennganh="MIS",masv= "79WWWFF"
                },
                new sinhvien(){ ten = "Truong Ngoc Tram", diachi = "Tân Bình, TP HCM", gioitinh="les",
                                truongDH = "UEH",chuyennganh="MIS", masv= "0648GBBFF"
                }

            };
        }

        private List<sinhvien> listSVien = null;




        public void listSV(List<sinhvien> listSV)
        {
            Console.WriteLine("{0, -20} {1, -15} {2, -10} {3, -25} {4, -5} {5,  10}",
           "Ten", "Ma sinh vien", "gioi tinh", "diachi", "CN", "truong");
            var newList = listSV.OrderBy(P => P.ten);
            foreach (sinhvien sv in newList)
            {
                Console.WriteLine("{0, -20} {1, -15} {2, -10} {3, -25} {4, -5} {5, 10}",
                                  sv.ten, sv.masv, sv.gioitinh, sv.diachi, sv.chuyennganh, sv.truongDH);
            }
            Console.WriteLine();
        }
        public List<sinhvien> Getsinhviens()
        {

            return listSVien;
        }

        public override void NhapTT()
        {


            base.NhapTT();
            sinhvien sv = new sinhvien();
            sv.ten = ten;
            sv.gioitinh = gioitinh;
            sv.diachi = diachi;
            Console.Write("Nhap ma sinh vien: ");
            sv.masv = Convert.ToString(Console.ReadLine());
            Console.Write("Chuyen nganh: ");
            sv.chuyennganh = Convert.ToString(Console.ReadLine());
            Console.Write("truong DH: ");
            sv.truongDH = Convert.ToString(Console.ReadLine());
            listSVien.Add(sv);
        }

        public List<sinhvien> FindByName(String keyword)
        {
            List<sinhvien> search = new List<sinhvien>();
            if (listSVien != null && listSVien.Count > 0)
            {
                foreach (sinhvien sv in listSVien)
                {
                    if (sv.ten.ToUpper().Contains(keyword.ToUpper()))
                    {
                        search.Add(sv);
                    }
                }
                Console.WriteLine("{0, -20} {1, -15} {2, -10} {3, -25} {4, -5} {5,  10}",
                                    "Ten", "Ma sinh vien", "gioi tinh", "diachi", "CN", "truong");
                foreach (sinhvien ps in search)
                {
                    Console.WriteLine("{0, -20} {1, -15} {2, -10} {3, -25} {4, -5} {5, 10}",
                                  ps.ten, ps.masv, ps.gioitinh, ps.diachi, ps.chuyennganh, ps.truongDH);
                }
            }
            else
            {
                Console.WriteLine("Danh sách trống!");
            }
            return search;
        }
        public int SoLuongSinhVien()
        {
            int Count = 0;
            if (listSVien != null)
            {
                Count = listSVien.Count;
            }
            return Count;
        }
    }
}
