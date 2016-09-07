namespace HRPLO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USER_GROUP
    {
        [Key]
        [StringLength(50)]
        public string UG_NO { get; set; }

        [StringLength(50)]
        public string UG_NAME { get; set; }

        public bool? PRI_SEE { get; set; }

        public bool? PRI_CRE { get; set; }

        public bool? PRI_EDT { get; set; }

        public bool? PRI_DEL { get; set; }

        public bool? PRI_IMP { get; set; }

        public bool? PRI_EXP { get; set; }

        [StringLength(50)]
        public string DO_USERS { get; set; }

        [StringLength(50)]
        public string DO_TIME { get; set; }

        public bool? IS_ACT { get; set; }
    }
}
