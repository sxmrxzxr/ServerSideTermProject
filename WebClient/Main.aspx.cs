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
                gvDelete.DataSource = pxy.GetFileData();
                gvDelete.DataBind();
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
                    byte[] imageData = new byte[fileSize];

                    FileUpload.PostedFile.InputStream.Read(imageData, 0, fileSize);
                    fileName = FileUpload.PostedFile.FileName;
                 
                    fileExtension = fileName.Substring(fileName.LastIndexOf("."));
                    fileExtension = fileExtension.ToLower();

                    object[] objArray = new object[5];
                    objArray[0] = fileName;
                    objArray[1] = fileExtension;
                    objArray[2] = DateTime.Now;
                    objArray[3] = DateTime.Now;
                    objArray[4] = fileSize;

                    pxy.WriteNewFileToStorage(objArray, imageData, (string)Session["UserEmail"], "BADTOKEN");
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error" + ex.ToString());
            }
        }
        protected void btnModify_Click(object sender, EventArgs e)
        {
            int result = 0, fileSize;
            string fileExtension, fileName;

            try
            {

                if (FileUpload.HasFile)
                {
                    fileSize = FileUpload.PostedFile.ContentLength;
                    byte[] imageData = new byte[fileSize];

                    FileUpload.PostedFile.InputStream.Read(imageData, 0, fileSize);
                    fileName = FileUpload.PostedFile.FileName;

                    int fileDataID = 18;
                    int fileID = 34;

                    object[] objArray = new object[7];
                    objArray[0] = fileDataID;
                    objArray[1] = fileID;
                    objArray[2] = fileName;
                    objArray[3] = DateTime.Now;
                    objArray[4] = fileSize;
                    objArray[5] = DateTime.Now;
                    objArray[6] = true;

                    pxy.UpdateFile(objArray, imageData, (string)Session["UserEmail"], "BADTOKEN");
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error" + ex.ToString());
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gvUsers.Rows.Count; row++)
            {
                
                CheckBox CBox;
                CBox = (CheckBox)gvDelete.Rows[row].FindControl("chkSelect");
                if (CBox.Checked)
                {
                    pxy.DeleteFile("BADTOKEN");
                }

            }
        }
    }
}