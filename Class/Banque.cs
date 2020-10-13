using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCompteBancaire.Class
{
    class Banque
    {
        private List<Compte> _mesComptes;

        public Banque()
        {
            this._mesComptes = new List<Compte>();
        }
    }
}
