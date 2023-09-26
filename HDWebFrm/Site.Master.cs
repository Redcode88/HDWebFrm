using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HDWebFrm
{
    public partial class SiteMaster : MasterPage
    {
        public string UserName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["UserName"] != null)
            {
                UserName = Session["UserName"].ToString();
            }
            CheckUserState();
        }

        protected void LnkCreateUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CreateUser.aspx");
        }

        protected void LnkLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LoginPage.aspx");
        }


       
        public void CheckUserState()
        {

            if (!IsPostBack)
            {
              if (!HttpContext.Current.User.Identity.IsAuthenticated)
                    {
                        LnkCreateUsers.Visible = true;
                        LnkLogin.Visible = true;
                        LnkLogOut.Visible = false;
               
                    }
                    else
                    {

                        LnkLogin.Visible = false;
                        LnkCreateUsers.Visible = false;
                        LnkLogOut.Visible = true;
                    }
            }

          

        }


        protected void LnkLogOut_Click(object sender, EventArgs e)
        {
            //LogOut from system
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/LoginPage.aspx");
            
        }



    }
}