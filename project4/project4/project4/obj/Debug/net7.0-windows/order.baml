   M S B A M L   `   `   `  ����C  ?project4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:project4project4  5   	       project4.order   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:project4     5   	     � Title$  order��5   	   $	��450��6   $	��800��6$   
�������.��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $��
Klant ID: ��6   �� 5      -   5         ��Name$ KlantIdTextBox��5      $
��50px��6.   �� 5      -   5         ��Name$ SubmitButton��5      $��Submit��6+   6<   �� 5      -   5        $ RefreshButton��5      $��Refresh��6,   6>   �� 5      -   5        $
 menu��5   @   $��125px��6   $��Right=�6$   .��6a   treug naar menu6r   5      �� 5   
   -   5         ��Name$ OrdersListView��5      $��1��6+   
������� �� View 5      �� 5      .P�5      �� $��Order ID��6%    �� DisplayMemberBinding 67   �� *	OrderId+�� 5      $
��Name��6%    63   �� *Name+�� 5      $��Street��6%    65   �� *Street+�� 5      $
��Town��6%    63   �� *Town+�� 5      $��House Number��6%    6;   �� *HouseNumber+�� 5      $��House letter��6%    6;   �� *
addition+�� 5      $��
Pizza Type��6%    69   �� *	PizzaType+�� 5      $��Status��6%    �� CellTemplate 5       �� 5!      .R�5"   "   �� 	 ��Name$	 Status1��6,   
 � DataContext
 6=   �� *Status+5#      5%      �� 5&      $��Cancel Order��6%    5'      �� 5(      .R�5)   "   �� -   5        $��Cancel��5)   )   ��6T   �� *	OrderId+5*      5,      5-      5/      50      51      