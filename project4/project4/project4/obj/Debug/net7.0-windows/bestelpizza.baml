   M S B A M L   `   `   `  ����C  ?project4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:project4project4  5   	       project4.bestelpizza   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:project4     5   	     � Title$  bestelpizza��5   	   $	��550��6   $	��800��6*   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,0&�63   .��5      �  � Color$ Green��6    � Offset$	 0.0Q�6-   � 5      $ White��6   $	 0.5Q�6-   � 5      $	 red��6   $	 1.0Q�6+   5       � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��2* �6   .+�5   
   �� $��0��6   .+�5      �� -   5         ��Name$
 menu��5   L   $
��25px��6   $��125px��6#   $
��Left=�61   .��6m   treug naar menu6~   �� 5      $��Order Pizza��6   $��10q�6+   $��24(�67   $��Center=�6E   �� 5      $��10q�6   .+�5      �� $��Name:��6   �� 5      -   5         ��Name$ txtName��5      ��6   �� *NieuwPizzaOrder.Name+5      �� 5      $��10q�6   .+�5      �� $��Street:��6   �� 5      -   5        $ 	txtStreet��5      ��6-   �� *NieuwPizzaOrder.Street+5      �� 5       $��10q�6   .+�5!      �� $��Town:��6   �� 5"      -   5        $ txtTown��5"      ��6+   �� *NieuwPizzaOrder.Town+5#      �� 5$      $��10q�6   .+�5%      ��  �� Orientation$ 
Horizontal=�6   .+�5&      �� $��House Number:��6    �� 5'      -   5        $ txtHouseNumber��5'      $	��100��6c   $��5 0 5 0q�6o   ��66   �� *NieuwPizzaOrder.HouseNumber+6o   5(      �� 5)      $ 
Horizontal=�6   $��0 10 0 0q�66   .+�5*      �� $��	Addition:��6    $��0 0 5 0q�61   $��Center=�6B   $��60��6]   �� 5+      -   5        $ txtHouseNumberAddition��5+      $��50��6h   $��0 0 0 0q�6s   ��6>   �� *NieuwPizzaOrder.addition+6s   5,      5-      �� 5.      $��10q�6   .+�5/      �� $��klant nummer:��6   �� 50      -   5        $ 
txtKlantId��50      ��6.   �� *	KlantId+51      �� 52      $��10q�6   .+�53      �� $��Pizza Type:��6   �� 54      -   5        	 ��Name$	 lstPizzaTypes��54      $��25��62   ��6>   �� *
PizzaTypes+.@�55      �� .��6#   tonijn6+   �� 56      .��6#   vegetarisch60   �� 57      .��6#   salami6+   �� 58      .��6#   
magarita6-   �� 59      .��6#   bbq6(   �� 5:      .��6#   vis6(   5;      5<      �� 5=      $��10q�6   .+�5>      �� $��	Toppings:��6   �� 5?      -	   5        $	 lstToppings��5?      $��25��60   ��6<   �� *ToppingOptions+.@�5@      �� .��6#   tonijn6+   �� 5A      .��6#   	paprika6,   �� 5B      .��6#   salami6+   �� 5C      .��6#   	olijven6,   �� 5D      .��6#   tomaat6+   �� 5E      .��6#   
extra kaas6/   5F      5G      �� 5H      -
   5        $ btnOrder��5H      $��Order Pizza��6'   $��10q�6=   5I      5J      �� 5K   
   $��1��6   .+�5L      �� $��Ordered Pizzas��6   $��10q�6.   $��24(�6:   $��Center=�6H   �� 5M      -   5        
 ��Name$
 lvOrderedPizzas��5M      $��250px��6�   ��60   �� *OrderedPizzas+ �� SelectedItem 6V   �� *SelectedPizzaOrder+��5N      �� 5O      .R�5P      ]� .+�5Q      �� 
���   �$��2q�6R   ��6(   �� *Name+6R   �� 5R      
���   �$��2q�6T   ��6(   �� *Street+6T   �� 5S      
���   �$��2q�6R   ��6(   �� *Town+6R   �� 5T      
���   �$��2q�6Y   ��6(   �� *HouseNumber+6Y   �� 5U      
���   �$��2q�6V   ��6(   �� *
addition+6V   �� 5V      
���   �$��2q�6W   ��6(   �� *	PizzaType+6W   �� 5W      
���   �$��2q�6V   ��6(   �� *
Toppings+6V   �� 5X      
���   �$��2q�6S   ��6(   �� *Price+6S   5Y      5Z      5\      �� 5]      6   �� 5^      -   5         ��Name$ tbtotaalprice��5^   =   $
��35px��6   ��6&   �� *Price+6V   �� 5_      6   �� 5`      -   5        $ tbstatus��5`      6,   �� 5a      6   �� 5b      -   5        $ orderpizzas��5b      $
��25px��6*   $��125px��68   .��6`   order pizzas6n   5c      5d      5e      