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
        TermSVC.TermService pxy = new TermSVC.TermService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["userCookie"] != null)
            {
                HttpCookie cookie = Request.Cookies["userCookie"];
                txtEmail.Text = cookie.Values["Email"].ToString();
            }
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