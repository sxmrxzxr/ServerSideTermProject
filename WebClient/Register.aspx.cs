using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lblRequiredField.Visible = false;
            lblRequiredField2.Visible = false;
            lblRequiredField3.Visible = false;
            lblRequiredField4.Visible = false;
            if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                lblRequiredField.Visible = true;
            }
            else if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                lblRequiredField2.Visible = true;
            }
            else if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblRequiredField3.Visible = true;
            }
            else if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblRequiredField4.Visible = true;
            }
            else
            {

            }
        }
    }
}