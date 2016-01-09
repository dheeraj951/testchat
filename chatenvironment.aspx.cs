using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Timers;



public partial class chatenvironment : System.Web.UI.Page
{
    static int index=0;//,count=0;
    int i;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Timer1.Start();
    }
    protected void btnsend_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=DHEERAJ-PC;user id=sa;password=dheeraj;database=testchat;");
        con.Open();
        string username = Session["one"].ToString();
        SqlCommand cmd = new SqlCommand("insert into chat(data)values('"+username+"'+':'+'" + txtchatip.Text + "')", con);
            cmd.ExecuteNonQuery();
            display();
            index++;
            //count = index - 1;
            txtchatip.Text = "";
        con.Close();
        //t=new System.Threading.Timer(display2(),null,5000,System.Threading.Timeout.Infinite);
        //timer = new System.Threading.Timer(obj => { bar(); }, null, 1000, System.Threading.Timeout.Infinite);
    }
    protected void btnclear_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=DHEERAJ-PC;user id=sa;password=dheeraj;database=testchat;");
        con.Open();
        SqlCommand cmd = new SqlCommand("delete from chat", con);
        cmd.ExecuteNonQuery();
        index = 0;
        txtchatwin.Text = null;
        con.Close();
    }
    public void display()
    {
        SqlConnection con = new SqlConnection("server=DHEERAJ-PC;user id=sa;password=dheeraj;database=testchat;");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from chat", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        txtchatwin.Text = null;
        for (i = 0; i <= index; i++)
        {
            txtchatwin.Text = txtchatwin.Text + dt.Rows[i][1].ToString() + "\n";
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        if (index > 0) 
        {
            index--;
            display();
            index++;
        }
        
    }
}