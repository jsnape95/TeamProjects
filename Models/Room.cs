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
    
    public partial class Room
    {
        public Room()
        {
            this.Requests = new HashSet<Request>();
            this.Requests1 = new HashSet<Request>();
            this.Facilities = new HashSet<Facility>();
        }
    
        public int roomID { get; set; }
        public string roomName { get; set; }
        public int capacity { get; set; }
        public int buildingID { get; set; }
    
        public virtual Building Building { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<Request> Requests1 { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
    }
}