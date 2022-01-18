using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class Person
    {
        public string ten { get; set; }
        public string gioitinh { get; set; }
        public int tuoi { get; set; }
        public string diachi { get; set; }

        public List<Person> listPerson = null ;
        public void addMem()
        {
            listPerson = new List<Person>()
            {
                new sinhvien{ ten = "Nguyen Quoc Thien", diachi = "TDP2b, Eakar, DakLak", gioitinh="nam", tuoi = 18,  truongDH= "DUE",
                               chuyennganh="MIS",masv ="1811256974"
                },
                new sinhvien(){ ten = "Nguyen Tran Hien Thuc", diachi = "TDP2b, Eakar, DakLak", gioitinh="nu",tuoi = 16 ,
                                  truongDH= "DUE", chuyennganh="MIS",masv ="1811256974"
                },
                new congnhan(){ ten = "Truong Quoc Thinh", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nam",  tuoi = 22, CCCD="241794462",congviec="THO CHINH",
                                honnhan="doc than"
                },
                new congnhan(){ ten = "Tran Thi Son", diachi = "thon 1a, Cư ni, DakLak", gioitinh="nu",tuoi = 57,  CCCD="241796452",congviec="THO PHU",
                                honnhan="da ket hon"
                },

                 new hocsinh(){ ten="Nguyen Van Hoai Nam", diachi = "xa Eadar, Eakar, DakLak", gioitinh="nam", mahs="HS1857", tuoi = 21, tenlop = "12b7",

                },
                new hocsinh(){ ten = "Truong Ngoc Tram", diachi = "Tân Bình, TP HCM", gioitinh="les", mahs="524126ET", tuoi = 25, tenlop = "10E6",
                },
                new nghesi(){ ten="Kim Phuong", diachi = "xa Eadar, Eakar, DakLak", gioitinh="nam",  tuoi = 21, email= "ngquthien3520@gmail.com",
                              khuvuc="Mien TRUNG",linhvuc ="HAT BE"
                },
                new nghesi(){ ten = "Cong Minh", diachi = "Tân Bình, TP HCM", gioitinh="les" , tuoi = 25, email= "ngquthien3520@gmail.com",
                                khuvuc="Mien Nam",linhvuc ="DANCER"
                }
            };


        }
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
