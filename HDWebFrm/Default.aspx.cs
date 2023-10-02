using BackEnd.Repo;
using DevExpress.Web;
using EntityCoreDB.DAL;
using EntityCoreDB.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HDWebFrm
{
    public partial class _Default : Page
    {
        public string UserName;
        private TicketGrid _Service;
        
        protected void Page_Load(object sender, EventArgs e)
        {
             _Service = new TicketGrid(new dbcon());  
              GrdInital();

        }

        public void GrdInital()
        {

            if (Session["UserName"] != null)
            {
                UserName = Session["UserName"].ToString();
            }

            else
            {
                Response.Redirect("LoginPage.aspx");
            }

           // 
            var Result = _Service.GetAllUserTicket(UserName);
            Grd.DataSource = Result;
            Grd.DataBind();
        }


       
    }
}