using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechSupEDT.Modele
{
    public class Formation
    {
        private String _nom;
        private float _nbHeuresTotal;
        private List<Promotion> _lstPromotions;
        private List<Matiere> _lstMatiere;
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
        public float NbHeuresTotal
        {
            get { return _nbHeuresTotal; }
            set { _nbHeuresTotal = value; }
        }
        public List<Promotion> ListePromotions
        {
            get { return _lstPromotions; }
            set { _lstPromotions = value; }
        }
        public List<Matiere> ListetMatiere
        {
            get { return _lstMatiere; }
            set { _lstMatiere = value; }
        }
        public Formation(String nom, float nbHeuresTotal, int id = 0, List<Matiere> listeMatieres = null)
        {
            this._id = id;
            this._nom = nom;
            this._nbHeuresTotal = nbHeuresTotal;
         
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
