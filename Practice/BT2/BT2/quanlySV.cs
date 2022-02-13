using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class quanLySV : sinhvien
    {
        public quanLySV() { }
 

        public void listSV(List<Person> listPerson)
        {
            Console.WriteLine("{0, -20} {1, -5} {2, -10} {3, -25} {4, -20} {5, -5} {6,  15}",
                     "Ten", "tuoi", "gioi tinh", "diachi", "truong DH", "CN", "ma SV");

            foreach (Person ps in listPerson)
            {
                if (ps is sinhvien)
                {
                    sinhvien sv = ps as sinhvien;
                    Console.WriteLine("{0, -20} {1, -5} {2, -10} {3, -25} {4, -20} {5, -5} {6, 15}",
                                 sv.ten, sv.tuoi, sv.gioitinh, sv.diachi, sv.truongDH, sv.chuyennganh, sv.masv);
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
                    if (ps.ten.ToUpper().Contains(keyword.ToUpper()) && ps is sinhvien)
                    {
                        sinhvien sv = ps as sinhvien;
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
        public void addNew(sinhvien sv, List<Person> listPS)
        {

            listPS.Add(sv);
        }
        public int SoluongSV(List<Person> listPerson)
        {

            int Count = 0;
            foreach (Person ps in listPerson)
            {
                if (ps is sinhvien)
                {
                    Count++;
                }
            }
            return Count;
        }

    }
}
