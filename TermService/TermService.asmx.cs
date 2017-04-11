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
        public bool Login(string[] credentials, bool rememberMe)
        {
            int success = LoginDB.ExecuteQuery("LoginUser", LoginDB.BuildNewLoginParams(credentials));
            return success > 0;
        }

        [WebMethod]
        public string CreateNewAccount(object[] data, bool rememberMe)
        {
            // 0 == failure
            int success = LoginDB.ExecuteNonQuery("NewTermAccount", LoginDB.BuildNewAccountParams(data)); 

            if (success == 1)
            {
                if (rememberMe)
                {
                    HttpCookie newCookie = new HttpCookie("userCookie");
                    newCookie.Value = "TermProjectSession";
                    newCookie.Values["Email"] = Convert.ToString(data[2]);
                    LoginDB.ExecuteNonQuery("NewAccountSession", LoginDB.BuildNewCookieParams(new string[2] { Convert.ToString(data[2]), newCookie.Value.ToString() }));
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