   M S B A M L   `   `   `  ����G  Ceindopdracht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:eindopdracht.Viewseindopdracht.Views  5   	   #    eindopdracht.Views.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:eindopdracht.Views     5   	     � Title$  
MainWindow��5   	   $	��620��6   $
��1000��6)   .��5	      � ��5
   
   �� 5       �� ImageSource$ /images/realmadrid.jpg��6   6@   .+�5   
   � $	��584��6   $��Bottom=�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      � $��5q�6   $��0��6   .+�5      �� -   5         ��Name$ 
viewperson��5   J   $	��400��6^   $	��350��6j    J� Opacity$	 0.5Q�6x   
���   �$��45,35,45,190q�6  ��6�   �� *Person+ �� SelectedItem 6�   �� *SelectedPerson+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   $	��440��6B   $��5q�6N   .+�5   "   ]� .+�5   &   �� 
�������$��2q�6Z   $	��300��6e   ��60   �� *Name+6e   5   #   5#      5$      5&      �� 5'      .+�5(      �� $
��30px(�6    
�������$��50 400 300 20q�6C   	Persons6c   5)      �� 5*      .+�5+      �� -   5         ��Name$ Create��5+      $��325 420 100 20q�6B   .��6Z   Create6b   5,      �� 5-      .+�5.      �� -   5        $ Update��5.      $��325 450 100 20q�6B   .��6Z   Update6b   5/      �� 50      .+�51      �� -   5        $ Delete��51      $��400 435 30 20q�6B   .��6Y   Delete6a   52      �� 53       � DataContext 6   �� *SelectedPerson+.+�54      �� -   5        	 ��Name$	 tbperson��54      $
��20px(�60   $��50 500 200 20q�6@   $
��30px��6W   
���   �6z   55      56      � 57      $��5q�6   $��1��6   .+�58      �� -   5        $ viewcountry��58      $	��400��60   $	��350��6<   
���   �$	 0.5Q�6\   $��45,35,45,190q�6�   ��6j   �� *	Country+ 6�   �� *SelectedCountry+��59      �� 5:      .R�5;      �� $ 
Horizontal=�6)   $	��440��6B   $��5q�6N   .+�5<   "   ]� .+�5=   &   �� 
�������$��2q�6]   $	��300��6h   ��60   �� *	Country+6h   5>   #   5H      5I      5K      �� 5L      .+�5M      �� $
��30px(�6    
�������$��50 400 300 20q�6C   	Countries6e   5N      �� 5O       6   �� *SelectedCountry+.+�5P      �� $
��20px(�67   $��50 500 200 20q�6G   $
��30px��6^   ��6   �� *	Country+6n   5Q      �� 5R      .+�5S      �� -   5        $ CreateCountry��5S      $��325 420 100 20q�6P   .��6h   Create6p   5T      �� 5U      .+�5V      �� -   5        $ UpdateCountry��5V      $��325 450 100 20q�6P   .��6h   Update6p   5W      �� 5X      .+�5Y      �� -	   5        $ DeleteCountry��5Y      $��400 435 30 20q�6P   .��6g   Delete6o   5Z      5[      5\      5]      5^      