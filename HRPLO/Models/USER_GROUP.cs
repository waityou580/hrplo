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
    
    public partial class USER_GROUP
    {
        public string UG_NO { get; set; }
        public string UG_NAME { get; set; }
        public Nullable<bool> PRI_SEE { get; set; }
        public Nullable<bool> PRI_CRE { get; set; }
        public Nullable<bool> PRI_EDT { get; set; }
        public Nullable<bool> PRI_DEL { get; set; }
        public Nullable<bool> PRI_IMP { get; set; }
        public Nullable<bool> PRI_EXP { get; set; }
        public string DO_USERS { get; set; }
        public string DO_TIME { get; set; }
        public Nullable<bool> IS_ACT { get; set; }
        public string USER_NO { get; set; }
    
        public virtual USER USER { get; set; }
    }
}
