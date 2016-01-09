using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsignup_Click(object sender, EventArgs e)
    {
        Response.Redirect("signup.aspx");
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=DHEERAJ-PC;user id=sa;password=dheeraj;database=testchat;");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from login where id='"+txtid.Text+"'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        string id = dt.Rows[0][0].ToString();
        string pass = dt.Rows[0][1].ToString();
        id=id.Replace(" ", "");
        pass=pass.Replace(" ", "");
        if (id == txtid.Text && pass == txtpass.Text){
            Session["one"] = id;
            Response.Redirect("chatenvironment.aspx");}
        else
            Response.Write("<script language='javascript'>alert('Invalid UserID or Password')</script>");
        con.Close();
    }

}