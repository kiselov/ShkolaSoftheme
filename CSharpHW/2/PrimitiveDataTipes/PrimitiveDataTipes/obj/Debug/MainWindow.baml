   M S B A M L   `   `   `  ����M  IPrimitiveDataTipes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:NumericDataTypesNumericDataTypes  5   	   !    NumericDataTypes.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:NumericDataTypes     5   	   $	��215��5   
   $	��400��6     � WindowStartupLocation$  CenterScreen=�6#   $	��215��6H   $	��400��6X   .��5	      �  � RowDefinitions 5
   
   �� 5      $��4* �6   �� 5      $	��27* �6   �� 5      $��8* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��10* �6    � ColumnDefinitions 5   
   �� 5      $��8* �6   �� 5      $	��64* �6   �� 5      $	��20* �6   �� 5      $
��202* �6   �� 5      $	��53* �6   �� 5      $	��10* �6   .+�5   
   �� -   5         ��Name$ listBox��5      $��1,0,0,0q�6#   $��1��6T   $��3��6d   $��3��6q   .@�5      �� $	��int��6   �� 5      $
��long��6   �� 5      $��sbyte��6   �� 5      $��short��6   �� 5       $
��uint��6   �� 5!      $��ulong��6   �� 5"      $��ushort��6   5$      �� 5%   
   -   5         ��Name$ min_lbl��5%      $��3��6"   $��3��62    J� RenderTransformOrigin$ 0.5,0.5&�6?   $��0,0,1,0q�6_   z�5&      V� 5'      .~�5(      �� �� 5)       �� AngleX$ -1.317Q�6$   �� 5*       �� Angle$ -0.166Q�6&   T� 5+       T� X$ -0.31Q�6)   5,      5.      �� 5/   
   -   5        $ max_lbl��5/      $��3��6!   $��4��61   �� 50   
   -   5        $ default_lbl��50      $��3��6&   $��5��66   �� 51   
   -   5        $ label��51      $��Numeric Data Types��6    $��3��6=   $��1��6M   $��Rockwell Extra Bold)�6Z   $��16(�6{   �� 52   
   -   5        	 ��Name$
	 quit��52      $
��Quit��6   $��4��6.   $��5��6>   6K   54      55      