using BackEnd.Core;
using BackEnd.DataConfig;
using BackEnd.Repo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HDWebFrm
{
    public partial class Contact : Page
    {
        private string conn =
        ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        public string UserName;
        



        protected void Page_Load(object sender, EventArgs e)
        {
           


            if (!IsPostBack)
            {
                var id = Guid.NewGuid();
                TxtGuid.Text = id.ToString();
                CurrentSession();
                TicketRepsitory.FillCombo(Combo_FromDept, "[dbo].[GetALLDept]", "DepartmentName", "DepartmentName");
                TicketRepsitory.FillCombo(Combo_ToDept, "[dbo].[GetALLDept]", "DepartmentName", "DepartmentName");
                TicketRepsitory.FillCombo(Combo_St, "[dbo].[GetPer]", "Name", "Name");
            }
            
        }


        public void CurrentSession()
        {
            UserName = User.Identity.Name;
            if (Session["UserName"] != null)
            {
                UserName = Session["UserName"].ToString();
                Txt_UserName.Text = UserName.ToString();
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
                var id = Guid.NewGuid();
                TxtGuid.Text = id.ToString();
                fileUpload1.Dispose();
                Txt_UserName.Focus();
            }
            
        }


        private void AttachTicketFiles()
        {
            if (fileUpload1.HasFile)
            {
                try
                {
                    string folderPath = Server.MapPath("~/Documents/");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    using (SqlConnection cn = new SqlConnection(conn))
                    {
                        if (cn.State != ConnectionState.Open)
                        {
                            cn.Open();
                        }

                        foreach (HttpPostedFile postedFile in fileUpload1.PostedFiles)
                        {

                            string fileName = Path.GetFileName(postedFile.FileName);
                            string fileExtension = Path.GetExtension(fileName).ToLower();

                            // Define the allowed file extensions (e.g., .pdf, .jpg, .png)
                            string[] allowedExtensions = { ".pdf", ".jpg", ".png" };
                            // Check if the file extension is allowed
                            if (Array.Exists(allowedExtensions, ext => ext == fileExtension))
                            {
                                // Save the file to the folder
                                postedFile.SaveAs(Path.Combine(folderPath, fileName));
                                SqlCommand cmd = new SqlCommand("[dbo].[AddDocument]", cn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@DocumentUrl", fileName);
                                cmd.Parameters.AddWithValue("@IdGuid", Guid.Parse(TxtGuid.Text));
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                // Display an error message if the file extension is not allowed
                                Response.Write($"File '{fileName}' was not saved. File type not supported.");
                            }

                           
                        }





                    }

                }
                catch (Exception)
                {

                    throw;
                }
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
                    cmd.Parameters.AddWithValue("@IdFlag", TxtGuid.Text);
                    //check if the file upload has files 
                    if (fileUpload1.HasFile)
                    {
                        AttachTicketFiles();
                    }
                    cmd.ExecuteNonQuery();

                }
                Response.Redirect("Default.aspx");
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