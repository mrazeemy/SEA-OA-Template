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
    
    public partial class AspNetSubject_Catalog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetSubject_Catalog()
        {
            this.AspNetAssessments = new HashSet<AspNetAssessment>();
        }
    
        public int Id { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public Nullable<int> CatalogID { get; set; }
        public Nullable<int> Weightage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetAssessment> AspNetAssessments { get; set; }
        public virtual AspNetCatalog AspNetCatalog { get; set; }
        public virtual AspNetSubject AspNetSubject { get; set; }
    }
}
