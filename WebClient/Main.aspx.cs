using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace WebClient
{
    public partial class Main : System.Web.UI.Page
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
                gvDelete.DataSource = pxy.GetFileData((string)Session["UserEmail"]);
                gvDelete.DataBind();

                gvAdminDelete.DataSource = pxy.GetAllAccounts();
                gvAdminDelete.DataBind();

                DateTime start = new DateTime(2017, 4, 18);
                DateTime end = DateTime.Now;
                gvTransactions.DataSource = pxy.GetTransactions(start, end, (string)Session["UserEmail"]);
                gvTransactions.DataBind();

                string[] accountInfo = new string[4];
                accountInfo = pxy.GetAccountInfoWithEmail((string)Session["UserEmail"]);
                txtFirstName.Text = accountInfo[0];
                txtLastName.Text = accountInfo[1];
                txtEmail.Text = accountInfo[2];
                txtPassword.Text = accountInfo[3];

            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            
            int result = 0, fileSize;
            string fileExtension, fileName;

            try
            {
               
                if (FileUpload.HasFile)
                {
                    fileSize = FileUpload.PostedFile.ContentLength;
                    byte[] fileData = new byte[fileSize];

                    FileUpload.PostedFile.InputStream.Read(fileData, 0, fileSize);
                    fileName = FileUpload.PostedFile.FileName;
                 
                    fileExtension = fileName.Substring(fileName.LastIndexOf("."));
                    fileExtension = fileExtension.ToLower();

                    object[] objArray = new object[5];
                    objArray[0] = fileName;
                    objArray[1] = fileExtension;
                    objArray[2] = DateTime.Now;
                    objArray[3] = DateTime.Now;
                    objArray[4] = fileSize;

                    pxy.WriteNewFileToStorage(objArray, fileData, (string)Session["UserEmail"], "BADTOKEN");
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error" + ex.ToString());
            }
            gvDelete.DataSource = pxy.GetFileData((string)Session["UserEmail"]);
            gvDelete.DataBind();

        }

        //you can change the fileDataID and fileID to choose a different file to modify
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int fileSize;
            string fileName;

            try
            {

                if (FileUploadModify.HasFile)
                {
                    fileSize = FileUploadModify.PostedFile.ContentLength;
                    byte[] fileData = new byte[fileSize];

                    FileUploadModify.PostedFile.InputStream.Read(fileData, 0, fileSize);
                    fileName = FileUploadModify.PostedFile.FileName;
                    //change these to choose a different file
                    int fileDataID = 17;
                    int fileID = 33;

                    object[] objArray = new object[7];
                    objArray[0] = fileDataID;
                    objArray[1] = fileID;
                    objArray[2] = fileName;
                    objArray[3] = DateTime.Now;
                    objArray[4] = fileSize;
                    objArray[5] = DateTime.Now;
                    objArray[6] = true;

                    int x = pxy.UpdateFile(objArray, fileData, (string)Session["UserEmail"], "BADTOKEN");
                    Response.Write(x);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error" + ex.ToString());
            }
            gvDelete.DataSource = pxy.GetFileData((string)Session["UserEmail"]);
            gvDelete.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gvDelete.Rows.Count; row++)
            {
                
                CheckBox CBox;
                CBox = (CheckBox)gvDelete.Rows[row].FindControl("chkSelect");
                if (CBox.Checked)
                {
                    int fileID = Convert.ToInt32(gvDelete.Rows[row].Cells[1].Text);
                    int fileSize = Convert.ToInt32(gvDelete.Rows[row].Cells[6].Text);

                    pxy.DeleteFile(fileID, fileSize, (string)Session["UserEmail"]);
                }

            }
            gvDelete.DataSource = pxy.GetFileData((string)Session["UserEmail"]);
            gvDelete.DataBind();

        }

        protected void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            object[] accountArray = new object[4];
            accountArray[0] = txtFirstName.Text;
            accountArray[1] = txtLastName.Text;
            accountArray[2] = txtEmail;
            accountArray[3] = txtPassword;
            pxy.UpdateAccountInfo(accountArray,"BADPASS");

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";

            gvAdminDelete.DataSource = pxy.GetAllAccounts();
            gvAdminDelete.DataBind();
        }

        protected void btnDelete2_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gvAdminDelete.Rows.Count; row++)
            {

                CheckBox CBox;
                CBox = (CheckBox)gvAdminDelete.Rows[row].FindControl("chkSelect2");
                if (CBox.Checked)
                {
                    string email = gvAdminDelete.Rows[row].Cells[1].Text;
                    pxy.DeleteAccountWithEmail(email);
                }

            }
            gvAdminDelete.DataSource = pxy.GetAllAccounts();
            gvAdminDelete.DataBind();
        }

        protected void btnUpdate2_Click(object sender, EventArgs e)
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
                    pxy.AdminUpdateAccountInfo(email, capacity, password);
                }

            }
            txtPassword2.Text = "";
            txtStorageCapacity.Text = "";

            gvAdminDelete.DataSource = pxy.GetAllAccounts();
            gvAdminDelete.DataBind();
        }
    }
}