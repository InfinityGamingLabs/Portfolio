   M S B A M L   `   `   `  ���� C  ?project4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:project4project4      project4.MainWindow   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:project4       � Title$  
MainWindow��$	��450��$	��800��
�������.��� .+�� ����  �� Opacity$	 0.7Q� �� ImageSource$ /images/th.jfif�� � ColumnDefinitions �� $��1* ��� $��1* � � RowDefinitions �� $��1* ��� $��1* �.+��� -    ��Name$ mederwerkermenu��$
��25px��$��175px��$��1��$��0��$	��Top=�.��terug naar mederwerker menu�� $��1��$��Right=�$��Bottom=�$��	0,0,35,30q�$��0��.+��� -   $ 
CreateName��$	��150��$��25��
�������
����  � � 	Resources  �� 
TargetType �� Property	 �� Value��%:   '��       �� " ��.���  �@��CornerRadius$	 10��.��Create�� $��Right=�$��Bottom=�$��0,0,35,0q�$��0��.+��� -   $ 
UpdateName��
�������$	��150��$��25��
����  � ��%:   '��       �� " ��.���  �@��CornerRadius$	 10��.��Update�� $��1��$��60��$��30��
����  �$
��Bold"�$��18(�$
��Left=�$	��Top=�$��	20,14,0,0q�$��2��Name:�� $��0��$��1��$��	0,10,20,0q�$	��Top=�$��Right=�$��35��.+��� -   
 ��Name$
 tbName��
���   �$��25(�$	��185�� � DataContext �� *
NieuwPizza+���� *Name+�� $��1��$	��110��$��30��
����  �$
��Bold"�$��18(�$
��Left=�$	��Top=�$��	20,60,0,0q�$��2��Prijs:�� $��0��$��1��$��	0,54,20,0q�$	��Top=�$��Right=�$��35��.+��� -   $
 tbPrijs��
���   �$��25(�$	��185�� �� *
NieuwPizza+���� *Prijs+�� $��1��$	��160��$��30��
����  �$
��Bold"�$��18(�$
��Left=�$��Bottom=�$��	20,0,0,70q�$��3��	Aantal:�� $��0��$��1��$��	0,0,20,70q�$��Bottom=�$��Right=�$��35��.+��� -   $
 tbAantal��
���   �$��25(�$	��185�� �� *
NieuwPizza+���� *Aantal+�� $��60��$��30��
����  �$
��Bold"�$��18(�$
��Left=�$	��Top=�$��	20,40,0,0q�$��2��Name:�� $��0��$��0��$��Right=�$	��Top=�$��	0,35,20,0q�$��40��.+��� -   $
 tbname��
���   �$��25(�$	��185�� �� *SelectedPizza+���� *Name+�� $	��110��$��30��
����  �$
��Bold"�$��18(�$
��Left=�$	��Top=�$��	20,90,0,0q�$��2��Prijs:�� $��0��$��0��$��Right=�$��Center=�$��0,0,20,0q�$��40��.+��� -   $
 tbprijs��
���   �$��25(�$	��185�� �� *SelectedPizza+���� *Prijs+�� $	��160��$��30��
����  �$
��Bold"�$��18(�$
��Left=�$��Bottom=�$��	20,0,0,38q�$��3��	Aantal:�� $��0��$��0��$��Right=�$��Bottom=�$��	0,0,20,30q�$��40��.+��� -	   $
 tbaantal��
���   �$��25(�$	��185�� �� *SelectedPizza+���� *Aantal+� $��5q�$��1��$��2��$	��400��.+��� -
    ��Name$ lvpizza��
���   � J� Opacity$	 0.6Q�$��1��$	��320��$	��350��$��4,9,4,16q����� *Pizzas+ �� SelectedItem �� *SelectedPizza+���� .R�]� .+��� 
�������$��2q�$	��200������ *Name+�� 
�������$��2q�$
��50px������ *Prijs+�� 
�������$��2q����� *Aantal+�� $��1��$��Right=�$��Bottom=�$��0,0,40,0q�.+��� -   $ 
DeleteName��$��0,0,0,0q�
�������
����  �$��25��$	��153��$��Delete�� ��%:   '��       �� " ��.���  �@��CornerRadius$	 10��