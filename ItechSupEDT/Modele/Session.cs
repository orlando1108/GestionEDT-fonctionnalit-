using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechSupEDT.Modele
{
    public class Session
    {
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private List<EmploisDuTemps> _listeEDT;
        private Promotion _promotion;
        private Matiere _matiere;
        private Formateur _formateur;
        private Salle _salle;

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
        public List<EmploisDuTemps> ListeEDT
        {
            get { return _listeEDT; }
            set { _listeEDT = value; }
        }
        public Promotion Promotion
        {
            get { return _promotion; }
            set { _promotion = value; }
        }
        public Matiere Matiere
        {
            get { return _matiere; }
            set { _matiere = value; }
        }
        public Formateur Formateur
        {
            get { return _formateur; }
            set { _formateur = value; }
        }
        public Salle Salle
        {
            get { return _salle; }
            set { _salle = value; }
        }
        public Session(DateTime dateDebut, DateTime dateFin, Promotion promo, Matiere matiere, Salle salle, Formateur formateur = null)
        {
            this._dateDebut = dateDebut;
            this._dateFin = dateFin;
            this._promotion = promo;
            this._matiere = matiere;
            this._salle = salle;

            if(formateur != null)
            {
                this._formateur = formateur;
            }
        }
       
    }
}
