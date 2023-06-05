using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_examination
{
    public static class AuthorisationService
    {
        public static User Login(string login, string password)
        {
            var dbResponse = DB.GetUserData(login, password);
                       

            if (dbResponse == null)
            {
                return null;
            } else
            {
                return CreateUser(dbResponse);
            }

            // тут вроде лучше поднять ошибку            
        }

        private static User CreateUser(Dictionary<string, string> userdata)
        {
            var role = DB.getRoleById((userdata["role"]));
            var organization = DB.getOrganizationById((userdata["organization"]));
            Organization org = new Organization(organization["name"], organization["kpp"], organization["inn"], organization["address"], organization["type_id"], organization["legal_entity"]);
            var user = new User( userdata["name"],
                             role,
                             org
                             );


            return user;
        }

        /*public static IDefinePermissions GetPM(User user)
        {
            return PMFactory.Get(user);
        }*/

    }
    class DataBase
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RDHJ1N2\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return conn;
        }
    }
}
