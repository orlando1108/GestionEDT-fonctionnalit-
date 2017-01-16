using ItechSupEDT.Ajout_UC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechSupEDT.Modele
{
    public class Eleve : Nameable
    {
        private String _nom;
        private String _prenom;
        private String _mail;
        private Promotion _promotion;
        private List<Absence> _lstAbsences;
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
        public Promotion Promotion
        {
            get { return _promotion; }
            set { _promotion = value; }
        }
        public List<Absence> ListeAbsences
        {
            get { return _lstAbsences; }
            set { _lstAbsences = value; }
        }
        public Eleve(String nom, String prenom, String mail, Promotion promo)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._mail = mail;
            this._promotion = promo;
            this._lstAbsences = new List<Absence>();
        }
        public int GetNbAbsence(DateTime dateDebut, DateTime dateFin)
        {
            return this.ListeAbsences.Count;
        }
        string Nameable.getNom()
        {
            return this.Nom;
        }
    }
}
