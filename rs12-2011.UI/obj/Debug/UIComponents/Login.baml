   M S B A M L   `   `   `  ����G  Crs12-2011.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:rs12_2011.UI.UIComponentsrs12_2011.UI.UIComponents  5   	   ?$clr-namespace:rs12_2011.UI.ViewModelrs12_2011.UI.ViewModel  5   	   %    rs12_2011.UI.UIComponents.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:rs12_2011.UI.UIComponents     5   	   3vm$clr-namespace:rs12_2011.UI.ViewModel     5   	     � 
ResizeMode$  NoResize=�5	   	    � Title$ Salon Namestaja��5      $	��400��6   $	��850��6*    +� FocusedElement 5
   	   ��  �� ElementName$ textBoxUserName��.��5      � $	��400��6   $	��850��6   $��Center=�6$   $��Center=�6A    � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��LogintextBlock��5   <   $
��Left=�6    �� Padding$ 60q�6/   $��Login:��6R   $	��Top=�6`   $��20(�6x   �� 5   
   -   5        $��userNametextBlock��5   >   $��16(�6   $
��Left=�6#   $��Korisnicko Ime :��6W   $	��Top=�6o   $	��124��6�   $��
30,121,0,0q�6�   �� 5   
   -   5        $��passwordtextBlock��5   R   $��16(�6   $
��Left=�6#   $��
30,163,0,0q�6>   $��	Lozinka :��6k   $	��Top=�6|   $��77��6�   �� 5   
   -   5         ��Name$ textBoxUserName��5   B   $
��Left=�6   $��159,121,0,0q�6-   $	��Top=�6{   $	��247��6�   ��6[   �� *KorisnickoIme+6�   G� 5   
   -   5        $��passwordBox��5   F   $
��Left=�6   $��159,164,0,0q�61   $	��Top=�6Y   $	��247��6q   �� 5   
   -   5         ��Name$ LoginButton��5   Q   $��Login��6   $
��Left=�6!   $��159,234,0,0q�6<   $	��Top=�6f   $	��104��6~   6�   �� 5   
   -   5        $ Novi_korisnik��5   Y   $��Novi Korisnik��6   $
��Left=�6)   $��302,234,0,0q�6D   $	��Top=�6p   $	��104��6�   6�   �� 5   
   -   5        	 ��Name$	 Poruka��5      $>��8Neuspesno logovanje. Proverite korisnicko ime i lozinku.��6$   
���  ��$y�Hidden=�6u   $
��Left=�6�   $��118,274,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��247��6�   � 5   
   $��1��6   ��5      �� 5      
 j� Stretch$

 Fill=�6    j� 
AlignmentX$
 Left=�6,    �� ImageSource$O IC:\Users\Dell\Desktop\workspace-C#\rs12-2011\rs12-2011.UI\Slike\login.jpg��6>   5!      5"      5$      