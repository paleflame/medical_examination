using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_examination
{
    public class PermissionManager
    {
        public User User { get; }
        public bool CanReadAnimal { get; }
        public bool CanEditAnimal { get; }
        public bool CanReadAllAnimals { get; }

        public bool CanReadOrganization { get; }
        public bool CanEditOrganization { get; }
        public string OrganizationTypesToEdit { get; }

        public bool CanReadConctract { get; }

        // редактировать контракты можно только в рамках омсу
        public bool CanEditConctract { get; }

        public PermissionManager(User user)

        {
            string role = user.Role;
            string[] roles = { "Куратор ВетСлужбы", 
                               "Куратор по отлову", 
                               "Куратор приюта",
                               "Оператор ВетСлужбы",
                               "Оператор по отлову",
                               "Подписант ВетСлужбы",
                               "Подписант по отлову",
                               "Подписант приюта",
                               "Куратор ОМСУ",
                               "Оператор ОМСУ",
                               "Подписант ОМСУ",
                               "Оператор приюта",
                               "Ветврач",
                               "Ветврач приюта"




            };
            /*if (roles.Contains())
            {

            }*/

        }

    }
}
