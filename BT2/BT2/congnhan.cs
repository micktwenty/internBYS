using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class congnhan : Person
    {
        private string congviec { get; set; }
        private string honnhan { get; set; }
        private string CCCD { get; set; }

        public void addMem()
        {
            listCN = new List<congnhan>() {
                new congnhan(){ ten = "Nguyen Quoc Thien", diachi = "TDP2b, Eakar, DakLak", gioitinh="nam",CCCD="066200017837", tuoi = 16,
                                honnhan="doc than",congviec="Cong nhan",
                },
                new congnhan(){ ten = "Nguyen Tran Hien Thuc", diachi = "TDP2b, Eakar, DakLak", gioitinh="nu", tuoi = 16,CCCD="241796662",congviec="Cong nhan",
                                honnhan="doc than"
                },
                new congnhan(){ ten = "Truong Quoc Thinh", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nam",  tuoi = 22, CCCD="241794462",congviec="THO CHINH", 
                                honnhan="doc than"
                },
                new congnhan(){ ten = "Tran Thi Son", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nu",tuoi = 57,  CCCD="241796452",congviec="THO PHU",
                                honnhan="da ket hon"
                },
                new congnhan(){ ten="Nguyen Van Hoai Nam", diachi = "xa Eadar, Eakar, DakLak", gioitinh="nam", tuoi = 21, CCCD="27494462", congviec="LAO CONG",
                                honnhan="doc than"
                },
                new congnhan(){ ten = "Truong Ngoc Tram", diachi = "Tân Bình, TP HCM", gioitinh="les",tuoi = 25, CCCD="201794462",congviec="NHAT RAC",
                                honnhan="doc than"
                }

            };
        }

        private List<congnhan> listCN = null;




        public void listCNhan(List<congnhan> listCN)
        {
            Console.WriteLine("{0, -20} {1, -15} {2, -10} {3, -25} {4, -5} {5,  -5}",
           "Ten", " CMND/CCCD", "gioi tinh", "diachi", "cong viec", "tuoi");
            var newList = listCN.OrderBy(P => P.ten);
            foreach (congnhan cn in newList)
            {
                Console.WriteLine("{0, -20} {1, -15} {2, -10} {3, -25} {4, -10} {5, -5}",
                                  cn.ten, cn.CCCD, cn.gioitinh, cn.diachi, cn.congviec, cn.tuoi);
            }
            Console.WriteLine();
        }
        public List<congnhan> GetCNhan()
        {

            return listCN;
        }

        public override void NhapTT()
        {


            congnhan cn = new congnhan();

            base.NhapTT();
            cn.tuoi = tuoi;
            cn.ten = ten;
            cn.gioitinh = gioitinh;
            cn.diachi = diachi;
            Console.Write("Nhap CMND/CCCD: ");
            cn.CCCD = Convert.ToString(Console.ReadLine());
            Console.Write("Nghe nghiep: ");
            cn.congviec = Convert.ToString(Console.ReadLine());



            listCN.Add(cn);
        }

        public List<congnhan> FindByName(String keyword)
        {
            List<congnhan> search = new List<congnhan>();
            if (listCN != null && listCN.Count > 0)
            {
                foreach (congnhan ns in listCN)
                {
                    if (ns.ten.ToUpper().Contains(keyword.ToUpper()))
                    {
                        search.Add(ns);
                    }
                }
                Console.WriteLine("{0, -20} {1, -15} {2, -10} {3, -25} {4, -5} {5,  -5}",
                                      "Ten", " CMND/CCCD", "gioi tinh", "diachi", "cong viec", "tuoi");
                foreach (congnhan ps in search)
                {
                    Console.WriteLine("{0, -20} {1, -15} {2, -10} {3, -25} {4, -5} {5, -5}",
                                  ps.ten, ps.CCCD, ps.gioitinh, ps.diachi, ps.congviec, ps.tuoi);
                }
            }
            else
            {
                Console.WriteLine("Danh sách trống!");
            }
            return search;
        }
        public int SoluongCN()
        {
            int Count = 0;
            if (listCN != null)
            {
                Count = listCN.Count;
            }
            return Count;
        }

    }
}
