using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_examination
{
    // статичный класс для работы с БД
    public static class DB
    {
        public static string connectionAddress = "";

        public static void DeleteCard(Pet pet)
        {
            dataBase.Pet.Remove(pet);
            dataBase.SaveCahges();
        }


        // тут должен быть метод поиска пользователя в БД
        public static Dictionary<string, string> GetUserData(string login, string password)
        {
            return new Dictionary<string, string> {
                { "name", "Данил Василенко" },
                { "organization", "Газпром" },
                { "role", "Ветеринар" }

            };
        }

    }
}
