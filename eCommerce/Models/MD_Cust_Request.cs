//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eCommerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MD_Cust_Request
    {
        public int ID { get; set; }
        public int MD_ID { get; set; }
        public int Customer_ID { get; set; }
        public int Status_ID { get; set; }
        public int Project_ID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
        public virtual RequestStatus RequestStatus { get; set; }
    }
}