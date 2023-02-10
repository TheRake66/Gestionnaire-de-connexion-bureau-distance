using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTSC_Manager
{
    internal class Configuration
    {
        public List<Serveur> serveurs = new List<Serveur>();
        public Authentification authentificationGlobale = new Authentification();
        public Parametres parametres = new Parametres();
    }
}
