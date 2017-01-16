﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechSupEDT.Modele
{
    public class EmploisDuTemps
    {
        private DateTime dateDebut;
        private DateTime dateFin;
        private List<Session> lstSessions;
        private Destinataire destinataire;
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
        public List<Session> LstSessions
        {
            get { return this.lstSessions; }
            set { this.lstSessions = value; }
        }
        public EmploisDuTemps(DateTime _dateDebut, DateTime _dateFin, Destinataire _dest)
        {
            this.DateDebut = _dateDebut;
            this.DateFin = _dateFin;
            this.Destinataire = _dest;
            this.LstSessions = this.Destinataire.GetSessions(this.DateDebut, this.DateFin);
        }
        public Destinataire Destinataire
        {
            get { return this.destinataire; }
            set { this.destinataire = value; }
        }
    }
}
