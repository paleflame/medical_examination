using System;

namespace medical_examination
{
    internal class User
    {
        public string Name;
        public string Login;
        public string Email;
        public string Password;
        public Organization Organization;
        public Role Role;
        public static void Select(Dictionary<string,string[]> userFilter)
        {
            //void убрать, пока что не получилось добавить тип SqlDataReader
        }
    }
}
