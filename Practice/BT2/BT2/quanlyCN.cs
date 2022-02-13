using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class quanLyCN : congnhan
    {
        public quanLyCN() { }


        public void listCN(List<Person> listPerson)
        {
            Console.WriteLine("{0, -20} {1, -15} {2, -10} {3, -25} {4, -5} {5,  -5}",
                                     "Ten", " CMND/CCCD", "gioi tinh", "diachi", "cong viec", "tuoi");

            foreach (Person ps in listPerson)
            {
                if (ps is congnhan)
                {
                    congnhan cn = ps as congnhan;
                    Console.WriteLine("{0, -20} {1, -15} {2, -10} {3, -25} {4, -5} {5, -5}",
                                            cn.ten, cn.CCCD, cn.gioitinh, cn.diachi, cn.congviec, cn.tuoi);
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
                    if (ps.ten.ToUpper().Contains(keyword.ToUpper()) && ps is congnhan)
                    {
                        congnhan cn = ps as congnhan;
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
        public void addNew(congnhan cn, List<Person> listPS)
        {

            listPS.Add(cn);
        }
        public int SoluongCN( List<Person> listPerson)
        {
            int Count = 0;
            foreach (Person ps in listPerson)
            {
                if (ps is congnhan)
                {
                    Count++;
                }
            }
            return Count;
        }

    }
}

