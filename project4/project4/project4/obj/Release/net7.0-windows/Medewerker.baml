   M S B A M L   `   `   `  ���� C  ?project4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:project4project4      project4.Medewerker   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:project4       � Title$  
Medewerker��$	��555��$	��800��$	��555��$	��800��.��� .+�� ����  �� Opacity$	 0.7Q� �� ImageSource$ images/medewerker.png�� � ColumnDefinitions �� $��1* ��� $��1* � � RowDefinitions �� $��1* ��� $��1* �.+��� $
��Bold"�
����  �$��30(�$	��184��$��50��$��0��$��0��$
��Left=�$	��Top=�$��8,5,0,0q�
Medewerker�� -    ��Name$ mederwerkermenu��$
��25px��$��175px��$��1��$��0��$	��Top=�.��terug naar mederwerker menu�� $��1��$��Right=�$��Bottom=�$��	0,0,35,30q�$��0��.+��� -   
�������$	��150��$��25��
����  � � 	Resources  �� 
TargetType �� Property	 �� Value��%:   '��       �� " ��.���  �@��CornerRadius$	 10��.��Create�� $��Right=�$��Bottom=�$��	0,0,35,10q�$��0��.+��� -   $ 
UpdateName��$	��150��$��25��
�������
����  � ��%:   '��       �� " ��.���  �@��CornerRadius$	 10��.��Update�� $��1��$��60��$��30��
����  �$
��Bold"�$��18(�$
��Left=�$	��Top=�$��	20,14,0,0q�$��2��Name:�� $��0��$��1��$��	0,10,20,0q�$	��Top=�$��Right=�$��40��$	��188��.+��� -   
 ��Name$
 tbName��$��1��
���   �$��25(�$	��185�� � DataContext �� *NieuwMedewerkers+���� *Name+�� $��1��$	��110��$��30��
����  �$
��Bold"�$��18(�$
��Left=�$	��Top=�$��	20,89,0,0q�$��2��Woonplaats:�� $��0��$��1��$��	0,84,20,0q�$	��Top=�$��Right=�$��40��$	��188��.+��� -   $
 tbWoonplaats��$��1��
���   �$��25(�$	��185�� �� *NieuwMedewerkers+���� *
Woonplaats+�� $��1��$	��160��$��30��
����  �$
��Bold"�$��18(�$
��Left=�$��Bottom=�$��	20,0,0,80q�$��3��Telefoon Nummer:�� $��0��$��1��$��	0,0,20,75q�$��Bottom=�$��Right=�$��40��.+��� -   $
 tbTelefoonnummer��$��1��
���   �$��25(�$	��185�� �� *NieuwMedewerkers+���� *Telefoonnummer+�� $��60��$��30��
����  �$
��Bold"�$��18(�$
��Left=�$	��Top=�$��	20,60,0,0q�$��2��Name:�� $��0��$��0��$��Right=�$	��Top=�$��	0,55,20,0q�$��40��.+��� -   
���   �$��0��$��25(�$	��185�� �� *SelectedMedwerker+���� *Name+�� $	��110��$��30��
����  �$
��Bold"�$��18(�$
��Left=�$	��Top=�$��
20,130,0,0q�$��2��Woonplaats:�� $��0��$��0��$��Right=�$	��Top=�$��
0,125,25,0q�$��40��.+��� -   $
 tbwoon��
���   �$��25(�$	��180�� �� *SelectedMedwerker+���� *
Woonplaats+�� $	��160��$��30��
����  �$
��Bold"�$��18(�$
��Left=�$��Bottom=�$��	20,0,0,45q�$��3��Telefoon Nummer:�� $��0��$��0��$��Right=�$��Bottom=�$��	0,0,25,40q�$��40��.+��� -	   $
 tbtele��
���   �$��25(�$	��180�� �� *SelectedMedwerker+���� *Telefoonnummer+�� $	��100��$��10��$��2��$��20,130,150,130q�� $	��450��$��5,5,5,5q�$��1��$��0��$��2�� �� $��1* � �� $��1* �.+��� -
    ��Name$ lvpizza��
���   � J� Opacity$	 0.6Q�$	��384��$	��435��$��Bottom=�$��4,9,4,0q����� *Medewerkers+ �� SelectedItem �� *SelectedMedwerker+���� .R�]� .+��� 
�������$��2q�$	��200������ *Name+�� 
�������$��2q�$
��80px������ *
Woonplaats+�� 
�������$��2q����� *Telefoonnummer+�� $��1��$��Right=�$��Bottom=�$��
0,0,10,-30q�.+��� -   $ 
DeleteName��
�������
����  �$��25��$	��153��$��Delete�� ��%:   '��       �� " ��.���  �@��CornerRadius$	 10��