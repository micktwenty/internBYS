using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stutdent_Complain_Management.Models
{
    public class Complains
    {
        public string IdStudent { get; set; }
        public int IdComplains { get; set; }
        public int IdDepartment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ContentType { get; set; }
        public DateTime date { get; set; }
        public string picture { get; set; }
        public bool status { get; set; }
        public string reply { get; set; }
    }
    public class lstCln
    {

        [Display(Name ="Mã phản ánh")]
        public int IdComplains { get; set; }
        [Display(Name = "Khoa phản ánh")]
        public string name { get; set; }
        [Display(Name ="Tiêu đề")]
        public string title { get; set; }
        [Display(Name ="Trạng thái")]
        public bool status { get; set; }
    }
    public class Detail_Complains
    {
        public string name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ContentType { get; set; }
        public DateTime date { get; set; }
        public string picture { get; set; }
        public bool status { get; set; }
        public string reply { get; set; }
    }
}