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
        protected string gioitinh { get; set; }
        protected int tuoi { get; set; }
        protected string diachi { get; set; }
        

        public virtual void NhapTT()
        {
            Console.Write("Ho va ten: ");
            this.ten = Convert.ToString(Console.ReadLine());
            Console.Write("Gioi tinh: ");
            this.gioitinh = Convert.ToString(Console.ReadLine());
            Console.Write("Tuoi: ");
            this.tuoi = Int32.Parse(Console.ReadLine());
            Console.Write("Dia chi: ");
            this.diachi = Convert.ToString(Console.ReadLine());
        }


    }
}
