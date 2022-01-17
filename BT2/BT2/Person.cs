using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class Person
    {
        protected string ten { get; set; }
        public string gioitinh { get; set; }
        public int tuoi { get; set; }
        public string diachi { get; set; }
        

        public virtual Person NhapTT()
        {
            Console.Write("Ho va ten: ");
            this.ten = Convert.ToString(Console.ReadLine());
            Console.Write("Gioi tinh: ");
            this.gioitinh = Convert.ToString(Console.ReadLine());
            Console.Write("Tuoi: ");
            this.tuoi = Int32.Parse(Console.ReadLine());
            Console.Write("Dia chi: ");
            this.diachi = Convert.ToString(Console.ReadLine());
            return this;
        }


    }
}
