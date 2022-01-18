using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class quanLyNS : nghesi
    {
        public quanLyNS() { }


        public void listNSi(List<Person> listPerson)
        {
            Console.WriteLine("{0, -20} {1, -5} {2, -10} {3, -25} {4, -20} {5, -5} {6,  15}",
                     "Ten", "tuoi", "gioi tinh", "diachi", "email", "linh vuc", "khu vuc");

            foreach (Person ps in listPerson)
            {
                if (ps is nghesi)
                {
                    nghesi ns = ps as nghesi;
                    Console.WriteLine("{0, -20} {1, -5} {2, -10} {3, -25} {4, -20} {5, -5} {6, 15}",
                                  ns.ten, ns.tuoi, ns.gioitinh, ns.diachi, ns.email, ns.linhvuc, ns.khuvuc);
                }

            }
        }

        public void FindByName(String keyword, List<Person> listPerson)
        {
            List<Person> search = new List<Person>();
            if (listPerson != null && listPerson.Count > 0)
            {
                foreach (Person ps in listPerson)
                {
                    if (ps.ten.ToUpper().Contains(keyword.ToUpper()) && ps is nghesi)
                    {
                        nghesi ns = ps as nghesi;
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
        public void addNew(nghesi ns ,List<Person> listPS)
        {

            listPS.Add(ns);
        }
        public int SoluongNS(List<Person> listPerson)
        {
            int Count = 0;
            foreach (Person ps in listPerson)
            {
                if (ps is nghesi)
                {
                    Count++;
                }
            }
            return Count;
        }
    }
}
