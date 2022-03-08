using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stutdent_Complain_Management.Models
{


    [Table("Accounts")]
    public class Users
    {
        public string username { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        public int role { get; set; }
        public bool Actived { get; set; }

    }
}