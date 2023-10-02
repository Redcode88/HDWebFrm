namespace EntityCoreDB.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TicketState")]
    public partial class TicketState
    {
        [Key]
        public int St_Id { get; set; }

        [StringLength(50)]
        public string StateName { get; set; }
    }
}
