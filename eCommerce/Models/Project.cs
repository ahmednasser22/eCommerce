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
    using System.ComponentModel.DataAnnotations;

    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            this.Employee_Request = new HashSet<Employee_Request>();
            this.MD_Cust_Request = new HashSet<MD_Cust_Request>();
            this.MT_Evaluation = new HashSet<MT_Evaluation>();
            this.ProjectModule = new HashSet<ProjectModule>();
            this.WorksOn = new HashSet<WorksOn>();
        }
    
        public int ID { get; set; }
        [Required(ErrorMessage = "Description is Requierd.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter valid Description.")]
        public string Description { get; set; }
        public int Approval_ID { get; set; }
        public int Customer_ID { get; set; }
        [Required(ErrorMessage = "Project Title is Requierd.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter valid Title.")]
        public string ProjectTitle { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Request> Employee_Request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MD_Cust_Request> MD_Cust_Request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MT_Evaluation> MT_Evaluation { get; set; }
        public virtual RequestStatus RequestStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectModule> ProjectModule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorksOn> WorksOn { get; set; }
    }
}