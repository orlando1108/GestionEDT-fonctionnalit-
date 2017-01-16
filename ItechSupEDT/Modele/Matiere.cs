using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechSupEDT.Modele
{
    public class Matiere : Nameable
    {
        private String _nom;
        private List<Formation> _listeFormations;
        private List<Session> _listeSessions;
        private List<Formateur> _listeFormateurs;
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
        public List<Formation> LstFormations
        {
            get { return _listeFormations; }
            set { _listeFormations = value; }
        }
        public List<Session> LstSessions
        {
            get { return _listeSessions; }
            set { _listeSessions = value; }
        }
        public List<Formateur> LstFormateurs
        {
            get { return _listeFormateurs; }
            set { _listeFormateurs = value; }
        }
        public Matiere(String _nom, int id = 0)
        {
            this.Nom = _nom;
            this._listeSessions = new List<Session>();
            this._listeFormateurs = new List<Formateur>();
            this._listeFormations = new List<Formation>();

            if(id != 0)
            {
                this._id = id;
            }
            
        }

        public String getNom()
        {
            return _nom;
        }
    }
}
