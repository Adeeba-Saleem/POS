   M S B A M L   `   `   `  ����A  =POS.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:POS.UI.State.NavigatorPOS.UI.State.Navigator  5      /clr-namespace:POS.UI.ControlPOS.UI.Control  5      "    POS.UI.Control.NavigationBar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4nav$clr-namespace:POS.UI.State.Navigator     5      .localclr-namespace:POS.UI.Control     5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $'��!  Software Engineering POS System��5   
      BrushPrimary1#��[  63   $��25(�6_    �� Padding$ 10q�5      
�������6!   � 5   
   $��1��6    �� EdgeMode$ Aliased=�6     BrushPrimary2#��[ 5       � 	Resources 5       �� 
TargetType  	NavButton �� BasedOn��%0   '	�       7  �� 5      " 	�6   8   61   5       � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5       	� $��0��6   $
��Home��6*   %   POS.UI.State.Navigator.ViewType   Home#��Z 5!      ��5    9   �� *UpdateCurrentViewModelCommand+5!      	� 5"      $��1��6   $��About��6*   	� 5#      $��2��6   $	��POS��6*   
   POS#��Z 5$      ��5#   9   �� *UpdateCurrentViewModelCommand+5$      	� 5%      $��3��6   $��Contact��6*   	� 5&      $��4��6   $
��Exit��6*   5'      5)      5*      