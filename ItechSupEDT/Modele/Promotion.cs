﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechSupEDT.Modele
{
    public class Promotion : Destinataire, Nameable
    {
        private String nom;
        private DateTime dateDebut;
        private DateTime dateFin;
        private List<Eleve> lstEleves;
        private int id_Formation;
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
        public DateTime DateDebut
        {
            get { return this.dateDebut; }
            set { this.dateDebut = value; }
        }
        public DateTime DateFin
        {
            get { return this.dateFin; }
            set { this.dateFin = value; }
        }
        public List<Eleve> LstEleves
        {
            get { return this.lstEleves; }
            set {
                if (this.lstEleves.Count == 24)
                {
                    throw new PromotionException("La promotion est complète");
                }
                this.lstEleves = value;
                }
        }
        public int Id_Formation
        {
            get { return id_Formation; }
            set { id_Formation = value; }
        }
        public List<Session> LstSessions
        {
            get { return this.lstSessions; }
            set { this.lstSessions = value; }
        }
        public Promotion(String _nom, DateTime _dateDebut, DateTime _dateFin, int idformation, int id = 0)
        {
            this.Nom = _nom;
            this.DateDebut = _dateDebut;
            this.DateFin = _dateFin;
            this.Id_Formation = idformation;
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
            return this.nom;
        }

        public class PromotionException : Exception
        {
            public PromotionException(string message) : base(message)
            {
            }
        }
    }
}
