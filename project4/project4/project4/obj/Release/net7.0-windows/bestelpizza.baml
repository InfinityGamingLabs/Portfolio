   M S B A M L   `   `   `  ���� C  ?project4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:project4project4      project4.bestelpizza   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:project4       � Title$  bestelpizza��$	��550��$	��800��.��� ����  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,0&�.���  � Color$ Green�� � Offset$	 0.0Q�� $ White��$	 0.5Q�� $	 red��$	 1.0Q� � ColumnDefinitions �� $��2* ��� $��2* �.+��� $��0��.+��� -    ��Name$
 menu��$
��25px��$��125px��$
��Left=�.��treug naar menu�� $��Order Pizza��$��10q�$��24(�$��Center=��� $��10q�.+��� $��Name:���� -    ��Name$ txtName������ *NieuwPizzaOrder.Name+�� $��10q�.+��� $��Street:���� -   $ 	txtStreet������ *NieuwPizzaOrder.Street+�� $��10q�.+��� $��Town:���� -   $ txtTown������ *NieuwPizzaOrder.Town+�� $��10q�.+���  �� Orientation$ 
Horizontal=�.+��� $��House Number:���� -   $ txtHouseNumber��$	��100��$��5 0 5 0q����� *NieuwPizzaOrder.HouseNumber+�� $ 
Horizontal=�$��0 10 0 0q�.+��� $��	Addition:��$��0 0 5 0q�$��Center=�$��60���� -   $ txtHouseNumberAddition��$��50��$��0 0 0 0q����� *NieuwPizzaOrder.addition+�� $��10q�.+��� $��klant nummer:���� -   $ 
txtKlantId������ *	KlantId+�� $��10q�.+��� $��Pizza Type:���� -   	 ��Name$	 lstPizzaTypes��$��25������ *
PizzaTypes+.@��� .��tonijn�� .��vegetarisch�� .��salami�� .��
magarita�� .��bbq�� .��vis�� $��10q�.+��� $��	Toppings:���� -	   $	 lstToppings��$��25������ *ToppingOptions+.@��� .��tonijn�� .��	paprika�� .��salami�� .��	olijven�� .��tomaat�� .��
extra kaas�� -
   $ btnOrder��$��Order Pizza��$��10q��� $��1��.+��� $��Ordered Pizzas��$��10q�$��24(�$��Center=��� -   
 ��Name$
 lvOrderedPizzas��$��250px������ *OrderedPizzas+ �� SelectedItem �� *SelectedPizzaOrder+���� .R�]� .+��� 
���   �$��2q����� *Name+�� 
���   �$��2q����� *Street+�� 
���   �$��2q����� *Town+�� 
���   �$��2q����� *HouseNumber+�� 
���   �$��2q����� *
addition+�� 
���   �$��2q����� *	PizzaType+�� 
���   �$��2q����� *
Toppings+�� 
���   �$��2q����� *Price+�� �� -    ��Name$ tbtotaalprice��$
��35px������ *Price+�� �� -   $ tbstatus���� �� -   $ orderpizzas��$
��25px��$��125px��.��order pizzas