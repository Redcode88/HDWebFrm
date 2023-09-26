using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HDWebFrm
{
    public partial class CreateRoll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LblResult.Text = "";
            }
        }

       

        protected void btn_cr_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Roll.Text))
            {
                if (!Roles.RoleExists(Txt_Roll.Text))
                {
                    Roles.CreateRole(Txt_Roll.Text);
                    LblResult.Text = "Role created successfully";
                }
                else
                {
                    LblResult.Text = "Role already exists";
                }
            }
        }
    }
}