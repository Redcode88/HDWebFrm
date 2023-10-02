namespace EntityCoreDB.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string FrmUserName { get; set; }

        [StringLength(50)]
        public string FrmDepartment { get; set; }

        [StringLength(50)]
        public string ToDepartment { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string Discreption { get; set; }

        [StringLength(50)]
        public string Per { get; set; }

        public Guid? IdFlag { get; set; }
    }
}
