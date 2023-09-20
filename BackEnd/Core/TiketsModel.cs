using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Core
{
    public class TiketsModel
    {
        public int Id { get; set; }
        public string FrmUserName { get; set; }
        public string FrmDepartment { get; set; }
        public string ToDepartment { get; set; }
        public bool IsActive { get; set; }
        public string State { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Discreption { get; set; }
        public string Per { get; set; }

    }
}
