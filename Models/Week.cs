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
    
    public partial class Week
    {
        public Week()
        {
            this.Requests = new HashSet<Request>();
        }
    
        public int weekID { get; set; }
        public int week1 { get; set; }
        public int week2 { get; set; }
        public int week3 { get; set; }
        public int week4 { get; set; }
        public int week5 { get; set; }
        public int week6 { get; set; }
        public int week7 { get; set; }
        public int week8 { get; set; }
        public int week9 { get; set; }
        public int week10 { get; set; }
        public int week11 { get; set; }
        public int week12 { get; set; }
        public int week13 { get; set; }
        public int week14 { get; set; }
        public int week15 { get; set; }
    
        public virtual ICollection<Request> Requests { get; set; }
    }
}
