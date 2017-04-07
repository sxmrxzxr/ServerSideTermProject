using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TermLibrary;

namespace TermService
{
    /// <summary>
    /// Summary description for TermService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TermService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string CreateNewAccount(string[] data, bool rememberMe)
        {
            // 0 == failure
            int success = LoginDB.ExecuteNonQuery("NewTermAccount", LoginDB.BuildNewAccountParams(data)); 

            if (success == 1)
            {
                if (rememberMe)
                {
                    HttpCookie newCookie = new HttpCookie("userCookie");
                    newCookie.Value = "TermProjectSession";
                    newCookie.Values["Email"] = data[2];
                    LoginDB.ExecuteNonQuery("NewAccountSession", LoginDB.BuildNewCookieParams(new string[2] { data[2], newCookie.Value.ToString() }));
                }

                return "Success";
            }
            else if (success ==  -1)
            {
                return "Exception thrown";
            }
            else
            {
                return "Did not write to database";
            }
        }
    }
}