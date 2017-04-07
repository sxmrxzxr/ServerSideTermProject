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
        TermSVC.TermService pxy = new TermSVC.TermService();
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
                HttpCookie myCookie = new HttpCookie("userCookie");
                myCookie.Value = "CIS3342";
                myCookie.Expires = new DateTime(2017, 7, 1);
                myCookie.Values["Email"] = txtEmail.Text;
                Response.Cookies.Add(myCookie);

                object[] data = new object[5];
                data[0] = txtLastName.Text;
                data[1] = txtFirstName.Text;
                data[2] = txtEmail.Text;
                data[3] = txtPassword.Text;
                data[4] = Convert.ToString(chkRegisterAsAnAdmin.Checked);

                bool check = false;
                if(chkRememberMe.Checked)
                {
                    check = true;
                }
                string check2 = pxy.CreateNewAccount(data, check);
                Response.Write(check2);

                modifyControls();
            }
        }

        private void modifyControls()
        {
            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblEmail.Visible = false;
            lblPassword.Visible = false;
            txtFirstName.Visible = false;
            txtLastName.Visible = false;
            txtEmail.Visible = false;
            txtPassword.Visible = false;
            btnRegister.Visible = false;
            chkRegisterAsAnAdmin.Visible = false;
            chkRememberMe.Visible = false;
            lblRegistrationSuccessful.Visible = true;
            btnReturnToLogin.Visible = true;
        }

        protected void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}