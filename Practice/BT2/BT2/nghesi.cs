using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class nghesi: Person
    {
        public string linhvuc { get; set; }
        public string khuvuc { get; set; }
        public string email { get; set; }
      




      

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

}
