using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;

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
            p.Add(new Param("IsAdmin", Convert.ToBoolean(param[4]), SqlDbType.Bit));
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
            SqlConnection c =objdb.GetConnection();
            c.Open();
            Object x = DBConnect.ExecuteScalarFunction(objcmd);
            c.Close();
            int retval = Convert.ToInt32(x);
            return retval;
        }
    }
}
