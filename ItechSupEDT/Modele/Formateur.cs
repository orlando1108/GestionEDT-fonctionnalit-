﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechSupEDT.Modele
{
    public class Formateur : Destinataire
    {
        private String nom;
        private String prenom;
        private String mail;
        private String telephone;
        private List<Matiere> lstMatiere;
        private List<Session> lstSessions;
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public String Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        public String Mail
        {
            get { return this.mail; }
            set { this.mail = value; }
        }
        public String Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }
        public List<Matiere> LstMatiere
        {
            get { return this.lstMatiere; }
            set { this.lstMatiere = value; }
        }
        public List<Session> LstSessions
        {
            get { return this.lstSessions; }
            set { this.lstSessions = value; }
        }
        public Formateur(String _nom, String _prenom, String _mail, String _telephone, List<Matiere> _lstMatiere = null, int id =0)
        {
            
            this.Nom = _nom;
            this.Prenom = _prenom;
            this.Mail = _mail;
            this.Telephone = _telephone;
            this.LstMatiere = _lstMatiere;
            this.LstSessions = new List<Session>();
            this._id = id;
        }
        public float NbHeuresTravaillees(DateTime _dateDebut, DateTime _dateFin)
        {
            float nbHeuresTravaillees = 0;
            foreach (Session session in this.LstSessions)
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
        public class FormateurException : Exception
        {
            public FormateurException(string message) : base(message)
            {
            }
        }
    }
}
