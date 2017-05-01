
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
    public partial class TechSupportForum : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                forumControl.ForumDescription = "Ask a Question";

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetForum";
                DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
                gvForum.DataSource = myDS;
                gvForum.DataBind();
                gvForum.Visible = true;
            }
            
        }

        protected void btnSubmitQuestion_Click(object sender, EventArgs e)
        {
            
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddQuestion";
            objCommand.Parameters.AddWithValue("@Question", forumControl.Text);
                    
            objDB.DoUpdateUsingCmdObj(objCommand);



            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "GetForum";
            DataSet myDS = objDB.GetDataSetUsingCmdObj(com);
            gvForum.DataSource = myDS;
            gvForum.DataBind();
            gvForum.Visible = true;
        }
    }

}
