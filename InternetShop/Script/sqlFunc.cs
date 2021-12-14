using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Script
{
    class sqlFunc
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

        public static MySqlConnection GetDBConnection()
        {
            string host = "c9113991.beget.tech";
            int port = 3306;
            string database = "c9113991_ishop";
            string username = "c9113991_ishop";
            string password = "Polina228";

            return GetDBConnection(host, port, database, username, password);
        }



        MySqlConnection conn = GetDBConnection();


        public bool LoginUser(string login, string password)
        {
            bool flag = false;

            string sql = String.Format("SELECT * FROM users WHERE login = @uL AND pass = @uP;");
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;
            conn.Open();
            MySqlDataReader sqldr = command.ExecuteReader();

            if (sqldr.HasRows)
                flag = true;

            conn.Close();

            return flag;
        }


        public bool RegUser(string id, string login, string password, string name, string phone)
        {

            bool flag = false;


            string sql = String.Format("INSERT INTO users(id_user,name,phone,login,pass) VALUES (@uId,@uName, @uPhone, @uLogin,@uPass)");

            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uId", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@uName", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@uPhone", MySqlDbType.VarChar).Value = phone;

            conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
                conn.Close();
            }
            return flag;
            
        }





    }
}
