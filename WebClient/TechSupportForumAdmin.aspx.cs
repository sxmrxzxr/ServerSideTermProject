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
    public partial class TechSupportForumAdmin : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                forumControl.ForumDescription = "Answer a Question";

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetForum";
                DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
                gvForum.DataSource = myDS;
                gvForum.DataBind();
                gvForum.Visible = true;
            }
        }

        protected void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gvForum.Rows.Count; row++)
            {

                CheckBox CBox;
                CBox = (CheckBox)gvForum.Rows[row].FindControl("chkSelect");
                if (CBox.Checked)
                {
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.CommandText = "AddAnswer";
                    objCommand.Parameters.AddWithValue("@Answer", forumControl.Text);
                    objCommand.Parameters.AddWithValue("@Question", gvForum.Rows[row].Cells[1].Text);
                    objDB.DoUpdateUsingCmdObj(objCommand);
                }

            }
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