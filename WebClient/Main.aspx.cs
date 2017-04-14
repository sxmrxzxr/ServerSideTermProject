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
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            int result = 0, imageSize;
            string fileExtension, imageType, imageName, imageTitle, strSQL;

            try
            {
               
                if (FileUpload.HasFile)
                {
                    imageSize = FileUpload.PostedFile.ContentLength;
                    byte[] imageData = new byte[imageSize];

                    FileUpload.PostedFile.InputStream.Read(imageData, 0, imageSize);
                    imageName = FileUpload.PostedFile.FileName;
                    imageType = FileUpload.PostedFile.ContentType;
                    fileExtension = imageName.Substring(imageName.LastIndexOf("."));
                    fileExtension = fileExtension.ToLower();

            
                    strSQL = "StoreProductImage";
                    objCommand.CommandText = strSQL;
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.Parameters.AddWithValue("@ImageData", imageData);
                    objCommand.Parameters.AddWithValue("@ImageType", imageType);
                    objCommand.Parameters.AddWithValue("@ImageLength", imageData.Length);
                    result = objDB.DoUpdateUsingCmdObj(objCommand);
                }
            }
            catch (Exception ex)
            {
                //error message
            }
        }
    }
}