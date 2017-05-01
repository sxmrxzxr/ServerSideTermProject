using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class AdminMain : System.Web.UI.Page
    {
        TermSVC.TermService pxy = new TermSVC.TermService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((int)Session["LoginCheck"] == 0)
            {
                Response.Redirect("Login.aspx");
            }
            if(!IsPostBack)
            {
                gvAdminDelete.DataSource = pxy.GetAllAccounts();
                gvAdminDelete.DataBind();
            }
        }

        protected void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnRegisterNewAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminRegister.aspx");
        }

        protected void btnDeleteSelectedAccounts_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gvAdminDelete.Rows.Count; row++)
            {

                CheckBox CBox;
                CBox = (CheckBox)gvAdminDelete.Rows[row].FindControl("chkSelect2");
                if (CBox.Checked)
                {
                    string email = gvAdminDelete.Rows[row].Cells[1].Text;
                    pxy.DeleteAccountWithEmail(email, (string)Session["UserEmail"]);
                }

            }
            gvAdminDelete.DataSource = pxy.GetAllAccounts();
            gvAdminDelete.DataBind();
        }

        protected void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gvAdminDelete.Rows.Count; row++)
            {

                CheckBox CBox;
                CBox = (CheckBox)gvAdminDelete.Rows[row].FindControl("chkSelect2");
                if (CBox.Checked)
                {
                    string email = gvAdminDelete.Rows[row].Cells[1].Text;
                    int capacity = Convert.ToInt32(txtStorageCapacity.Text);
                    string password = txtPassword2.Text;
                    pxy.AdminUpdateAccountInfo(email, capacity, password, (string)Session["UserEmail"]);
                }

            }
            txtPassword2.Text = "";
            txtStorageCapacity.Text = "";

            gvAdminDelete.DataSource = pxy.GetAllAccounts();
            gvAdminDelete.DataBind();
        }

        protected void btnDeactivateAccounts_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gvAdminDelete.Rows.Count; row++)
            {

                CheckBox CBox;
                CBox = (CheckBox)gvAdminDelete.Rows[row].FindControl("chkSelect2");
                if (CBox.Checked)
                {
                    string email = gvAdminDelete.Rows[row].Cells[1].Text;
                    pxy.DeactivateAccount(email, (string)Session["UserEmail"]);
                }

            }
            
            gvAdminDelete.DataSource = pxy.GetAllAccounts();
            gvAdminDelete.DataBind();
        }

        protected void btnViewSelectedUsersFiles_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gvAdminDelete.Rows.Count; row++)
            {

                CheckBox CBox;
                CBox = (CheckBox)gvAdminDelete.Rows[row].FindControl("chkSelect2");
                if (CBox.Checked)
                {
                    string email = gvAdminDelete.Rows[row].Cells[1].Text;
                    gvDelete.DataSource = pxy.GetFileData(email);
                    gvDelete.DataBind();
                    gvDelete.Visible = true;
                }
            }
        }

        protected void btnTechSupport_Click(object sender, EventArgs e)
        {
            Response.Redirect("TechSupportForumAdmin.aspx");
        }
    }
}
