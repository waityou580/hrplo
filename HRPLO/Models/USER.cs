//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRPLO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            this.USER_GROUP = new HashSet<USER_GROUP>();
        }
    
        public string USER_NO { get; set; }
        public string USER_NAME { get; set; }
        public string USER_PASS { get; set; }
        public Nullable<bool> PRI_SEE { get; set; }
        public Nullable<bool> PRI_CRE { get; set; }
        public Nullable<bool> PRI_EDT { get; set; }
        public Nullable<bool> PRI_DEL { get; set; }
        public Nullable<bool> PRI_IMP { get; set; }
        public Nullable<bool> PRI_EXP { get; set; }
        public string LOGIN_TIME { get; set; }
        public string DO_USERS { get; set; }
        public string DO_TIME { get; set; }
        public Nullable<bool> IS_ACT { get; set; }
        public Nullable<int> LOGIN_FALSE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_GROUP> USER_GROUP { get; set; }
    }
}
