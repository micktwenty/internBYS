using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class congnhan : Person
    {
        protected string congviec { get; set; }
        protected string honnhan { get; set; }
        protected string CCCD { get; set; }

      
        public override quanLyCN NhapTT()
        {
            quanLyCN cn = new quanLyCN();
            base.NhapTT();
            cn.tuoi = tuoi;
            cn.ten = ten;
            cn.gioitinh = gioitinh;
            cn.diachi = diachi;
            Console.Write("Nhap CMND/CCCD: ");
            cn.CCCD = Convert.ToString(Console.ReadLine());
            Console.Write("Nghe nghiep: ");
            cn.congviec = Convert.ToString(Console.ReadLine());
            return cn;
        }

      
    }
    public class quanLyCN : congnhan
    {
        public quanLyCN() { }
        public List<congnhan> listCNhan = null;
        public void listCN(List<congnhan> listCNhan)
        {
            Console.WriteLine("{0, -20} {1, -15} {2, -10} {3, -25} {4, -5} {5,  -5}",
                                     "Ten", " CMND/CCCD", "gioi tinh", "diachi", "cong viec", "tuoi");

            foreach (quanLyCN cn in listCNhan)
            {
                Console.WriteLine("{0, -20} {1, -15} {2, -10} {3, -25} {4, -5} {5, -5}",
                                   cn.ten, cn.CCCD, cn.gioitinh, cn.diachi, cn.congviec, cn.tuoi);
            }
            Console.WriteLine();
        }

        public void FindByName(String keyword)
        {
            List<congnhan> search = new List<congnhan>();
            if (listCNhan != null && listCNhan.Count > 0)
            {
                foreach (quanLyCN cn in listCNhan)
                {
                    if (cn.ten.ToUpper().Contains(keyword.ToUpper()))
                    {
                        search.Add(cn);
                    }
                }

                listCN(search);
            }
            else
            {
                Console.WriteLine("Danh sách trống!");
            }

        }
        public void addNew(congnhan cn)
        {
            listCNhan.Add(cn);
        }
        public int SoluongCN()
        {
            int Count = 0;
            if (listCNhan != null)
            {
                Count = listCNhan.Count;
            }
            return Count;
        }
        public List<congnhan> Getcongnhans()
        {
            return listCNhan;
        }
        public void addMem()
        {
            listCNhan = new List<congnhan>()
            {
                new quanLyCN(){ ten = "Nguyen Quoc Thien", diachi = "TDP2b, Eakar, DakLak", gioitinh="nam",CCCD="066200017837", tuoi = 16,
                                honnhan="doc than",congviec="Cong nhan",
                },
                new quanLyCN(){ ten = "Nguyen Tran Hien Thuc", diachi = "TDP2b, Eakar, DakLak", gioitinh="nu", tuoi = 16,CCCD="241796662",congviec="Cong nhan",
                                honnhan="doc than"
                },
                new quanLyCN(){ ten = "Truong Quoc Thinh", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nam",  tuoi = 22, CCCD="241794462",congviec="THO CHINH",
                                honnhan="doc than"
                },
                new quanLyCN(){ ten = "Tran Thi Son", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nu",tuoi = 57,  CCCD="241796452",congviec="THO PHU",
                                honnhan="da ket hon"
                },
                new quanLyCN(){ ten="Nguyen Van Hoai Nam", diachi = "xa Eadar, Eakar, DakLak", gioitinh="nam", tuoi = 21, CCCD="27494462", congviec="LAO CONG",
                                honnhan="doc than"
                },
                new quanLyCN(){ ten = "Truong Ngoc Tram", diachi = "Tân Bình, TP HCM", gioitinh="les",tuoi = 25, CCCD="201794462",congviec="NHAT RAC",
                                honnhan="doc than"
                }
            };
        }
    }
}
