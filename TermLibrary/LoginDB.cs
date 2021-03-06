﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TermLibrary
{
    public class LoginDB
    {
        static DBConnect objdb = new DBConnect();
        static SqlCommand objcmd;

        public static List<Param> BuildNewAccountParams(object[] param)
        {
            List<Param> p = new List<Param>();
            p.Add(new Param("LastName", param[0], SqlDbType.VarChar));
            p.Add(new Param("FirstName", param[1], SqlDbType.VarChar));
            p.Add(new Param("Email", param[2], SqlDbType.VarChar));
            p.Add(new Param("Passwd", param[3], SqlDbType.VarChar));
            return p;
        }

        public static List<Param> BuildNewCookieParams(string[] param)
        {
            List<Param> p = new List<Param>();
            p.Add(new Param("Email", param[0], SqlDbType.VarChar));
            p.Add(new Param("Cookie", param[1], SqlDbType.VarChar));
            return p;
        }

        public static List<Param> BuildNewLoginParams(string[] param)
        {
            List<Param> p = new List<Param>();
            p.Add(new Param("Email", param[0], SqlDbType.VarChar));
            p.Add(new Param("Passwd", param[1], SqlDbType.VarChar));
            return p;
        }


        public static List<Param> BuildNewFileDataParams(int fileID, object[] param, int accoID)

        {
            List<Param> p = new List<Param>();
            p.Add(new Param("FileID", fileID, SqlDbType.Int));
            p.Add(new Param("Name", param[0], SqlDbType.VarChar));
            p.Add(new Param("FileType", param[1], SqlDbType.VarChar));
            p.Add(new Param("DateUploaded", param[2], SqlDbType.DateTime));
            p.Add(new Param("DateModified", param[3], SqlDbType.DateTime));
            p.Add(new Param("FileSize", param[4], SqlDbType.Int));

            p.Add(new Param("AccountID", accoID, SqlDbType.Int));

            return p;
        }

        public static List<Param> BuildNewTransactionParams(int fileID, int accoID, object[] param)
        {
            List<Param> p = new List<Param>();
            p.Add(new Param("TransactionDateTime", param[3], SqlDbType.DateTime));

            p.Add(new Param("UploadDownload", new byte[1] { Convert.ToByte(param[6]) }, SqlDbType.Binary));

            p.Add(new Param("FileID", fileID, SqlDbType.Int));
            p.Add(new Param("AccountID", accoID, SqlDbType.Int));
            return p;
        }

        public static List<Param> BuildNewUpdateStorageParams(int accoID, int fileSize)
        {
            List<Param> p = new List<Param>();
            p.Add(new Param("AccountID", accoID, SqlDbType.Int));
            p.Add(new Param("FileSize", fileSize, SqlDbType.Int));
            return p;
        }


        public static List<Param> BuildNewUpdateFileParams(object[] data, byte[] filecontent, int accoID)
        {
            List<Param> p = new List<Param>();
            p.Add(new Param("FileDataID", data[0], SqlDbType.Int));
            p.Add(new Param("FileContent", filecontent, SqlDbType.VarBinary));
            p.Add(new Param("Name", data[2], SqlDbType.VarChar));
            p.Add(new Param("DateModified", data[3], SqlDbType.DateTime));
            p.Add(new Param("FileSize", data[4], SqlDbType.Int));
            p.Add(new Param("TransactionDateTime", data[5], SqlDbType.DateTime));
            p.Add(new Param("UploadDownload", new byte[1] { Convert.ToByte(data[6]) }, SqlDbType.Binary));
            p.Add(new Param("AccountID", accoID, SqlDbType.Int));
            p.Add(new Param("FileType", data[7], SqlDbType.VarChar));
            return p;
        }


        public static int ExecuteNonQuery(string procedure, List<Param> paramList)
        {
            objcmd = new SqlCommand();
            objcmd.CommandType = System.Data.CommandType.StoredProcedure;
            objcmd.CommandText = procedure;

            foreach (Param p in paramList)
            {
                SqlParameter inputParam = new SqlParameter(p.paramName, p.paramVal);
                inputParam.Direction = ParameterDirection.Input;
                inputParam.SqlDbType = p.paramType;
                objcmd.Parameters.Add(inputParam);
            }

            return objdb.DoUpdateUsingCmdObj(objcmd);
        }

        public static string[] GetAccountInfo(string email)
        {
            objcmd = new SqlCommand();
            objcmd.CommandType = CommandType.StoredProcedure;
            objcmd.CommandText = "GetTermAccountInfo";

            SqlParameter inputParam = new SqlParameter("Email", email);
            inputParam.Direction = ParameterDirection.Input;
            inputParam.SqlDbType = SqlDbType.VarChar;
            objcmd.Parameters.Add(inputParam);

            DataSet results = objdb.GetDataSetUsingCmdObj(objcmd);
            string[] accInfo = new string[4]
            {
                //results.Tables[0].Rows[0][0].ToString(),
                results.Tables[0].Rows[0][1].ToString(),
                results.Tables[0].Rows[0][2].ToString(),
                results.Tables[0].Rows[0][3].ToString(),
                results.Tables[0].Rows[0][4].ToString()
                //results.Tables[0].Rows[0][5].ToString(),
            };
            return accInfo;
        }

        public static List<Param> BuildUpdateAccountParams(object[] param, int accoID)
        {
            List<Param> p = new List<Param>();
            p.Add(new Param("AccountID", accoID, SqlDbType.Int));
            p.Add(new Param("LastName", param[0], SqlDbType.VarChar));
            p.Add(new Param("FirstName", param[1], SqlDbType.VarChar));
            p.Add(new Param("Email", param[2], SqlDbType.VarChar));
            p.Add(new Param("Passwd", param[3], SqlDbType.VarChar));
            return p;
        }

        public static DataSet GetTransactions(List<Param> p)
        {
            objcmd = new SqlCommand();
            objcmd.CommandType = CommandType.StoredProcedure;
            objcmd.CommandText = "GetTransactionHistory";

            foreach (Param x in p)
            {
                SqlParameter inputParam = new SqlParameter(x.paramName, x.paramVal);
                inputParam.Direction = ParameterDirection.Input;
                inputParam.SqlDbType = x.paramType;
                objcmd.Parameters.Add(inputParam);
            }

            return objdb.GetDataSetUsingCmdObj(objcmd);
        }

        public static DataSet GetAllAccounts()
        {
            return objdb.GetDataSet("SELECT TermAccount.Email, TermStorage.Capacity, TermAccount.Passwd " 
                                    + "FROM TermAccount INNER JOIN TermStorage ON TermAccount.AccountID = TermStorage.AccountID " 
                                    + "WHERE TermAccount.IsActive = 1 AND TermAccount.AdminLevel = 0;");
        }

        public static int ExecuteQuery(string procedure, List<Param> paramList)
        {
            objcmd = new SqlCommand();
            objcmd.CommandType = CommandType.StoredProcedure;
            objcmd.CommandText = procedure;

            foreach (Param p in paramList)
            {
                SqlParameter inputParam = new SqlParameter(p.paramName, p.paramVal);
                inputParam.Direction = ParameterDirection.Input;
                inputParam.SqlDbType = p.paramType;
                objcmd.Parameters.Add(inputParam);
            }


            try
            {
                DataSet results = objdb.GetDataSetUsingCmdObj(objcmd);
                int x = Convert.ToInt32(results.Tables[0].Rows[0][0]);
                int retval = Convert.ToInt32(x);
                return retval;
            } catch (Exception ex)
            {
                //failed
                return 0;
            }        
            
        }

        public static DataSet GetAdminActivity()
        {
            return objdb.GetDataSet("SELECT * FROM AdminActivity");
        }

        public static DataSet GetInactiveFiles(int accoID)
        {
            objcmd = new SqlCommand();
            objcmd.CommandType = CommandType.StoredProcedure;
            objcmd.CommandText = "GetInactiveFilesWithAccountID";

            SqlParameter inputParam = new SqlParameter("AccountID", accoID);
            inputParam.Direction = ParameterDirection.Input;
            inputParam.SqlDbType = SqlDbType.Int;
            objcmd.Parameters.Add(inputParam);

            DataSet results = objdb.GetDataSetUsingCmdObj(objcmd);

            return results;
        }

        public static DataSet GetFileData(int id)
        {
            objcmd = new SqlCommand();
            objcmd.CommandType = CommandType.StoredProcedure;
            objcmd.CommandText = "GetFilesWithAccountID";

            SqlParameter inputParam = new SqlParameter("AccountID", id);
            inputParam.Direction = ParameterDirection.Input;
            inputParam.SqlDbType = SqlDbType.Int;
            objcmd.Parameters.Add(inputParam);

            DataSet results = objdb.GetDataSetUsingCmdObj(objcmd);

            return results;
        }

        public static byte[] GetFile(int id)
        {
            objcmd = new SqlCommand();
            objcmd.CommandType = CommandType.StoredProcedure;
            objcmd.CommandText = "GetFileContentWithFileID";

            SqlParameter inputParam = new SqlParameter("FileID", id);
            inputParam.Direction = ParameterDirection.Input;
            inputParam.SqlDbType = SqlDbType.Int;
            objcmd.Parameters.Add(inputParam);

            DataSet data = objdb.GetDataSetUsingCmdObj(objcmd);

            byte[] binaryDataResult = null;
            using (MemoryStream memStream = new MemoryStream())
            {
                BinaryFormatter brFormatter = new BinaryFormatter();
                data.RemotingFormat = SerializationFormat.Binary;
                brFormatter.Serialize(memStream, data.Tables[0].Rows[0][0]);
                binaryDataResult = memStream.ToArray();
            }
            return binaryDataResult;
        }
    }
}