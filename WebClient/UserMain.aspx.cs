
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class UserMain : System.Web.UI.Page
    {
        TermSVC.TermService pxy = new TermSVC.TermService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((int)Session["LoginCheck"] == 0)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                gvDelete.DataSource = pxy.GetFileData((string)Session["UserEmail"]);
                gvDelete.DataBind();
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            int fileSize;
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

                    pxy.WriteNewFileToStorage(objArray, fileData, (string)base.Session["UserEmail"], "BADTOKEN");
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error" + ex.ToString());
            }
            gvDelete.DataSource = pxy.GetFileData((string)Session["UserEmail"]);
            gvDelete.DataBind();
        }

        protected void btnDeleteSelected_Click(object sender, EventArgs e)
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

        protected void btnUploadUpdatedFile_Click(object sender, EventArgs e)
        {
            int fileSize;
            int fileDataID = 0;
            int fileID = 0;
            string fileName;
            string fileExtension;

            try
            {

                if (FileUploadModify.HasFile)
                {
                    fileSize = FileUploadModify.PostedFile.ContentLength;
                    byte[] fileData = new byte[fileSize];

                    FileUploadModify.PostedFile.InputStream.Read(fileData, 0, fileSize);
                    fileName = FileUploadModify.PostedFile.FileName;

                    fileExtension = fileName.Substring(fileName.LastIndexOf("."));
                    fileExtension = fileExtension.ToLower();


                    for (int row = 0; row < gvDelete.Rows.Count; row++)
                    {
                        CheckBox CBox;
                        CBox = (CheckBox)gvDelete.Rows[row].FindControl("chkSelect");
                        if (CBox.Checked)
                        {
                            fileID= Convert.ToInt32(gvDelete.Rows[row].Cells[1].Text);
                            fileDataID = Convert.ToInt32(gvDelete.Rows[row].Cells[7].Text);
                        }

                    }
                    
                    

                    object[] objArray = new object[8];
                    objArray[0] = fileDataID;
                    objArray[1] = fileID;
                    objArray[2] = fileName;
                    objArray[3] = DateTime.Now;
                    objArray[4] = fileSize;
                    objArray[5] = DateTime.Now;
                    objArray[6] = true;
                    objArray[7] = fileExtension;

                    int x = pxy.UpdateFile(objArray, fileData, (string)Session["UserEmail"], "BADTOKEN");
                    
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error" + ex.ToString());
            }
            gvDelete.DataSource = pxy.GetFileData((string)Session["UserEmail"]);
            gvDelete.DataBind();
        }

        protected void btnDownloadSelected_Click(object sender, EventArgs e)
        {
            string fileType;
            string fileName;
            for (int row = 0; row < gvDelete.Rows.Count; row++)
            {

                CheckBox CBox;
                CBox = (CheckBox)gvDelete.Rows[row].FindControl("chkSelect");
                if (CBox.Checked)
                {
                    object[] objArray = new object[10];
                    objArray[3] = DateTime.Now;
                    objArray[6] = false;
                    fileName = gvDelete.Rows[row].Cells[2].Text;
                    fileType = gvDelete.Rows[row].Cells[3].Text;
                    byte[] fileData = pxy.DownloadFile(Convert.ToInt32(gvDelete.Rows[row].Cells[1].Text), (string)Session["UserEmail"], objArray);
                    Response.Clear();
                    //Response.ContentType = fileType;
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName + ";");
                    Response.BinaryWrite(fileData.ToArray());
                    Response.Flush();
                    Response.Close();
                    Response.End();
                }

            }
            
        }

        protected void btnClearStorage_Click(object sender, EventArgs e)
        {
            int numdeleted = pxy.DeleteStorage((string)Session["UserEmail"]);
            gvDelete.DataSource = pxy.GetFileData((string)Session["UserEmail"]);
            gvDelete.DataBind();
        }

        protected void btnRestoreFiles_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserRestore.aspx");
        }

        protected void btnTechSupportForum_Click(object sender, EventArgs e)
        {
            Response.Redirect("TechSupportForum.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }

}
