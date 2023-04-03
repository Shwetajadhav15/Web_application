using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication4
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetProductList();
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4PEG8NT\SQLEXPRESS;Initial Catalog=My test;User ID=sa;Password=12345");

        protected void Button1_Click(object sender, EventArgs e)

        {
            int productid = int.Parse(TextBox1.Text);
            string iname = TextBox2.Text, specification = TextBox3.Text, unit = DropDownList1.SelectedValue, status = RadioButtonList1.SelectedValue;
            DateTime cdate = DateTime.Parse(TextBox4.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ProductSetup_SP '" + productid + "','" + iname + "','" + specification + "','" + unit + "','" + status + "','" + cdate + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // created the dataset object
            DataSet ds = new DataSet();

            // fill the dataset and your result will be
            da.Fill(ds);

            // co.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully Inserted.');",true);
            GetProductList();
        }

        void GetProductList()
        {
            SqlCommand co = new SqlCommand("exec ProductList_SP",con);
            SqlDataAdapter sd = new SqlDataAdapter(co);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int productid = int.Parse(TextBox1.Text);
            string iname = TextBox2.Text, specification = TextBox3.Text, unit = DropDownList1.SelectedValue, status = RadioButtonList1.SelectedValue;
            DateTime cdate = DateTime.Parse(TextBox4.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ProductUpdate_SP '" + productid + "','" + iname + "','" + specification + "','" + unit + "','" + status + "','" + cdate + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // created the dataset object
            DataSet ds = new DataSet();

            // fill the dataset and your result will be
            da.Fill(ds);

            // co.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully Updated.');", true);
            GetProductList();
        }

        protected void Button3_Click(object sender, EventArgs e)
        { 
            int productid = int.Parse(TextBox1.Text);
          
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ProductDelete_SP '" + productid + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // created the dataset object
            DataSet ds = new DataSet();

            // fill the dataset and your result will be
            da.Fill(ds);

            // co.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully Deleted.');", true);
            GetProductList();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int productid = int.Parse(TextBox1.Text);

            con.Open();
            SqlCommand cmd = new SqlCommand("exec ProductSearch_SP '" + productid + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            GetProductList();
        }

        
    }
}