   M S B A M L   `   `   `  ����G  Crs12-2011.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:rs12_2011.UI.ViewModelrs12_2011.UI.ViewModel  5   	   ,    &rs12_2011.UI.UIComponents.AkcijeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3vm$clr-namespace:rs12_2011.UI.ViewModel     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ Akcije u Salonu Namestaja��5	   	   $	��400��6+   $	��450��68   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      $
��auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
AkcijeGrid��5   %      
IsReadOnly .    CanUserAddRows .  ��67   �� *Akcije+6m   �� 5   
   $��1��6    �� Orientation$ Vertical=�6"   .+�5      �� $��18(�6   $��3��6&   $��Popusti:��63   $��Center=�6C   $
��Left=�6^     5      $��4��6   $��0��6$   $��2��64      AutoGenerateColumns .  ��6H   �� *SelektovaniPopusti+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Sifra��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 68   
   CanUserResize
 .     CanUserReorder .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *Item1+6r     5      $ Kolicina��6)   $	 * 6;   
 .   .   6E   �� *Item2+6u   5      5      �� 5   
   $��2��6   $ 
Horizontal=�6"   .+�5      �  5      �� 5      $��50 �6$   .+�5!      �� $ 
Horizontal=�6   .+�5"      �� -   5        $��
NovaAkcija��5"   )   $��10q�6   $��Nova Akcija��6;   6Q   �� 5#      -   5        $��ObrisiAkcija��5#   )   $��10q�6   $��Obrisi Akciju��6=   6U   �� 5$      -   5        $��IzmeniAkcija��5$   )   $��10q�6   $��Izmeni Akciju��6=   6U   �� 5%      -   5        $��Izlaz��5%   3   $��120,10,10,10q�6   $��Izlaz��6@   6P   5&      5'      5(      5*      5+      