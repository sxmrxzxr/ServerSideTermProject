using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class Forum : System.Web.UI.UserControl
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        public String ForumDescription
        {
            get { return lblForumDescription.Text; }
            set { lblForumDescription.Text = value; }
        }

        public string Text
        {
            get { return txtQuestionOrAnswer.Text; }
            set { txtQuestionOrAnswer.Text = value; }
        }

    }
}