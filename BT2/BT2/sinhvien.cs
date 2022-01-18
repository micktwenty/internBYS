using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class sinhvien : Person
    {
        public string truongDH { get; set; }
        public string chuyennganh { get; set; }
        public string masv { get; set; }







        public override quanLySV NhapTT()
        {
            quanLySV sv = new quanLySV();
            base.NhapTT();
            sv.tuoi = tuoi;
            sv.ten = ten;
            sv.gioitinh = gioitinh;
            sv.diachi = diachi;
            Console.Write("Truong Dai hoc: ");
            sv.truongDH = Convert.ToString(Console.ReadLine());
            Console.Write("Chuyen nganh: ");
            sv.chuyennganh = Convert.ToString(Console.ReadLine());
            Console.Write("Ma sinh vien: ");
            sv.masv = Convert.ToString(Console.ReadLine());
            return (sv);
        }


    }

}
