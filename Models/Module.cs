//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamProjects.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Module
    {
        public string moduleCode { get; set; }
        public string moduleTitle { get; set; }
        public int userID { get; set; }
        public int moduleID { get; set; }
    
        public virtual User User { get; set; }
    }
}
