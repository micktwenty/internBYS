//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stutdent_Complain_Management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class complain
    {
        public string IdStudent { get; set; }
        public int IdComplains { get; set; }
        public Nullable<int> IdDepartment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ContentType { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string Picture { get; set; }
        public bool status { get; set; }
        public string reply { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Student Student { get; set; }
    }
}