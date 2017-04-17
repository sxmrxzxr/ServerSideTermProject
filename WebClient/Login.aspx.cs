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
            Session["LoginCheck"] = 0;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string[] stringArray = new string[3];
            stringArray[0] = txtEmail.Text;
            stringArray[1] = txtPassword.Text;

            lblLoginFailed.Visible = false;
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
            else if(!(pxy.Login(stringArray, true, "BADTOKEN")))
            {
                lblLoginFailed.Visible = true;
            }
            else
            {
                lblLoginFailed.Visible = false;
                lblRequiredField.Visible = false;
                lblRequiredField2.Visible = false;
                HttpCookie myCookie = new HttpCookie("userCookie");
                myCookie.Value = "CIS3342";
                myCookie.Expires = new DateTime(2017, 7, 1);
                myCookie.Values["Email"] = txtEmail.Text;
                Response.Cookies.Add(myCookie);
                Session["LoginCheck"] = 1;
                Response.Redirect("Main.aspx");
            }
        }
    }
}