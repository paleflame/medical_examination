using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_examination
{
    public interface IDefinePermissions
    {
        public bool CanReadAnimal { get; }
        public bool CanEditAnimal { get; }
       
        public bool CanReadOrganization { get; }
        public bool CanEditOrganization { get; }

        public bool CanReadConctract { get; }
        public bool CanEditConctract { get;}
    }
}
