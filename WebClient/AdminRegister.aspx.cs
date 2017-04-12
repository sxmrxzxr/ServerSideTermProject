using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace WebClient
{
    public partial class AdminRegister : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                String strSQL = "SELECT * FROM Product";
                gvUsers.DataSource = objDB.GetDataSet(strSQL);
                gvUsers.DataBind();
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gvUsers.Rows.Count; row++)
            {
                CheckBox CBox;
                CBox = (CheckBox)gvUsers.Rows[row].FindControl("chkSelect");
                if (CBox.Checked)
                {

                }

            }
        }
    }
}