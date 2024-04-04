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
    public partial class Admin_reg : System.Web.UI.Page
    {
        Concls ob1 = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string maxx = "select max(Admin_id)from Admin_tab";
            string regid = ob1.fn_exescalar(maxx);
            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;
            }
            string qw = "insert into Admin_tab values(" + reg_id + ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            int r = ob1.fn_nonquery(qw);
            if (r != 0)
            {
                string inslo = "insert into Login_tab values(" + TextBox1.Text + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','admin','active')";
                int j = ob1.fn_nonquery(inslo);
            }
        }

            

        
    }
}