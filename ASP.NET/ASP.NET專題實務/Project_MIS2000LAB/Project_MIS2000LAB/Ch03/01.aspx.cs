using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_MIS2000LAB.Ch03
{
    public partial class _01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(Label1.Text) + 1;
            Label1.Text = i.ToString();
        }
    }
}