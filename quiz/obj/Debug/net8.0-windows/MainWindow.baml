   M S B A M L   `   `   `  ����?  ;quiz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:quizquiz  5   	       quiz.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:quiz     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��600��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��42* �6   �� 5      $	��12* �6   �� 5      $
��317* �6   .+�5   
   �� -   5         ��Name$ 	txt_tresc��5      $��Treść pytania��6#   $
��Left=�6;   $��67��6V   $��	40,10,0,0q�6b   $	��Top=�6u   $	��523��6�   $��18(�6�   $��3��6�   	� 5   
   -   5         	�Name$
 odp1��5      $��RadioButton��6$   $
��Left=�6:   $��	40,82,0,0q�6U   $	��Top=�6h   $��3��6�   	� 5   
   -   5        $
 odp2��5      $��RadioButton��6$   $
��Left=�6:   $��
40,102,0,0q�6U   $	��Top=�6i   $��3��6�   	� 5   
   -   5        $
 odp3��5      $��RadioButton��6$   $
��Left=�6:   $��
40,122,0,0q�6U   $	��Top=�6i   $��3��6�   	� 5   
   -   5        $
 odp4��5      $��RadioButton��6$   $
��Left=�6:   $��
40,142,0,0q�6U   $	��Top=�6i   $��3��6�   �� 5   
   -   5        $ 	txt_wynik��5      $�� ��6#   $
��Left=�6.   $��219,191,0,0q�6I   $	��Top=�6^   $��88��6v   $��2��6�   �� 5   
   -   5         ��Name$ btn_next��5      $��Dalej��6#   $
��Left=�63   $��	1,191,0,0q�6N   $	��Top=�6a   $��39��6�   $��20��6�   $��2��6�   $��1��6�   5      5      