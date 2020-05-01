//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEA_Application.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetAssessment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetAssessment()
        {
            this.AspNetAssessment_Topic = new HashSet<AspNetAssessment_Topic>();
            this.AspNetStudent_Assessment = new HashSet<AspNetStudent_Assessment>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Subject_CatalogID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<int> TotalMarks { get; set; }
        public Nullable<int> Weightage { get; set; }
        public string FileName { get; set; }
        public Nullable<bool> AcceptSubmission { get; set; }
        public Nullable<int> SessionID { get; set; }
    
        public virtual AspNetSession AspNetSession { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetAssessment_Topic> AspNetAssessment_Topic { get; set; }
        public virtual AspNetSubject_Catalog AspNetSubject_Catalog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetStudent_Assessment> AspNetStudent_Assessment { get; set; }
    }
}