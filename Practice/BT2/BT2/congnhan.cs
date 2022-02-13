using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class congnhan : Person
    {
       
        
        public string congviec { get; set; }
        public string honnhan { get; set; }
        public string CCCD { get; set; }

      
        public override quanLyCN NhapTT()
        {
            quanLyCN cn = new quanLyCN();
            base.NhapTT();
            cn.tuoi = tuoi;
            cn.ten = ten;
            cn.gioitinh = gioitinh;
            cn.diachi = diachi;
            Console.Write("Nhap CMND/CCCD: ");
            cn.CCCD = Convert.ToString(Console.ReadLine());
            Console.Write("Nghe nghiep: ");
            cn.congviec = Convert.ToString(Console.ReadLine());
            return cn;
        }

      
    }
}
