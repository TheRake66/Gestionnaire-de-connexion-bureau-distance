using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTSC_Manager
{
    internal class Serveur
    {
        public string nom = "";
        public string adresse = "";
        public string description = "";
        public bool utiliserAuthentificationGlobale = true;
        public Authentification authentification = new Authentification();
    }
}
