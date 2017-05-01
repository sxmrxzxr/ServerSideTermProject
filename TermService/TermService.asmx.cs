using System;
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
            int success = LoginDB.ExecuteNonQuery("NewTermAccount", LoginDB.BuildNewAccountParams(data)); 

            if (success > 1)
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


        public int GetAccountIDViaEmail(string accEmail)
        {
            List<Param> l = new List<Param>();
            l.Add(new Param("Email", accEmail, SqlDbType.VarChar));
            int accoID = LoginDB.ExecuteQuery("GetAccountID", l);
            return accoID;
        }


        [WebMethod]
        public int WriteNewFileToStorage(object[] data, byte[] filecontent, string accEmail, string verify)
        {
            List<Param> l = new List<Param>();
            l.Add(new Param("FileContent", filecontent, SqlDbType.VarBinary));

            int fileID = LoginDB.ExecuteQuery("NewFile", l);

            int accoID = GetAccountIDViaEmail(accEmail);

            int datasuccess = LoginDB.ExecuteNonQuery("NewFileData", LoginDB.BuildNewFileDataParams(fileID, data, accoID));
            int transactionsuccess = LoginDB.ExecuteNonQuery("NewFileTransaction", LoginDB.BuildNewTransactionParams(fileID, accoID, data));
            int updatesuccess = LoginDB.ExecuteNonQuery("UpdateStorage", LoginDB.BuildNewUpdateStorageParams(accoID, Convert.ToInt32(data[4])));

            l = new List<Param>();
            l.Add(new Param("AccountID", accoID, SqlDbType.Int));
            int remaining = LoginDB.ExecuteQuery("GetRemainingStorage", l);

            return remaining;
        }

        [WebMethod]
        public int UpdateFile(object[] data, byte[] filecontent, string accEmail, string verify)
        {
            int accoID = GetAccountIDViaEmail(accEmail);

            int updatesuccess = LoginDB.ExecuteNonQuery("TermUpdateFile", LoginDB.BuildNewUpdateFileParams(data, filecontent, accoID));
            int otherupdatesuccess = LoginDB.ExecuteNonQuery("UpdateStorage", LoginDB.BuildNewUpdateStorageParams(accoID, Convert.ToInt32(data[4])));

            List<Param> l = new List<Param>();

            l.Add(new Param("AccountID", accoID, SqlDbType.Int));
            int remaining = LoginDB.ExecuteQuery("GetRemainingStorage", l);

            return remaining;
        }


        [WebMethod]
        public int DeleteFile(int fileID, int fileSize, string email)
        {
            int accoID = GetAccountIDViaEmail(email);
            List<Param> p = new List<Param>();
            p.Add(new Param("FileID", fileID, SqlDbType.Int));
            p.Add(new Param("FileSize", fileSize, SqlDbType.Int));
            p.Add(new Param("AccountID", accoID, SqlDbType.Int));
            int success = LoginDB.ExecuteNonQuery("DeleteFile", p);
            return success;
        }

        [WebMethod]
        public int AdminUpdateAccountInfo(string email, int capacity, string password, string adminemail)
        {
            int accoID = GetAccountIDViaEmail(email);
            int adminID = GetAccountIDViaEmail(adminemail);
            List<Param> p = new List<Param>();
            p.Add(new Param("AccountID", accoID, SqlDbType.Int));
            p.Add(new Param("Capacity", capacity, SqlDbType.Int));
            p.Add(new Param("Passwd", password, SqlDbType.VarChar));
            int x = LoginDB.ExecuteNonQuery("AdminUpdateAccount", p);
            p = new List<Param>();
            p.Add(new Param("AccountID", accoID, SqlDbType.Int));
            p.Add(new Param("AdminID", adminID, SqlDbType.Int));
            p.Add(new Param("ActivityType", "Updated Account", SqlDbType.VarChar));
            int yep = LoginDB.ExecuteNonQuery("NewAdminActivity", p);
            return x;
        }

        [WebMethod]
        public DataSet GetTransactions(DateTime start, DateTime end, string email)
        {
            int accoID = GetAccountIDViaEmail(email);
            List<Param> p = new List<Param>();
            p.Add(new Param("StartTime", start, SqlDbType.DateTime));
            p.Add(new Param("EndTime", end, SqlDbType.DateTime));
            p.Add(new Param("AccountID", accoID, SqlDbType.Int));
            return LoginDB.GetTransactions(p);
        }

        [WebMethod]
        public int UpdateAccountInfo(object[] data, string token)
        {

            int accoID = GetAccountIDViaEmail(Convert.ToString(data[2]));
            return LoginDB.ExecuteNonQuery("UpdateAccount", LoginDB.BuildUpdateAccountParams(data, accoID));
        }

        [WebMethod]
        public string[] GetAccountInfoWithEmail(string email)
        {
            return LoginDB.GetAccountInfo(email);
        }

        [WebMethod]
        public int DeleteAccountWithEmail(string email, string adminemail)
        {
            int accoID = GetAccountIDViaEmail(email);
            int adminID = GetAccountIDViaEmail(adminemail);
            List<Param> l = new List<Param>();
            l.Add(new Param("AccountID", accoID, SqlDbType.Int));
            int x = LoginDB.ExecuteNonQuery("DeleteAccount", l);
            List<Param> p = new List<Param>();
            p.Add(new Param("AccountID", accoID, SqlDbType.Int));
            p.Add(new Param("AdminID", adminID, SqlDbType.Int));
            p.Add(new Param("ActivityType", "Deleted Account", SqlDbType.VarChar));
            int yep = LoginDB.ExecuteNonQuery("NewAdminActivity", p);
            return x;
        }

        [WebMethod]
        public int GetAccountLevel(string email)
        {
            int accoID = GetAccountIDViaEmail(email);
            List<Param> l = new List<Param>();
            l.Add(new Param("AccountID", accoID, SqlDbType.Int));
            int level = LoginDB.ExecuteQuery("GetAccountLevel", l);
            return level;
        }


        [WebMethod]
        public int DeactivateAccount(string useremail, string adminemail)
        {
            int accoID = GetAccountIDViaEmail(useremail);
            int adminID = GetAccountIDViaEmail(adminemail);
            List<Param> l = new List<Param>();
            l.Add(new Param("AccountID", accoID, SqlDbType.Int));
            int success= LoginDB.ExecuteNonQuery("DeactivateAccount", l);
            l.Add(new Param("AdminID", adminID, SqlDbType.Int));
            l.Add(new Param("ActivityType", "Deactivated Account", SqlDbType.VarChar));
            int yep = LoginDB.ExecuteNonQuery("NewAdminActivity", l);
            return success;
        }

        [WebMethod]
        public DataSet GetAllAccounts()
        {
            return LoginDB.GetAllAccounts();
        }

        [WebMethod]
        public DataSet GetFileData(string email)
        {
            int id = GetAccountIDViaEmail(email);
            return LoginDB.GetFileData(id);
        }

        [WebMethod]
        public byte[] DownloadFile(int fileId, string accEmail, object[] data)
        {
            int accoID = GetAccountIDViaEmail(accEmail);
            int transactionsuccess = LoginDB.ExecuteNonQuery("NewFileTransaction", LoginDB.BuildNewTransactionParams(fileId, accoID, data));
            return LoginDB.GetFile(fileId);
        }

        [WebMethod]
        public int DeleteStorage(string accEmail)
        {
            int accoID = GetAccountIDViaEmail(accEmail);
            List<Param> l = new List<Param>();
            l.Add(new Param("AccountID", accoID, SqlDbType.Int));
            int numDeleted = LoginDB.ExecuteNonQuery("DeleteAccountStorage", l);
            return numDeleted;
        }

        [WebMethod]
        public int IncreaseStorageSize(string email, int newSize)
        {
            int accoID = GetAccountIDViaEmail(email);
            List<Param> l = new List<Param>();
            l.Add(new Param("AccountID", accoID, SqlDbType.Int));
            l.Add(new Param("Capacity", newSize, SqlDbType.Int));
            int success = LoginDB.ExecuteNonQuery("IncreaseStorageCapacity", l);
            return success;
        }

        [WebMethod] 
        public DataSet GetInactiveFiles(string email)
        {
            int accoID = GetAccountIDViaEmail(email);
            List<Param> l = new List<Param>();
            l.Add(new Param("AccountID", accoID, SqlDbType.Int));
            return LoginDB.GetInactiveFiles(accoID);
        }

        [WebMethod]
        public int RestoreFile(int fileID)
        {
            List<Param> p = new List<Param>();
            p.Add(new Param("FileID", fileID, SqlDbType.Int));
            return LoginDB.ExecuteNonQuery("RestoreFile", p);
        }
    }
}