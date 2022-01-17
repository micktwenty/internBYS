using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class sinhvien : Person
    {
        protected string truongDH { get; set; }
        protected string chuyennganh { get; set; }
        protected string masv { get; set; }







        public override quanLySV NhapTT()
        {
            quanLySV sv = new quanLySV();
            base.NhapTT();
            sv.tuoi = tuoi;
            sv.ten = ten;
            sv.gioitinh = gioitinh;
            sv.diachi = diachi;
            Console.Write("Truong Dai hoc: ");
            sv.truongDH = Convert.ToString(Console.ReadLine());
            Console.Write("Chuyen nganh: ");
            sv.chuyennganh = Convert.ToString(Console.ReadLine());
            Console.Write("Ma sinh vien: ");
            sv.masv = Convert.ToString(Console.ReadLine());
            return (sv);
        }


    }
    public class quanLySV : sinhvien
    {
        public quanLySV() { }
        public List<sinhvien> listSvien = null;
        public void listSV(List<sinhvien> listSvien)
        {
            Console.WriteLine("{0, -20} {1, -5} {2, -10} {3, -25} {4, -20} {5, -5} {6,  15}",
                     "Ten", "tuoi", "gioi tinh", "diachi", "truong DH", "CN", "ma SV");

            foreach (quanLySV ns in listSvien)
            {
                Console.WriteLine("{0, -20} {1, -5} {2, -10} {3, -25} {4, -20} {5, -5} {6, 15}",
                                  ns.ten, ns.tuoi, ns.gioitinh, ns.diachi, ns.truongDH, ns.chuyennganh, ns.masv);
            }
            Console.WriteLine();
        }

        public void FindByName(String keyword)
        {
            List<sinhvien> search = new List<sinhvien>();
            if (listSvien != null && listSvien.Count > 0)
            {
                foreach (quanLySV sv in listSvien)
                {
                    if (sv.ten.ToUpper().Contains(keyword.ToUpper()))
                    {
                        search.Add(sv);
                    }
                }

                listSV(search);
            }
            else
            {
                Console.WriteLine("Danh sách trống!");
            }

        }
        public void addNew(sinhvien sv)
        {
            listSvien.Add(sv);
        }
        public int SoluongSV()
        {
            int Count = 0;
            if (listSvien != null)
            {
                Count = listSvien.Count;
            }
            return Count;
        }
        public List<sinhvien> GetSinhViens()
        {
            return listSvien;
        }
        public void addMem()
        {
            listSvien = new List<sinhvien>()
            {
                new quanLySV(){ ten = "Nguyen Quoc Thien", diachi = "TDP2b, Eakar, DakLak", gioitinh="nam", tuoi = 18,  truongDH= "DUE",
                               chuyennganh="MIS",masv ="1811256974"
                },
                new quanLySV(){ ten = "Nguyen Tran Hien Thuc", diachi = "TDP2b, Eakar, DakLak", gioitinh="nu",tuoi = 16 ,
                                  truongDH= "DUE", chuyennganh="MIS",masv ="1811256974"
                },
                new quanLySV(){ ten = "Truong Quoc Thinh", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nam", tuoi = 22, truongDH= "DUE",
                               chuyennganh="MIS",masv ="1811256974"
                },
                new quanLySV(){ ten = "Tran Thi Son", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nu" , tuoi = 57, truongDH= "DUE",
                                 chuyennganh="MIS",masv ="1811256974"
                },
                new quanLySV(){ ten="Nguyen Van Hoai Nam", diachi = "xa Eadar, Eakar, DakLak", gioitinh="nam",  tuoi = 21, truongDH= "DUE",
                              chuyennganh="MIS",masv ="1811256974"
                },
                new quanLySV(){ ten = "Truong Ngoc Tram", diachi = "Tân Bình, TP HCM", gioitinh="les" , tuoi = 25, truongDH= "DUE",
                                chuyennganh="MIS",masv ="1811256974"
                }
            };
        }
    }
}
