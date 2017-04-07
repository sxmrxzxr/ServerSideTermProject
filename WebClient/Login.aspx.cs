using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblRequiredField.Visible = false;
            lblRequiredField2.Visible = false;
            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblRequiredField.Visible = true;
            }
            else if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblRequiredField2.Visible = true;
            }
            else
            {

            }
        }
    }
}