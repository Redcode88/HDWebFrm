using BackEnd.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HDWebFrm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TicketRepsitory.FillCombo(Combo_FromDeptSe, "[dbo].[GetALLDept]", "DepartmentName", "DepartmentName");
            }

        }

        

        protected void Combo_FromDeptSe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                Grd.Columns.Clear();
                var data = TicketRepsitory.GetTikByDept(Combo_FromDeptSe.SelectedItem.Value);
                Grd.DataSource = data;
                Grd.DataBind();
            
            
           
        }
    }
}