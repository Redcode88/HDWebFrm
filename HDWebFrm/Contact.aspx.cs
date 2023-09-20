using BackEnd.Core;
using BackEnd.DataConfig;
using BackEnd.Repo;
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
    public partial class Contact : Page
    {
        private string conn =
        ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TicketRepsitory.FillCombo(Combo_FromDept, "[dbo].[GetALLDept]", "DepartmentName", "DepartmentName");
                TicketRepsitory.FillCombo(Combo_ToDept, "[dbo].[GetALLDept]", "DepartmentName", "DepartmentName");
                TicketRepsitory.FillCombo(Combo_St, "[dbo].[GetPer]", "Name", "Name");
            }
            
        }

        private void clearTxt()
        {
            if (!IsPostBack)
            {
                Txt_UserName.Text = "";
                TicketRepsitory.FillCombo(Combo_FromDept, "[dbo].[GetALLDept]", "DepartmentName", "DepartmentName");
                TicketRepsitory.FillCombo(Combo_ToDept, "[dbo].[GetALLDept]", "DepartmentName", "DepartmentName");
                TicketRepsitory.FillCombo(Combo_St, "[dbo].[GetPer]", "Name", "Name");
                Txt_Des.Text = "";
                Txt_UserName.Focus();
            }
            
        }
        protected void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conn))
                {
                    if (cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("[dbo].[AddTickts]", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FrmUserName",Txt_UserName.Text);
                    cmd.Parameters.AddWithValue("@FrmDepartment",Combo_FromDept.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@ToDepartment",Combo_ToDept.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@IsActive",true);
                    cmd.Parameters.AddWithValue("@State", "Open");
                    cmd.Parameters.AddWithValue("@CreatedDate",DateTime.Now);
                    cmd.Parameters.AddWithValue("@Discreption",Txt_Des.Text);
                    cmd.Parameters.AddWithValue("@Per",Combo_St.SelectedItem.Value);
                    cmd.ExecuteNonQuery();

                }
                clearTxt();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearTxt();
        }
    }
}