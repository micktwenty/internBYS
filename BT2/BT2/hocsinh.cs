using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class hocsinh : Person
    {
        protected string tenlop { get; set; }
        protected string mahs { get; set; }
        public override quanLyHS NhapTT()
        {
            quanLyHS hs = new quanLyHS();
            base.NhapTT();
            hs.tuoi = tuoi;
            hs.ten = ten;
            hs.gioitinh = gioitinh;
            hs.diachi = diachi;
            Console.Write("Nhap ma so hoc sinh: ");
            hs.mahs = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap ten lop: ");
            hs.tenlop = Convert.ToString(Console.ReadLine());
            return hs;
        }

     
       
       
    }
    public class quanLyHS : hocsinh
    {
        public quanLyHS() { }
        public List<hocsinh> listHS = null;
        public void listHSinh(List<hocsinh> listHS)
        {

            Console.WriteLine("{0, -25} {1, -15} {2, -10} {3, -25} {4, -5} {5,  5}",
          "Ten", "Ma hoc sinh", "gioi tinh", "diachi", "ten lop", "tuoi");
            foreach (quanLyHS hs in listHS)
            {
                Console.WriteLine("{0, -25} {1, -15} {2, -10} {3, -25} {4, -5} {5, 5}",
                                  hs.ten, hs.mahs, hs.gioitinh, hs.diachi, hs.tenlop, hs.tuoi);
            }
            Console.WriteLine();
        }

        public void FindByName(String keyword)
        {
            List<hocsinh> search = new List<hocsinh>();
            if (listHS != null && listHS.Count > 0)
            {
                foreach (quanLyHS ps in listHS)
                {
                    if (ps.ten.ToUpper().Contains(keyword.ToUpper()))
                    {
                        search.Add(ps);
                    }
                }

                listHSinh(search);
            }
            else
            {
                Console.WriteLine("Danh sách trống!");
            }
          
        }
        public List<hocsinh> GetHSs()
        {
            return listHS;
        }
        public void addNew(hocsinh hs)
        {
            listHS.Add(hs);
        }
        public int SoluongHS()
        {
            int Count = 0;
            if (listHS != null)
            {
                Count = listHS.Count;
            }
            return Count;
        }
        public void addMem()
        {
            listHS = new List<hocsinh>()
            {
                new quanLyHS(){ ten = "Nguyen Quoc Thien", diachi = "TDP2b, Eakar, DakLak", gioitinh="nam", mahs="HS18652", tuoi = 18, tenlop = "12B8"
                },
                new quanLyHS(){ ten = "Nguyen Tran Hien Thuc", diachi = "TDP2b, Eakar, DakLak", gioitinh="nu", mahs="HS1867", tuoi = 16, tenlop = "10B8",

                },
                new quanLyHS(){ ten = "Truong Quoc Thinh", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nam", mahs="HS1857", tuoi = 22, tenlop = "11b6",

                },
                new quanLyHS(){ ten = "Tran Thi Son", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nu", mahs="HS7757", tuoi = 57, tenlop = "11b7",

                },
                new quanLyHS(){ ten="Nguyen Van Hoai Nam", diachi = "xa Eadar, Eakar, DakLak", gioitinh="nam", mahs="HS1857", tuoi = 21, tenlop = "12b7",

                },
                new quanLyHS(){ ten = "Truong Ngoc Tram", diachi = "Tân Bình, TP HCM", gioitinh="les", mahs="524126ET", tuoi = 25, tenlop = "10E6",
                }

            };
        }
    }
}
