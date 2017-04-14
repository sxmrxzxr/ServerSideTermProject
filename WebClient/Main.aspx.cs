﻿using System;
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

                    pxy.WriteNewFileToStorage(objArray, imageData, (string)Session["UserEmail"], txtVerificationToken.Text);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error" + ex.ToString());
            }
        }
    }
}