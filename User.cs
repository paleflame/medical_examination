using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_examination
{
    public class User
    {
        public string Name { get; }
        public string Role { get; }
        public Organization Organization { get; }


        public User(string name,
                    //     string email, 
                    //    string password, 

                    string role,
                    Organization organization

            )
        {
            Name = name;
            Role = role;
            Organization = organization;


        }
    }
}
