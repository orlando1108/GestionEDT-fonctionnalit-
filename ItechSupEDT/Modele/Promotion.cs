using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechSupEDT.Modele
{
    public class Promotion : Destinataire, Nameable
    {
        private String _nom;
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private List<Eleve> _listeEleves;
        private int _idFormation;
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
        public List<Eleve> ListeEleves
        {
            get { return _listeEleves; }
            set {
                if (_listeEleves.Count == 24)
                {
                    throw new PromotionException("La promotion est complète");
                }
                _listeEleves = value;
                }
        }
        public int Id_Formation
        {
            get { return _idFormation; }
            set { _idFormation = value; }
        }
        public List<Session> LstSessions
        {
            get { return this._listeSessions; }
            set { _listeSessions = value; }
        }
        public Promotion(String nom, DateTime dateDebut, DateTime dateFin, int idformation, int id = 0)
        {
            this._nom = nom;
            this._dateDebut = dateDebut;
            this._dateFin = dateFin;
            this._idFormation = idformation;
            this._id = id;
           // this.LstSessions = new List<Session>();
          
        }

       
        public bool EstDisponible(DateTime _dateDebut, DateTime _dateFin)
        {
            bool disponible = true;
            foreach (Session session in this.LstSessions)
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
            List<Session> lstSessions = new List<Session>();
            foreach (Session session in this.LstSessions)
            {
                if (session.DateDebut > _dateDebut && session.DateFin < _dateFin)
                {
                    lstSessions.Add(session);
                }
            }
            return lstSessions;
        }

        public string getNom()
        {
            return _nom;
        }

        public class PromotionException : Exception
        {
            public PromotionException(string message) : base(message)
            {
            }
        }
    }
}
