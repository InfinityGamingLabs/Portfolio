   M S B A M L   `   `   `  ���� C  ?project4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:project4project4      project4.order   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:project4       � Title$  order��$	��450��$	��800��
�������.���  � RowDefinitions �� $
��Auto ��� $��* �.+��� $��0�� �� Orientation$ 
Horizontal=�.+��� $��
Klant ID: ���� -    ��Name$ KlantIdTextBox��$
��50px���� -    ��Name$ SubmitButton��$��Submit���� -   $ RefreshButton��$��Refresh���� -   $
 menu��$��125px��$��Right=�.��treug naar menu�� -    ��Name$ OrdersListView��$��1��
������� �� View �� .P��� $��Order ID�� �� DisplayMemberBinding �� *	OrderId+�� $
��Name�� �� *Name+�� $��Street�� �� *Street+�� $
��Town�� �� *Town+�� $��House Number�� �� *HouseNumber+�� $��House letter�� �� *
addition+�� $��
Pizza Type�� �� *	PizzaType+�� $��Status�� �� CellTemplate �� .R��� 	 ��Name$	 Status1��
 � DataContext
 �� *Status+�� $��Cancel Order�� �� .R��� -   $��Cancel������ *	OrderId+