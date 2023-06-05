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
        public string INN { get; }
        public string KPP { get; }
        public string Address { get; }

        public string Type { get; }
        public string LegalEntity { get; }

        public Organization(string name,
                            string inn, 
                            string kpp, 
                            string address, 
                            string type, 
                            string legalEntity)
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
