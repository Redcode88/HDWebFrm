using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace BackEnd.Middelware
{
    public class TicketSeting
    {

      
        public int Id { get; set; }
       // public string FrmUserName { get; set; }
        public string ToDepartment { get; set; }
        public string State { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Discreption { get; set; }
        public string Periorty { get; set; }
        public string Edit { get; set; }

        

    }
}
