using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace WebClient
{
    public partial class AdminRegister : System.Web.UI.Page
    {
        
        TermSVC.TermService pxy = new TermSVC.TermService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((int)Session["LoginCheck"] == 0)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gvUsers.Rows.Count; row++)
            {
                string firstName, lastName, email;
                CheckBox CBox;
                CBox = (CheckBox)gvUsers.Rows[row].FindControl("chkSelect");
                if (CBox.Checked)
                {
                    firstName = gvUsers.Rows[row].Cells[1].Text;
                    lastName = gvUsers.Rows[row].Cells[2].Text;
                    email = gvUsers.Rows[row].Cells[3].Text;
                }

            }
        }
    }
}