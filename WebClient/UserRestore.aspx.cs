using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class UserRestore : System.Web.UI.Page
    {
        TermSVC.TermService pxy = new TermSVC.TermService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grvUserTrash.DataSource = pxy.GetInactiveFiles((string)Session["UserEmail"]);
                grvUserTrash.DataBind();
            }
        }

        protected void btnRestore_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < grvUserTrash.Rows.Count; row++)
            {

                CheckBox CBox;
                CBox = (CheckBox)grvUserTrash.Rows[row].FindControl("chkSelect");
                if (CBox.Checked)
                {
                    int fileID = Convert.ToInt32(grvUserTrash.Rows[row].Cells[1].Text);
                    int fileSize = Convert.ToInt32(grvUserTrash.Rows[row].Cells[6].Text);

                    pxy.RestoreFile(fileID);
                }

            }
            grvUserTrash.DataSource = pxy.GetInactiveFiles((string)Session["UserEmail"]);
            grvUserTrash.DataBind();
        }
    }
}