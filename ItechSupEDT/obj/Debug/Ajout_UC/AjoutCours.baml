   M S B A M L   `   `   `  ����F  BItechSupEDT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ItechSupEDT.Ajout_UCItechSupEDT.Ajout_UC  5      %    ItechSupEDT.Ajout_UC.AjoutCours   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:ItechSupEDT.Ajout_UC     5      .��5	      �� $��	0,0,0,-15q�6   .+�5
   
   �� $��Ajouter une Session��6   $��Center=�6/   �� 5   
   $��Center=�6   $��Center=�62     �� Orientation$  
Horizontal=�6M   .+�5      �� $��Date de début :��6   $��
10,10,0,10q�6/   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dp_dateDebut��5      $��
10,10,0,10q�6/   5      �� 5   
   $��Center=�6   $��Center=�62   $  
Horizontal=�6M   .+�5      �� $��Date de fin :��6   $��
25,10,0,10q�6-     5      -   5        $ 
dp_dateFin��5      $��
10,10,0,10q�6-   5      �� 5   
   $��Center=�6   $��Center=�62   $  
Horizontal=�6M   .+�5      �� $��Formateurs :��6   $��
10,10,0,10q�6,   �� 5      -   5         ��Name$ cb_listeFormateurs��5      $��
10,10,0,10q�63   5      �� 5   
   $��Center=�6   $��Center=�62   $  
Horizontal=�6M   .+�5      �� $��Promotions :��6   $��
10,10,0,10q�6,   �� 5      -   5        $ cb_listePromotions��5      $��
10,10,0,10q�63   5      �� 5   
   $��Center=�6   $��Center=�62   $  
Horizontal=�6M   .+�5      �� $��Salles :��6   $��
38,10,0,10q�6(   �� 5      -   5        $ cb_listeSalles��5      $��
10,10,0,10q�6/   5      �� 5   
   $��Center=�6   $��Center=�62   $  
Horizontal=�6M   .+�5       �� $��
Matieres :��6   $��
20,10,0,10q�6*   �� 5!      -   5        $ cb_listeMatieres��5!      $��
10,10,0,10q�61   5"      �� 5#   
   -   5         ��Name$ 	btn_ajout��5#   #   $��Ajouter��6   $��80��66   $��20q�6Y   6g   �� 5$   
   .+�5%      �� -   5         ��Name$ tbk_errorMessage��5%      5&      5'      5(      