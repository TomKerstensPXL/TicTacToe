   M S B A M L   `   `   `  ����D  @TicTacToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TicTacToe	TicTacToe  5   	       TicTacToe.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TicTacToe     5   	     � Title$  Tic-Tac-Toe��5   	   $	��600��6   $	��600��6*   ���#F0F0F0.��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $	��Top=�6"   $��20q�6:   .+�5      �� -   5        $��currentPlayerLabel��5      $��20(�6.   $
��Bold"�6<   ���#333$��Center=�6`   5      A� 5   
   $��1��6    A� Rows$ 3��6#    A� Columns$ 3��6,   $��Center=�68   $��Center=�6U   $	��300��6p   $	��300��6|   .+�5      �� -   5        $��gameButton1��5      $��24(�6=   
�������$��3q�6^   �� 5      -   5        $��gameButton2��5      $��24(�6=   
�������$��3q�6^   �� 5      -   5        $��gameButton3��5      $��24(�6=   
�������$��3q�6^   �� 5      -   5        $��gameButton4��5      $��24(�6=   
�������$��3q�6^   �� 5      -   5        $��gameButton5��5      $��24(�6=   
�������$��3q�6^   �� 5      -   5        $��gameButton6��5      $��24(�6=   
�������$��3q�6^   �� 5      -   5        $��gameButton7��5      $��24(�6=   
�������$��3q�6^   �� 5      -	   5        $��gameButton8��5      $��24(�6=   
�������$��3q�6^   �� 5       -
   5        $��gameButton9��5       $��24(�6=   
�������$��3q�6^   5!      �� 5$   
   $��1��6   $	��Top=�6"   $��
450,80,0,0q�6:    �� Orientation$ Vertical=�6N   .+�5%      �� $��Score��6   $��18(�6$   $
��Bold"�62   $��Center=�6D   �� 5&      $ 
Horizontal=�6   $��Center=�62   $��0,5,0,5q�6O   .+�5'      �� -   5        $��playerxLabel��5'      $��Player X��6,   $��14(�6?   $
��Bold"�6M   $��5q�6_   �� 5(      -   5        $��playeryLabel��5(      $��Player O��6,   $��14(�6?   $
��Bold"�6M   $��5q�6_   5)      �� 5*      $ 
Horizontal=�6   $��Center=�62   .+�5+      �� -   5        $��playerXScoreTextBox��5+      $��50��65   $��40��6@   $��0��6L   $��16(�6U   $
��Bold"�6c    �� TextAlignment$ Center=�6u   ���#FFF8DC6�   �� 5,      -   5        $��playerYScoreTextBox��5,      $��50��65   $��40��6@   $��0��6L   $��16(�6U   $
��Bold"�6c   $ Center=�6u   ���#F0FFF0$��10,0,0,0q�6�   5-      5.      �� 51   
   $��2��6   $��Bottom=�6"   $��20q�6=   $ 
Horizontal=�6I   $��Center=�6b   .+�52      �� -   5        $��turnCounterLabel��52      $��16(�6,   $
��Bold"�6:   ���#5556L   53      54      55      