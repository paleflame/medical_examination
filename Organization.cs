using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace medical_examination
{
    public class Organization
    {
        public string Name { get; }
        public int INN { get; }
        public int KPP { get; }
        public string Address { get; }

        public string Type { get; }
        public bool LegalEntity { get; }

        public Organization(string name,
                            int inn, 
                            int kpp, 
                            string address, 
                            string type, 
                            bool legalEntity)
        {
            Name = name;
            INN = inn;
            KPP = kpp;
            Address = address;
            Type = type;
            LegalEntity = legalEntity;

        }


    }
}
