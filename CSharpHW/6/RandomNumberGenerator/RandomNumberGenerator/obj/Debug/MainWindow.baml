   M S B A M L   `   `   `  ����P  LRandomNumberGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:RandomNumberGeneratorRandomNumberGenerator  5   	   &     RandomNumberGenerator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:RandomNumberGenerator     5   	     � Title$  
MainWindow��5   	   $	��200��6   $	��482��6)    � WindowStartupLocation$ CenterScreen=�65   $	��200��6Z   $	��482��6j   .��5	      �  � RowDefinitions 5
   
   �� 5      $��6* �6   �� 5      $	��30* �6   �� 5      $	��15* �6   �� 5      $	��26* �6   �� 5      $	��78* �6   �� 5      $	��15* �6    � ColumnDefinitions 5   
   �� 5      $	��33* �6   �� 5      $	��38* �6   �� 5      $	��93* �6   �� 5      $
��156* �6   �� 5      $	��39* �6   �� 5      $	��53* �6   �� 5      $	��40* �6   �� 5      $	��22* �6   .+�5   
   �� -   5         ��Name$ button��5      $��Go��6!   $��22,0,0,0q�6.   $��3��6U   $��4��6e   $��Segoe WP Black)�6r   $��20(�6�   �� 5   
   -   5         ��Name$ userNumber_txtBx��5       �� TextAlignment$ Center=�6,    �� TextWrapping$
 Wrap=�6C   $��2��6W   $��4��6g   $��Segoe WP Black)�6t   $��36(�6�   �� 5   
   -   5         ��Name$ label��5      $��Game in a random number��6   $��Ravie)�6A   $��18(�6T   $��2��6b   $��1��6r   $��4��6   �� 5   
   -   5        $
 quit��5      $��2��6   $
��Quit��63   $��5��6B   $��4��6R   �� 5    
   -   5        $ label1��5       $-��'Bведите число от 1 до 10��6    $��1��6C   $��3��6S   $��3��6`   5"      5#      