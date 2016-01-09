using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btncreate_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=DHEERAJ-PC;user id=sa;password=dheeraj;database=testchat;");
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into login(id,pass)values('" + txtid.Text + "','" + txtpass.Text + "')", con);
        cmd.ExecuteNonQuery();
        Response.Write("<script language='javascript'>alert('Created')</script>");
        con.Close();
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
}