using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class hocsinh : Person
    {
        public string tenlop { get; set; }
        public string mahs { get; set; }
        public override quanLyHS NhapTT()
        {
            quanLyHS hs = new quanLyHS();
            base.NhapTT();
            hs.tuoi = tuoi;
            hs.ten = ten;
            hs.gioitinh = gioitinh;
            hs.diachi = diachi;
            Console.Write("Nhap ma so hoc sinh: ");
            hs.mahs = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap ten lop: ");
            hs.tenlop = Convert.ToString(Console.ReadLine());
            return hs;
        } 
    }

}
