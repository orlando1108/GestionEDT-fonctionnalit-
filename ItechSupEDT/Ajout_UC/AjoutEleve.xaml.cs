﻿using ItechSupEDT.Modele;
using ItechSupEDT.Outils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ItechSupEDT.Ajout_UC
{
    /// <summary>
    /// Interaction logic for AjoutEleve.xaml
    /// </summary>
    public partial class AjoutEleve : UserControl
    {
        private Dictionary<String, Promotion> lstPromotions;
        public Dictionary<String, Promotion> LstPromotions
        {
            get { return this.lstPromotions; }
            set { this.lstPromotions = value; }
        }
        public AjoutEleve(List<Promotion> _lstPromotions)
        {
            InitializeComponent();
            this.lstPromotions = new Dictionary<string, Promotion>();
            if (_lstPromotions.Count > 0)
            {
                foreach (Promotion promotion in _lstPromotions)
                {
                    this.lstPromotions.Add(promotion.Nom, promotion);
                }
                this.cb_lstPromotions.ItemsSource = this.LstPromotions.Keys;
                this.cb_lstPromotions.SelectedIndex = 0;
            }
        }

        private void btn_ajout_Click(object sender, RoutedEventArgs e)
        {
            Promotion promotion = lstPromotions[cb_lstPromotions.SelectedItem.ToString()];

            if(!String.IsNullOrEmpty(tb_nom.Text) &&
               !String.IsNullOrEmpty(tb_prenom.Text)&&
               !String.IsNullOrEmpty(tb_mail.Text)&&
               promotion != null)
            {
                DataInsert.AjouterEleve(tb_nom.Text, tb_prenom.Text, tb_mail.Text, promotion);
            }else
            {
                throw new Exception("veuillez renseigner les champs correctement ! ");
            }
        }
         
      
    }
}
