   M S B A M L   `   `   `  ����F  BRadioButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RadioButtonRadioButton  5   	       RadioButton.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:RadioButton     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5   
   �� 5      $��75 �6   6*   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   .+�5      �� $��Semaforo��6   $��45(�6(    �� TextAlignment$ Center=�66   
����+��6g   5      �� 5   
   $��1��6   .+�5      �  � ColumnDefinitions 5      �� 5      $
��0.5* �6'   66   �� 5      $
��0.5* �6'   66   .+�5#      �� $��0��6   .+�5%      	� -   5        $��50,20,100,80q�5%   "   .��5'      �� $
��ROJO��6$   
���  ��6C   5)      	� 5+      -   5        $��50,20,100,80q�5+   "   .��5-      �� $��AMARILLO��6$   
���2͚�6O   5/      	� 51      -   5        $��50,20,100,80q�51   "   .��53      �� $��VERDE��6$   
��� � �6F   55      5:      � 5<      $��1��6    J� RenderTransformOrigin$ 0.475,0.163&�6'   .+�5>      �� $��D:\Descargas\semaforo.jpg��6   6A   A� 5?      -   5        $��eRojo��5?   d   
���  ��$ 
0.52,-2.25&�6)   $��160,74,157,260q�6L   $y�Hidden=�6q   A� 5@      -   5        $��	eAmarillo��5@   h   
��� ���$ 
0.52,-2.25&�6,   $��160,163,157,171q�6O   $y�Hidden=�6y   A� 5A      -   5        $��eVerde��5A   f   
��� � �$ 
0.52,-2.25&�6+   $��160,257,157,77q�6N   $y�Hidden=�6t   5C      5E      5G      5I      5J      