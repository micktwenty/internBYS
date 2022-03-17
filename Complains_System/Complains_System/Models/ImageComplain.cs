using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Models
{
    [Table("ImageComplain")]
    public class ImageComplain
    {
        public int id { get; set; }
        public string content_image { get; set; }
        public string Path_image { get; set; }
        public int IdComplain { get; set; }
        public int filesize { get; set; }
        //public int sortOrder { get; set; }
        public  Complain complain { get; set; }

    }
}
