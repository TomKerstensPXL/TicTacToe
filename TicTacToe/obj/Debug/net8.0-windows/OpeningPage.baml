   M S B A M L   `   `   `  ����D  @TicTacToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TicTacToe	TicTacToe  5   	       TicTacToe.OpeningPage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TicTacToe     5   	     � Title$  Tic-Tac-Toe - Enter Names��5   	   $	��400��6+   $	��600��68   ���#F0F0F0.��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $	��Top=�6"   $��20q�6:   .+�5      �� $��Enter Player Names��6   $��24(�61   $
��Bold"�6?   ���#333$��Center=�6c   5      �� 5   
   $��1��6   $��Center=�6"   $��Center=�6=   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5      �� $��
Player X: ��6   $��16(�6-   $
��Bold"�6;   �� 5      -   5        $��nameXPlayerBox��5      $	��200��60   $��30��6<   $��14(�6H   
�������6V   5      �� 5      $ 
Horizontal=�6   $��Center=�62   .+�5      �� -   5        $��nameYPlayerLabel��5      $��
Player O: ��60   $��16(�6E   $
��Bold"�6S   �� 5      -   5        $��nameYPlayerBox��5      $	��200��60   $��30��6<   $��14(�6H   
�������6V   5      5       �� 5#   
   $��2��6   $��Bottom=�6"   $��20q�6=   $��Center=�6I   .+�5$      �� -   5        $��readyButton��5$      $��
Start Game��6(   $	��150��6=   $��40��6I   $��16(�6U   $
��Bold"�6c   ���#4CAF50
�������6�   5%      	� 5&   
   -   5        $��singlePlayerRadioButton��5&      $��Single player��65    	� 	GroupName$ singlePlayer��6M   $
��Left=�6f   $��466,119,0,0q�6�   $��1��6�   $	��Top=�6�   6�   	� 5'   
   -   5        $��	easyRadio��5'      $ 
Difficulty��6'   $
��Eazy��6>   $
��Left=�6M   $��159,147,0,0q�6h   $��1��6}   $	��Top=�6�   $y�Hidden=�6�   	� 5(   
   -   5        $��mediumRadio��5(      $ 
Difficulty��6)   $��Medium��6@   $
��Left=�6Q   $��258,150,0,0q�6l   $��1��6�   $	��Top=�6�   $y�Hidden=�6�   	� 5)   
   -   5        $��	hardRadio��5)      $ 
Difficulty��6'   $
��Hard��6>   $
��Left=�6M   $��361,147,0,0q�6h   $��1��6}   $	��Top=�6�   $y�Hidden=�6�   5*      5+      