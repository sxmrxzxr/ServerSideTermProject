﻿using System;
using System.Collections.Generic;
using System.Data;
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

        private string VERIFICATION_TOKEN = "BADTOKEN";

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public bool Login(string[] credentials, bool rememberMe, string verify)
        {
            int success = LoginDB.ExecuteQuery("LoginUser", LoginDB.BuildNewLoginParams(credentials));
            return success > 0;
        }

        [WebMethod]
        public string CreateNewAccount(object[] data, bool rememberMe, string verify)
        {
            // 0 == failure
            int success = LoginDB.ExecuteQuery("NewTermAccount", LoginDB.BuildNewAccountParams(data)); 

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

        [WebMethod]
        public int WriteNewFileToStorage(object[] data, byte[] filecontent, string accEmail, string verify)
        {
            List<Param> l = new List<Param>();
            l.Add(new Param("FileContent", filecontent, SqlDbType.VarBinary));
            int fileID = LoginDB.ExecuteQuery("NewFile", l);

            //int fileID = LoginDB.ExecuteQuery("GetFileID", l);

            l = new List<Param>();
            l.Add(new Param("Email", accEmail, SqlDbType.VarChar));
            int accoID = LoginDB.ExecuteQuery("GetAccountID", l);

            LoginDB.ExecuteNonQuery("NewFileData", LoginDB.BuildNewFileDataParams(fileID, data));
            LoginDB.ExecuteNonQuery("NewFileTransaction", LoginDB.BuildNewTransactionParams(fileID, accoID, data));
            LoginDB.ExecuteNonQuery("UpdateStorage", LoginDB.BuildNewUpdateStorageParams(accoID, Convert.ToInt32(data[4])));

            l = new List<Param>();
            l.Add(new Param("AccountID", accoID, SqlDbType.Int));
            int remaining = LoginDB.ExecuteQuery("GetRemainingStorage", l);

            return remaining;
        }
    }
}