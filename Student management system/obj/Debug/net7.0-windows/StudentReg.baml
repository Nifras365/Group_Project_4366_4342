   M S B A M L   `   `   `  ����T  PStudent management system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Student_management_systemStudent_management_system  5   	   *    $Student_management_system.StudentReg   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Student_management_system     5   	     � Title$  
StudentReg��5   	   $	��550��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�5	   	   
������  � AllowsTransparency$
 True��65    � 	Resources 5
         WindowBackgroundBrush �� 
StartPoint �� EndPoint � Color � Offset��%�   &	        �� 5   
   $	 0,0&�6<   $	 1,1&�6M   .��5      � $ #4A148C��6   $ 0Q�6+   � 5      $ #E91E63��6   $ 1Q�6+   � 5      $ #BA68C8��6   $	 0.6Q�6+   � 5      $ #F8BBD0��6   $ 1Q�6+   5      5      .��5      �� #��[  6   	 �� CornerRadius$	 30��6B   ._�5      � .+�5   
   �� $!��Student Registration window��6     LableSt#��[ 5      $��Center=�61   �� 5   
   .+�5   
   �� $��
First name��6     TxBlock#��[ 6&   $��	20 70 0 0q�6G   �� 5   
   -   5        
 ��Name$
 Firstnametb��5      $��30��6'   $	��500��63   $��100 -30 0 0q�6?   5      �� 5   
   .+�5      �� $��	Last name��6   #��[ 6)   $��
20 120 0 0q�6J   �� 5      -   5        $
 
Lastnametb��5      $��30��6*   $	��500��66   $��100 -30 0 0q�6B   5      �� 5   
   .+�5      �� $��Registration No��6   #��[ 6/   $��
20 170 0 0q�6P   �� 5       -   5        $
 Regnotb��5       $��30��6'   $	��500��63   $��100 -30 0 0q�6?   5!      �� 5"   
   .+�5#      �� $
��Mail��6   #��[ 6$   $��
20 220 0 0q�6E   �� 5$      -   5        $
 Mailtb��5$      $��30��6&   $	��500��62   $��100 -30 0 0q�6>   5%      �� 5&   
   .+�5'      �� $��Username��6   #��[ 6(   $��
20 270 0 0q�6I   �� 5(      -   5        $
 
UserNametb��5(      $��30��6*   $	��500��66   $��100 -30 0 0q�6B   5)      �� 5*   
   .+�5+      �� $��Password��6   #��[ 6(   $��
20 320 0 0q�6I   G� 5,      -   5         G�Name$ 
PassWordtb��5,      $��30��6/   $	��500��6;   $��100 -30 0 0q�6G   5-      �� 5.   
   .+�5/      �� $��Confirm Password��6   #��[ 60   $��
20 370 0 0q�6Q   G� 50      -   5        $ CpassWordtb��50      $��30��6/   $	��500��6;   $��100 -30 0 0q�6G   51      �� 52   
   .+�53      �� -   5        $��Register��53        ButtonM#��[ 6(   $��0 450 400 0q�6I   $	��300��6^   54      �� 55      -	   5        $��Close��55      #��[ 6%   $��400 -40 0 0q�6F   $	��300��6[   6g   57      58      59      5:      