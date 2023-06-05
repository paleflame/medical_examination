using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace medical_examination
{
    // статичный класс для работы с БД
    public static class DB
    {
        

        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RDHJ1N2\SQLEXPRESS;Initial Catalog=medical_examination;Integrated Security=True");

        // тут должен быть метод поиска пользователя в БД
        public static Dictionary<string, string> GetUserData(string login, string password)
        {
            openConnection();

            string query = $"select * from [User] where name='{login}' and password='{password}'";
            SqlCommand command = new SqlCommand(query, getConnection());
            SqlDataReader reader = command.ExecuteReader();

            
            if (reader.HasRows)
            {
                reader.Read();                
                var result = new Dictionary<string, string>
                {
                    {"name", reader.GetValue(1).ToString()},
                    {"organization", reader.GetValue(4).ToString()},
                    {"role", reader.GetValue(5).ToString()}
                };
                reader.Close();
                return result;
            }
            else
            {
                return null;
            }
        }

        

        public static void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public static SqlConnection getConnection()
        {
            return conn;
        }

        public static string getRoleById(string id)
        {
            openConnection();
            string query = $"select name from [Role] where role_id='{id}'";
            SqlCommand command = new SqlCommand(query, getConnection());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                var result = reader.GetValue(0).ToString();               
                reader.Close();
                return result;
            }
            else
            {
                return null;
            }
        }
        public static Dictionary<string,string> getOrganizationById(string id)
        {
            openConnection();
            string query = $"select * from [Organization] where organization_id='{id}'";
            SqlCommand command = new SqlCommand(query, getConnection());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {

/*                name
inn
kpp
address
type
legalEntity*/

                reader.Read();
                var result = new Dictionary<string, string>();
                
                for(int i = 1; i < reader.FieldCount; i++)
                {
                    result[reader.GetName(i)] = reader.GetValue(i).ToString();
                }                    

                reader.Close();
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
