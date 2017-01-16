using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechSupEDT.Modele
{
    public class Formateur : Destinataire
    {
        private String _nom;
        private String _prenom;
        private String _mail;
        private String _telephone;
        private List<Matiere> _listeMatiere;
        private List<Session> _listeSessions;
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public String Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public String Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public String Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        public List<Matiere> LstMatiere
        {
            get { return _listeMatiere; }
            set { _listeMatiere = value; }
        }
        public List<Session> ListeSessions
        {
            get { return _listeSessions; }
            set { _listeSessions = value; }
        }
        public Formateur(String nom, String prenom, String mail, String telephone, List<Matiere> listeMatiere = null, int id =0)
        {
            
            this._nom = nom;
            this._prenom = prenom;
            this._mail = mail;
            this._telephone = telephone;
            this._listeMatiere = listeMatiere;
            this._id = id;

            this._listeSessions = new List<Session>();
            
        }
        public float NbHeuresTravaillees(DateTime _dateDebut, DateTime _dateFin)
        {
            float nbHeuresTravaillees = 0;
            foreach (Session session in _listeSessions)
            {
                if (session.DateDebut > _dateDebut && session.DateFin < _dateFin)
                {
                    nbHeuresTravaillees += (float)(session.DateFin.Subtract(session.DateDebut).TotalHours);
                }
            }
            return nbHeuresTravaillees;
        }
        public bool EstDisponible(DateTime _dateDebut, DateTime _dateFin)
        {
            bool disponible = true;
            foreach (Session session in _listeSessions)
            {
                bool conflitDebut = (_dateDebut > session.DateDebut) && (_dateDebut < session.DateFin);
                bool conflitFin = (_dateFin > session.DateDebut) && (_dateFin < session.DateFin);
                if (conflitDebut || conflitFin)
                {
                    disponible = false;
                }
            }
            return disponible;
        }
        List<Session> Destinataire.GetSessions(DateTime _dateDebut, DateTime _dateFin)
        {
            List<Session> newListeSessions = new List<Session>();
            foreach (Session session in _listeSessions)
            {
                if (session.DateDebut > _dateDebut && session.DateFin < _dateFin)
                {
                    newListeSessions.Add(session);
                }
            }
            return newListeSessions;
        }
        public class FormateurException : Exception
        {
            public FormateurException(string message) : base(message)
            {
            }
        }
    }
}
