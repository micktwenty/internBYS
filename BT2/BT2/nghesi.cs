using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class nghesi:Person
    {
        public string linhvuc { get; set; }
        public string khuvuc { get; set; }
        public string email { get; set; }
        public void addMem()
        {
            listNS = new List<nghesi>() {
                new nghesi(){ ten = "Nguyen Quoc Thien", diachi = "TDP2b, Eakar, DakLak", gioitinh="nam", tuoi = 18,  email= "ngquthien3520@gmail.com",
                               khuvuc="Mien Nam",linhvuc ="Ca Si"
                },
                new nghesi(){ ten = "Nguyen Tran Hien Thuc", diachi = "TDP2b, Eakar, DakLak", gioitinh="nu",tuoi = 16 ,
                                  email= "ngquthien3520@gmail.com", khuvuc="Mien BAC",linhvuc ="NGHE SI HAI" 
                },
                new nghesi(){ ten = "Truong Quoc Thinh", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nam", tuoi = 22, email= "ngquthien3520@gmail.com",
                               khuvuc="Mien TRUNG",linhvuc ="HAT KICH" 
                },
                new nghesi(){ ten = "Tran Thi Son", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nu" , tuoi = 57, email= "ngquthien3520@gmail.com",
                                 khuvuc="Mien TRUNG",linhvuc ="HAT CHEO" 
                },
                new nghesi(){ ten="Nguyen Van Hoai Nam", diachi = "xa Eadar, Eakar, DakLak", gioitinh="nam",  tuoi = 21, email= "ngquthien3520@gmail.com",
                              khuvuc="Mien TRUNG",linhvuc ="HAT BE" 
                },
                new nghesi(){ ten = "Truong Ngoc Tram", diachi = "Tân Bình, TP HCM", gioitinh="les" , tuoi = 25, email= "ngquthien3520@gmail.com",
                                khuvuc="Mien Nam",linhvuc ="DANCER" 
                }

            };
        }
  
        private List<nghesi> listNS = null;




        public void listNSi(List<nghesi> listNS)
        {
            Console.WriteLine("{0, -20} {1, -5} {2, -10} {3, -25} {4, -20} {5, -5} {6,  15}",
           "Ten", "tuoi", "gioi tinh", "diachi","email", "linh vuc", "khu vuc");
            var newList = listNS.OrderBy(P => P.ten);
            foreach (nghesi ns in newList)
            {
                Console.WriteLine("{0, -20} {1, -5} {2, -10} {3, -25} {4, -20} {5, -5} {6, 15}",
                                  ns.ten, ns.tuoi, ns.gioitinh, ns.diachi, ns.email, ns.linhvuc, ns.khuvuc);
            }
            Console.WriteLine();
        }
        public List<nghesi> GetNS()
        {

            return listNS;
        }

        public override void NhapTT()
        {


            nghesi ns = new nghesi();

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




            listNS.Add(ns);
        }

        public List<nghesi> FindByName(String keyword)
        {
            List<nghesi> search = new List<nghesi>();
            if (listNS != null && listNS.Count > 0)
            {
                foreach (nghesi ns in listNS)
                {
                    if (ns.ten.ToUpper().Contains(keyword.ToUpper()))
                    {
                        search.Add(ns);
                    }
                }

                Console.WriteLine("{0, -20} {1, -5} {2, -10} {3, -25} {4, -20} {5, -5} {6,  15}",
                                    "Ten", "tuoi", "gioi tinh", "diachi", "email", "linh vuc", "khu vuc");
                foreach (nghesi ps in search)
                {
                    Console.WriteLine("{0, -20} {1, -5} {2, -10} {3, -25} {4, -20} {5, -5} {6, 15}",
                                  ps.ten, ps.tuoi, ps.gioitinh, ps.diachi, ps.email, ps.linhvuc, ps.khuvuc);
                }
            }
            else
            {
                Console.WriteLine("Danh sách trống!");
            }
            return search;
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
    }
}
