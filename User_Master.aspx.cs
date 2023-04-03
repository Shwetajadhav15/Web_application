using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Text;

namespace WebApplication4
{
    public partial class User_Master : System.Web.UI.Page
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4PEG8NT\SQLEXPRESS;Initial Catalog=My test;User ID=sa;Password=12345");

        public SqlCommand cmd = null;
        public SqlDataAdapter sda = null;
        //For Export
        public static DataTable dt_export = null;
        public static string userid = "0";
        public static string task = "";
        public static Class_Properties.User cp = new Class_Properties.User();
        //Page Load (User Table Master)
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                    clear_all_fields();

                    btn_save.Text = "Save";
                    btn_clear.Text = "Clear";
                    btn_delete.Text = "Delete";
            }
        }
        //To change color
        protected void gv_details_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    //Sr.No.
                    e.Row.Cells[1].BackColor = ColorTranslator.FromHtml("#F2F2F2");
                    e.Row.Cells[1].ForeColor = Color.Black;

                    if (e.Row.Cells[9].Text.Trim() == "Blocked")
                    {
                        e.Row.Cells[9].ForeColor = ColorTranslator.FromHtml("#f74d23");
                    }
                    else if (e.Row.Cells[9].Text.Trim() == "Unblocked")
                    {
                        e.Row.Cells[9].ForeColor = ColorTranslator.FromHtml("#1a9302");
                    }
                }
            }
            catch (Exception ex)
            {
                string script = "alert(\"Exception :'" + ex.Message.ToString() + "'!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "Information", script, true);
            }
        }
        //To show details as per selected option and value
        public void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                Call_Properties_And_Method("Show");
            }
            catch (Exception ex)
            {
                string script = "alert(\"Exception :'" + ex.Message.ToString() + "'!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "Information", script, true);
            }
        }
        //To get selected details either for (Update/Delete)
        protected void gv_details_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int selected_row_index = Convert.ToInt32(e.CommandArgument);
                //Makeing Selected Row As (Bold)
                for (int i = 0; i < gv_details.Rows.Count; i++)
                {
                    gv_details.Rows[i].Font.Bold = false;
                }
                if (e.CommandName == "Update")
                {
                    gv_details.Rows[selected_row_index].Font.Bold = true;
                    txt_ID.Text = gv_details.DataKeys[selected_row_index]["ID"].ToString();
                    txt_username.Text = gv_details.DataKeys[selected_row_index]["USER_NAME"].ToString();
                    txt_name.Text = gv_details.DataKeys[selected_row_index]["NAME"].ToString();
                    txt_mobileno.Text = gv_details.DataKeys[selected_row_index]["MOBILE_NO"].ToString();
                    txt_Address.Text = gv_details.DataKeys[selected_row_index]["ADDRESS"].ToString();
                    txt_Password.Text = gv_details.DataKeys[selected_row_index]["PASSWORD"].ToString();
                    // txt_Password.Visible=false ;
                    txt_username.Enabled = false;
                    btn_save.Text = "Update";
                    if (gv_details.DataKeys[selected_row_index]["BLOCK_STATUS"].ToString() == "BLOCKED")
                    { chk_Block.Checked = true; }
                    else
                    { chk_Block.Checked = false; }

                    
                }
            }
            catch (Exception ex)
            {
                string script = "alert(\"Exception :'" + ex.Message.ToString() + "'!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "Information", script, true);
            }
        }
        //To Handle Event
        protected void gv_details_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
        }
        

        //To save/update details
        protected void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Information", "alert('" + "Please Enter Name" + "');", true);
                    return;
                }
                if (txt_username.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Information", "alert('" + "Please Enter UserName" + "');", true);
                    return;
                }
                if (txt_Password.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Information", "alert('" + "Please Enter Password" + "');", true);
                    return;
                }
                
                if (txt_mobileno.Text == "")
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Information", "alert('" + "Please Enter Mobile No." + "');", true);
                    return;
                }
                if (txt_mobileno.Text.Length<10)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Information", "alert('" + "Please Enter Mobile No correctly." + "');", true);
                    return;
                }

                string task = "";
                if (btn_save.Text == "Save")
                {
                    task = "Save";
                }
                if (btn_save.Text == "Update")
                {
                    task = "Update";
                }
                string Message = Call_Properties_And_Method(task);
                clear_all_fields();
                ScriptManager.RegisterStartupScript(this, GetType(), "Information", "alert(\'" + Message.ToString() + "');", true);

            }
            catch (Exception ex)
            {
                string script = "alert(\"Exception :'" + ex.Message.ToString() + "'!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "Information", script, true);
            }
        }
        //To clear all fields
        protected void btn_clear_Click(object sender, EventArgs e)
        {
            try
            {
                clear_all_fields();
            }
            catch (Exception ex)
            {
                string script = "alert(\"Exception :'" + ex.Message.ToString() + "'!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "Information", script, true);
            }
        }
        private void clear_all_fields()
        {
            try
            {
                txt_username.Enabled = true;
                txt_ID.Text = "";
                txt_username.Text = "";
                txt_Address.Text = "";
                txt_mobileno.Text = "";
                txt_name.Text = "";
                txt_Password.Text = "";             
                chk_Block.Checked = false; 
                txt_Password.Visible = true;
                txt_search_value.Text = "";
                Call_Properties_And_Method("Show");
               
                btn_save.Text = "Save";
                txt_name.Focus();
            }
            catch (Exception ex)
            {
                string script = "alert(\"Exception :'" + ex.Message.ToString() + "'!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "Information", script, true);
            }
        }
        private string Call_Properties_And_Method(string Task)
        {
            string Message = "";
            cp.TASK = Task;
            cp.ID = txt_ID.Text.Trim();
            cp.USER_NAME = txt_username.Text.Trim();
            cp.PASSWORD = txt_Password.Text.Trim();
            cp.NAME = txt_name.Text.Trim();
            cp.ADDRESS = txt_Address.Text.Trim();
            cp.MOBILE_NO = txt_mobileno.Text.Trim();
            if (chk_Block.Checked == true)
            {
                cp.ISDELETED = "1";
            }
            else
            {
                cp.ISDELETED = "0";
            }          
          
            cp.CREATED_BY = "1";
            cp.SEARCH_VALUE = "%" + txt_search_value.Text.Trim() + "%";
            DataTable DT = Method.Save_Update_User_Master(cp);
            if (Task == "Show")
            {
                gv_details.DataSource = DT;
                gv_details.DataBind();
                txt_search_value.Text = DT.Rows.Count.ToString();
            }
            else
            { Message = DT.Rows[0][0].ToString(); }
            return Message;
        }
        
            public void btn_delete_Click(object sender, EventArgs e)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("exec Save_Delete_User_Master '" + txt_ID.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('User Details Deleted Sucessfully.');", true);
                clear_all_fields();
            }
            protected void gv_details_RowDeleting(object sender, GridViewDeleteEventArgs e)
            {
                DataTable DT = Method.Save_Delete_User_Master(cp);
                gv_details.DataSource = DT;
                gv_details.DataBind();
            }      
    }
}
