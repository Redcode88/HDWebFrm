namespace EntityCoreDB.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TicketDocument
    {
        public int Id { get; set; }

        public string DocumentUrl { get; set; }

        public Guid? IdGuid { get; set; }
    }
}
