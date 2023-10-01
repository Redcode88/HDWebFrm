using BackEnd.Repo;
using DevExpress.Web;
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
        string conn = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;

        //Grd.Columns.Clear();
        //var data = TicketRepsitory.GetTikByDept(UserName);
        //Grd.DataSource = data;
        //Grd.DataBind();

        protected void Page_Load(object sender, EventArgs e)
        {

           
            if (Session["UserName"] != null)
            {
                UserName = Session["UserName"].ToString();
            }

            else
            {
                Response.Redirect("LoginPage.aspx");
            }

            var data = TicketRepsitory.GetTikByDept(UserName);
            Grd.DataSource = data;
            Grd.DataBind();

            //using (SqlConnection cn = new SqlConnection(conn))
            //{

            //    if (cn.State != ConnectionState.Open)
            //    {
            //        cn.Open();
            //    }


            //    SqlCommand cmd = new SqlCommand("[dbo].[GetByDept]", cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@FrmUserName", UserName);
            //    DataSet ds = new DataSet();
            //    SqlDataAdapter da = new SqlDataAdapter();
            //    da.SelectCommand = cmd;
            //    da.Fill(ds, "nn");
            //    da.SelectCommand.ExecuteScalar();
            //    Grd.DataSource = ds;
            //    Grd.DataBind();


            //}



        }




    }
}