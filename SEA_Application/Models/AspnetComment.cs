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
    
    public partial class AspnetComment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspnetComment()
        {
            this.AspnetComments1 = new HashSet<AspnetComment>();
        }
    
        public int Id { get; set; }
        public Nullable<int> HeadId { get; set; }
        public Nullable<int> ParentCommentId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual AspnetComment_Head AspnetComment_Head { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspnetComment> AspnetComments1 { get; set; }
        public virtual AspnetComment AspnetComment1 { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
