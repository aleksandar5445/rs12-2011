   M S B A M L   `   `   `  ����G  Crs12-2011.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:rs12_2011.UI.UIComponentsrs12_2011.UI.UIComponents  5   	       rs12_2011.UI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:rs12_2011.UI.UIComponents     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ 
GlavniMeni��5	   	   $	��420��6   $	��960��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      -   5         ��Name$
 leva��5      $
��130* �6-   �� 5      $
��707* �6   �� 5      -   5        $ desna��5      $
��130* �6.    � RowDefinitions 5   
   �� 5      $	��56* �6   �� 5      -   5         ��Name$ button��5      $��9* �6,   ��5   
   �� 5       j� Stretch$
 Fill=�6    �� ImageSource$T NC:\Users\Dell\Desktop\workspace-C#\rs12-2011\rs12-2011.UI\Slike\GlavniMeni.jpg��6(   .+�5   
   � $��1��6   $��3��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��LogovanKorisnik��5   �   
�������$
��Left=�6/   $��Center=�6J   $��16(�6e   $
��auto��6s   $
��Bold"�6�   	 J� Opacity$
	 0.65Q�6�   �� 5      -   5        $��Edit Korisnika��5      $��Center=�62   $	��110��6M   $��Right=�6Y   6u   5      5      � 5   
   $��0��6   $��0��6   .+�5      �� $��	15,5,5,15q�6   .+�5      �� -   5        
 ��Name$
 Magacin��5      $��0,0,0,10q�6*   $��Magacin��6<   $	��100��6N   $
��Left=�6Z   $	��Top=�6u   6�   �� 5       -   5        $��Akcija��5       $��0,0,0,10q�6'   $��Akcija��69   $	��Top=�6J   $
��Left=�6b   $	��100��6}   6�   �� 5!      -   5        $��IstorijaKupovine��5!      $��0,0,0,10q�61   $��Istorija Kupovine��6C   $	��Top=�6_   $
��Left=�6w   $	��100��6�   6�   5"      5#      � 5$   
   $��2��6   $��2��6    ��5%      �� 5&      .+�5(      �� -	   5        $
 	SalonEdit��5(      $��Salon Opsti Podaci��6(   $	��Top=�6E   $��Center=�6]   $��4q�6z   $��2,10,2,0q�6�   6�   �� 5)      -
   5        $��Korpa��5)      $��Right=�6"   $��Bottom=�6>   ��5*      �� 5+      .��5-      �� $O��IC:\Users\Dell\Desktop\workspace-C#\rs12-2011\rs12-2011.UI\Slike\korpa.png��6   $��Uniform=�6k   5.      5/      51      52      