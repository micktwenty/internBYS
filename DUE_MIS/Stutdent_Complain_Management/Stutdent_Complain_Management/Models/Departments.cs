using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stutdent_Complain_Management.Models
{

    public class Departments
    {


        public int id { get; set; }
        public string name { get; set; }
        public int totalstudent { get; set; }
        public int totalemployee { get; set; }
        public string phone { get; set; }
    }

}