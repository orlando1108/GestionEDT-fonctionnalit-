using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechSupEDT.Modele
{
    public class EmploisDuTemps
    {
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private List<Session> _listeSessions;
        private Destinataire _destinataire;
        public DateTime DateDebut
        {
            get { return _dateDebut; }
            set { _dateDebut = value; }
        }
        public DateTime DateFin
        {
            get { return _dateFin; }
            set { _dateFin = value; }
        }
        public List<Session> ListeSessions
        {
            get { return _listeSessions; }
            set { _listeSessions = value; }
        }
        public EmploisDuTemps(DateTime dateDebut, DateTime dateFin, Destinataire destinataire)
        {
            this._dateDebut = dateDebut;
            this._dateFin = dateFin;
            this._destinataire = destinataire;
            this._listeSessions = this.Destinataire.GetSessions(this.DateDebut, this.DateFin);
        }
        public Destinataire Destinataire
        {
            get { return this._destinataire; }
            set { this._destinataire = value; }
        }
    }
}
