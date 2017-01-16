﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechSupEDT.Modele
{
    public class Formation
    {
        private String nom;
        private float nbHeuresTotal;
        private List<Promotion> lstPromotions;
        private List<Matiere> lstMatiere;
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
        public float NbHeuresTotal
        {
            get { return this.nbHeuresTotal; }
            set { this.nbHeuresTotal = value; }
        }
        public List<Promotion> LstPromotions
        {
            get { return this.lstPromotions; }
            set { this.lstPromotions = value; }
        }
        public List<Matiere> LstMatiere
        {
            get { return this.lstMatiere; }
            set { this.lstMatiere = value; }
        }
        public Formation(String _nom, float _nbHeuresTotal, int id = 0)
        {
            this._id = id;
            this.Nom = _nom;
            this.NbHeuresTotal = _nbHeuresTotal;
         
            //this.LstPromotions = new List<Promotion>();

        }
        public Formation(String _nom, float _nbHeuresTotal, List<Matiere> _lstMatiere)
        {
            this.Nom = _nom;
            this.NbHeuresTotal = _nbHeuresTotal;
            this.LstMatiere = _lstMatiere;
            //this.LstPromotions = new List<Promotion>();
        }
        public class FormationException : Exception
        {
            public FormationException(string message) : base(message)
            {
            }
        }
    }
}
