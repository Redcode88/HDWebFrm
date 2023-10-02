namespace EntityCoreDB.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Department
    {
        [Key]
        public int DeptId { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }
    }
}
