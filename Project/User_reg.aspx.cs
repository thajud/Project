using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace Project
{
    public partial class User_reg : System.Web.UI.Page
    {
        Concls ob2 = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(User_id) from User_tab";
            string regid = ob2.fn_exescalar(sel);
            int reg_id = 0;
            if(regid=="")
            {
                reg_id = 1;
            }
            else
            {
                int new_reg = Convert.ToInt32(regid);
                reg_id = new_reg + 1;
            }
            string ins = "insert into User_tab values(" + reg_id + ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','active')";
            int i = ob2.fn_nonquery(ins);
            if(i!=0)
            {
                string inslog = "insert into Login_tab values(" + reg_id + ",'" + TextBox7.Text + "','" + TextBox8.Text + "','user','active')";
                int j = ob2.fn_nonquery(inslog);

            }

        }
    }
}