//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFIrstMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public System.DateTime BirthDate { get; set; }
        public Nullable<System.DateTime> SubscribeDate { get; set; }
        public int PlanId { get; set; }
        public bool IsSubscribedToNews { get; set; }
    
        public virtual Plans Plans { get; set; }
    }
}
