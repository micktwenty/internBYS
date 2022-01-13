using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class hocsinh : Person
    {
        private string tenlop { get; set; }
        private string mahs { get; set; }

        public hocsinh()
        {

           
        }

        public void addMem()
        {
            listHS = new List<hocsinh>()
            {
                new hocsinh(){ ten = "Nguyen Quoc Thien", diachi = "TDP2b, Eakar, DakLak", gioitinh="nam", mahs="HS18652", tuoi = 18, tenlop = "12B8"
                },
                new hocsinh(){ ten = "Nguyen Tran Hien Thuc", diachi = "TDP2b, Eakar, DakLak", gioitinh="nu", mahs="HS1867", tuoi = 16, tenlop = "10B8",

                },
                new hocsinh(){ ten = "Truong Quoc Thinh", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nam", mahs="HS1857", tuoi = 22, tenlop = "11b6",

                },
                new hocsinh(){ ten = "Tran Thi Son", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nu", mahs="HS7757", tuoi = 57, tenlop = "11b7",

                },
                new hocsinh(){ ten="Nguyen Van Hoai Nam", diachi = "xa Eadar, Eakar, DakLak", gioitinh="nam", mahs="HS1857", tuoi = 21, tenlop = "12b7",

                },
                new hocsinh(){ ten = "Truong Ngoc Tram", diachi = "Tân Bình, TP HCM", gioitinh="les", mahs="524126ET", tuoi = 25, tenlop = "10E6",
                }

            };
        }

        public List<hocsinh> listHS = null;
      



        public void listHSinh (List<hocsinh> listHS)
        {
            
            Console.WriteLine("{0, -25} {1, -15} {2, -10} {3, -25} {4, -5} {5,  5}",
          "Ten", "Ma hoc sinh", "gioi tinh", "diachi", "ten lop", "tuoi");
            var newList = listHS.OrderBy(P => P.ten);
            foreach (hocsinh hs in newList)
            {
                Console.WriteLine("{0, -25} {1, -15} {2, -10} {3, -25} {4, -5} {5, 5}",
                                  hs.ten, hs.mahs, hs.gioitinh, hs.diachi, hs.tenlop, hs.tuoi);
            }
            Console.WriteLine();
        }
        public List<hocsinh> GetHocsinhs()
        {

            return listHS;
        }
        
        public override void NhapTT()
        {
  

            hocsinh hs = new hocsinh();

            base.NhapTT();
            hs.tuoi = tuoi;
            hs.ten = ten;
            hs.gioitinh = gioitinh;
            hs.diachi = diachi;
            Console.Write("Nhap ma so hoc sinh: ");
            hs.mahs = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap ten lop: ");
            hs.tenlop = Convert.ToString(Console.ReadLine());
      
            

            listHS.Add(hs);
        }

        public List<hocsinh> FindByName(String keyword)
        {
            List<hocsinh> search = new List<hocsinh>();
            if (listHS != null && listHS.Count > 0)
            {
                foreach (hocsinh ps in listHS)
                {
                    if (ps.ten.ToUpper().Contains(keyword.ToUpper()))
                    {
                        search.Add(ps);
                    }
                }

                Console.WriteLine("{0, -25} {1, -15} {2, -10} {3, -25} {4, -5} {5,  5}",
               "Ten", "Ma hoc sinh", "gioi tinh", "diachi", "ten lop", "tuoi");
                foreach (hocsinh ps in search)
                {
                    Console.WriteLine("{0, -25} {1, -15} {2, -10} {3, -25} {4, -5} {5, 5}",
                                  ps.ten, ps.mahs, ps.gioitinh, ps.diachi, ps.tenlop, ps.tuoi);
                }
            }else
            {
                Console.WriteLine("Danh sách trống!");
            }    
            return search;
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

    }
}
