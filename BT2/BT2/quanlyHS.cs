using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class quanLyHS : hocsinh
    {



        public void listHSinh(List<Person> People)
        {
            Console.WriteLine("{0, -25} {1, -15} {2, -10} {3, -25} {4, -5} {5,  5}",
          "Ten", "Ma hoc sinh", "gioi tinh", "diachi", "ten lop", "tuoi");

            foreach (Person ps in People)
            {
                if (ps is hocsinh)
                {
                    hocsinh hs = ps as hocsinh;
                    Console.WriteLine("{0, -25} {1, -15} {2, -10} {3, -25} {4, -5} {5, 5}",
                                    hs.ten, hs.mahs, hs.gioitinh, hs.diachi, hs.tenlop, hs.tuoi);
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
                    if (ps.ten.ToUpper().Contains(keyword.ToUpper()) && ps is hocsinh)
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

        public void addNew(hocsinh hs, List<Person> listPS)
        {   
            
            listPS.Add(hs);
        }
        public int SoluongHS(List<Person> listPerson)
        {
            int Count = 0;
            foreach (Person ps in listPerson)
            {
                if (ps is hocsinh)
                {
                    Count++;
                }
            }
            return Count;
        }
    }
}
