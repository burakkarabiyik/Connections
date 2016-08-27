using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connections
{
    public class MssqlConnection
    { 
        public SqlConnection baglantiolustur(string ComputerName, String dbName)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=" + ComputerName + ";Database=" + dbName + ";Integrated Security = True";
            conn.Open();
            return conn;
        }
        public SqlConnection  baglantiolustur(string ComputerName, string dbName,string username,string password)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=" + ComputerName + ";Database=" + dbName + ";User Id="+username+";Password ="+password+"; Integrated Security = True";
            conn.Open();
            return conn;
        }
        public string getData(string TableName)
        {
            string command = " SELECT *from" + TableName;
            return command;
        }
        public string getData(string TableName, string where, string sorgu)
        {
            string command = " SELECT *from" + TableName + " where " + where + "='" + sorgu + "'";
            return command;
        }
        public string getData(string TableName, string where, string sorgu,string where2,string sorgu2)
        {
            string command = " SELECT *from" + TableName + " where " + where + "='" + sorgu + "' and "+where2+"='"+sorgu2+"'";
            return command;
        }
        public string insert(string TableName,string variableName,string value)
        {
            string command= "insert into "+TableName+"("+variableName+") values (@"+value+")";
            return command;
        }
        public string update(string TableName, string variableName, string value,string where,string sorgu)
        {
            string command = "update "+TableName+" set "+variableName+"=@"+value+"where "+where+"=@"+sorgu;
            return command;
        }
        public string orderby(string from,string by)
        {
            string command = "SELECT * FROM "+from+" ORDER BY "+by;
            return command;
        }
        public string delete(string TableName,string columnName,string value)
        {
            string command = "DELETE FROM "+TableName+" WHERE "+columnName+" = '"+value+"'";
            return command;
        }
        public string createDb(string dbName)
        {
            string command = "CREATE DATABASE "+dbName;
            return command;
        }
    }

    
}
