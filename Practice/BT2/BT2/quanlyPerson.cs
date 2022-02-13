using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class quanlyPerson : Person
    {
        public void listPS(List<Person> listPerson)
        {
       
            Console.WriteLine("{0, -25} {1, -25} {2, -10} {3, -10}",
                                  "Ten", " dia chi", "gioi tinh", "tuoi");
  
            foreach (Person ps in listPerson)
            {
                
                
                    Console.WriteLine("{0, -25} {1, -25} {2, -10} {3, -10}",
                                            ps.ten, ps.diachi, ps.gioitinh, ps.tuoi);

            }
        }
    }
}
