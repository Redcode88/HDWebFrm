using BackEnd.Core;
using BackEnd.DataConfig;
using BackEnd.Middelware;
using EntityCoreDB.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace BackEnd.Repo
{
    public static class TicketRepsitory
    {
        //get data connection from XML file 
        private static string conn =
        ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;

        public static dynamic GetFromDept(string DepartmentName)
        {

            SqlParameter param = new SqlParameter("DepartmentName", DepartmentName);
            SQLDAL.ConnectionString = conn;
            return SQLDAL.ReturnDataTableByProcedure("[dbo].[GetDeptName]", param).ToListOfType<Departments>();
        }
        public static dynamic GetTikByDept(string FrmUserName)
        {
            SqlParameter param = new SqlParameter("FrmUserName", FrmUserName);
            SQLDAL.ConnectionString = conn;
            return SQLDAL.ReturnDataTableByProcedure("[dbo].[GetByDept]", param).ToListOfType<TicketSeting>();
        }
        //replay for ticket
        public static void AddReplayToTicket(Ticket_Replays model)
        {
            using (SqlConnection cn = new SqlConnection(conn))
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand cmd = new SqlCommand("[dbo].[ReplayTicket]", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ticket_id", model.ticket_id);
                cmd.Parameters.AddWithValue("@Replay", model.Replay);
                cmd.Parameters.AddWithValue("@ReplayBy", model.ReplayBy);
                cmd.ExecuteNonQuery();
            }
        }


        public static void FillCombo(DropDownList lst, string spname, string valf, string DataF)
        {
            try
            {
                SqlConnection cn = new SqlConnection(conn);
                cn.Open();
                SqlCommand cmd = new SqlCommand(spname, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds, "nn");
                lst.DataTextField = ds.Tables[0].Columns[DataF].ToString();
                lst.DataValueField = ds.Tables[0].Columns[valf].ToString();
                lst.DataSource = ds.Tables[0];
                lst.DataBind();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
