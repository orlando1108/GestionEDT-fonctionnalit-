﻿#pragma checksum "..\..\..\Ajout_UC\AjoutEleve.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4E2C942375AA22F245FB7DC912734AA5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ItechSupEDT.Ajout_UC;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ItechSupEDT.Ajout_UC {
    
    
    /// <summary>
    /// AjoutEleve
    /// </summary>
    public partial class AjoutEleve : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Ajout_UC\AjoutEleve.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_nom;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Ajout_UC\AjoutEleve.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_prenom;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Ajout_UC\AjoutEleve.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_mail;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Ajout_UC\AjoutEleve.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_lstPromotions;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Ajout_UC\AjoutEleve.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ajout;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ItechSupEDT;component/ajout_uc/ajouteleve.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ajout_UC\AjoutEleve.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tb_nom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tb_prenom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_mail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cb_lstPromotions = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btn_ajout = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Ajout_UC\AjoutEleve.xaml"
            this.btn_ajout.Click += new System.Windows.RoutedEventHandler(this.btn_ajout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
