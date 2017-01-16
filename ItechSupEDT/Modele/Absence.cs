using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechSupEDT.Modele
{
    public class Absence
    {
        private Eleve _eleve;
        private Session _session;

        public Eleve Eleve
        {
            get { return _eleve; }
            set { _eleve = value; }
        }
        public Session Session
        {
            get { return _session; }
            set { _session = value; }
        }
        public Absence(Eleve eleve, Session session)
        {
            this._eleve = eleve;
            this._session = session;
        }
    }
}
