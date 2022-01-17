using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class nghesi:Person
    {
        protected string linhvuc { get; set; }
        protected string khuvuc { get; set; }
        protected string email { get; set; }
      




      

        public override quanLyNS NhapTT()
        {
            quanLyNS ns = new quanLyNS();
            base.NhapTT();
            ns.tuoi = tuoi;
            ns.ten = ten;
            ns.gioitinh = gioitinh;
            ns.diachi = diachi;
            Console.Write("email: ");
            ns.email = Convert.ToString(Console.ReadLine());
            Console.Write("linh vuc hoat dong: ");
            ns.linhvuc = Convert.ToString(Console.ReadLine());
            Console.Write("Khu vuc hoat dong: ");
            ns.khuvuc = Convert.ToString(Console.ReadLine());
            return (ns);
        }

       
    }
    public class quanLyNS : nghesi
    {
        public quanLyNS() { }
        public List<nghesi> listNS = null;
        public void listNSi(List<nghesi> listNS)
        {
            Console.WriteLine("{0, -20} {1, -5} {2, -10} {3, -25} {4, -20} {5, -5} {6,  15}",
                     "Ten", "tuoi", "gioi tinh", "diachi", "email", "linh vuc", "khu vuc");

            foreach (quanLyNS ns in listNS)
            {
                Console.WriteLine("{0, -20} {1, -5} {2, -10} {3, -25} {4, -20} {5, -5} {6, 15}",
                                  ns.ten, ns.tuoi, ns.gioitinh, ns.diachi, ns.email, ns.linhvuc, ns.khuvuc);
            }
            Console.WriteLine();
        }

        public void FindByName(String keyword)
        {
            List<nghesi> search = new List<nghesi>();
            if (listNS != null && listNS.Count > 0)
            {
                foreach (quanLyNS ns in listNS)
                {
                    if (ns.ten.ToUpper().Contains(keyword.ToUpper()))
                    {
                        search.Add(ns);
                    }
                }

                listNSi(search);
            }
            else
            {
                Console.WriteLine("Danh sách trống!");
            }

        }
        public void addNew(nghesi ns)
        {
            listNS.Add(ns);
        }
        public int SoluongNS()
        {
            int Count = 0;
            if (listNS != null)
            {
                Count = listNS.Count;
            }
            return Count;
        }
        public List<nghesi> GetNgheSis()
        {
            return listNS;
        }
        public void addMem()
        {
            listNS = new List<nghesi>()
            {
                new quanLyNS(){ ten = "Nguyen Quoc Thien", diachi = "TDP2b, Eakar, DakLak", gioitinh="nam", tuoi = 18,  email= "ngquthien3520@gmail.com",
                               khuvuc="Mien Nam",linhvuc ="Ca Si"
                },
                new quanLyNS(){ ten = "Nguyen Tran Hien Thuc", diachi = "TDP2b, Eakar, DakLak", gioitinh="nu",tuoi = 16 ,
                                  email= "ngquthien3520@gmail.com", khuvuc="Mien BAC",linhvuc ="NGHE SI HAI"
                },
                new quanLyNS(){ ten = "Truong Quoc Thinh", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nam", tuoi = 22, email= "ngquthien3520@gmail.com",
                               khuvuc="Mien TRUNG",linhvuc ="HAT KICH"
                },
                new quanLyNS(){ ten = "Tran Thi Son", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nu" , tuoi = 57, email= "ngquthien3520@gmail.com",
                                 khuvuc="Mien TRUNG",linhvuc ="HAT CHEO"
                },
                new quanLyNS(){ ten="Nguyen Van Hoai Nam", diachi = "xa Eadar, Eakar, DakLak", gioitinh="nam",  tuoi = 21, email= "ngquthien3520@gmail.com",
                              khuvuc="Mien TRUNG",linhvuc ="HAT BE"
                },
                new quanLyNS(){ ten = "Truong Ngoc Tram", diachi = "Tân Bình, TP HCM", gioitinh="les" , tuoi = 25, email= "ngquthien3520@gmail.com",
                                khuvuc="Mien Nam",linhvuc ="DANCER"
                }
            };
        }
    }
}
