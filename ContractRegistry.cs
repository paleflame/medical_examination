﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_examination
{
    internal class ContractRegistry
    {
        public static void Select(Dictionary<string, string[]> filterNames, Dictionary<string, string[]> sortNames)
        {
            //void убрать, пока что не получилось добавить тип SqlDataReader
        }

        public static void Select(long id)
        {
            //void убрать, пока что не получилось добавить тип SqlDataReader
        }

        public static Array GetContracts(Array data)
        {
            return data;
        }

        public static Array Create(Array data)
        {
            return data;
        }

        public static void Insert(Array data)
        {
            //void убрать, пока что не получилось добавить тип SqlDataReader
        }

        public static void Delete(long cardNumber)
        {
            //void убрать, пока что не получилось добавить тип SqlDataReader
        }

        public static void Update(long id, string[] data)
        {
            //void убрать, пока что не получилось добавить тип SqlDataReader
        }
    }
}
