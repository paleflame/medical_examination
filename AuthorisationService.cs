using System;
using System.Collections.Generic;
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

            if (dbResponse != null)
            {
                return CreateUser(dbResponse);
            }

            // тут вроде лучше поднять ошибку
            return null;
        }

        private static User CreateUser(Dictionary<string, string> userdata)
        {
            return new User( userdata["name"], 
                             userdata["role"]
                             //userdata["organization"]
                             );
        }

        public static IDefinePermissions GetPM(User user)
        {
            return PMFactory.Get(user);
        }

    }
}
