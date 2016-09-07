namespace HRPLO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERS")]
    public partial class USER
    {
        [Key]
        [StringLength(50)]
        public string USER_NO { get; set; }

        [StringLength(50)]
        public string USER_NAME { get; set; }

        [StringLength(50)]
        public string USER_PASS { get; set; }

        public bool? PRI_SEE { get; set; }

        public bool? PRI_CRE { get; set; }

        public bool? PRI_EDT { get; set; }

        public bool? PRI_DEL { get; set; }

        public bool? PRI_IMP { get; set; }

        public bool? PRI_EXP { get; set; }

        [StringLength(50)]
        public string LOGIN_TIME { get; set; }

        [StringLength(50)]
        public string DO_USERS { get; set; }

        [StringLength(50)]
        public string DO_TIME { get; set; }

        public bool? IS_ACT { get; set; }
    }
}
