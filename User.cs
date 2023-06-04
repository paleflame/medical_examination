using System;

namespace medical_examination
{
    internal class User
    {
<<<<<<< Updated upstream
        public string Name;
        public string Login;
        public string Email;
        public string Password;
        public Organization Organization;
        public Role Role;
        public static void Select(Dictionary<string,string[]> userFilter)
        {
            //void убрать, пока что не получилось добавить тип SqlDataReader
=======
        public string Name { get; }
        //public string Email { get; }
        // public string Password { get; }
        public string Role { get; }
        //public Organization Organization { get; }

        public User(string name,
                    //     string email, 
                    //    string password, 
                    string role
            //Organization organization
            )
        {
            Name = name;
            //Email = email;
            // Password = password;
            Role = role;
            //Organization = organization;

>>>>>>> Stashed changes
        }
    }
}
