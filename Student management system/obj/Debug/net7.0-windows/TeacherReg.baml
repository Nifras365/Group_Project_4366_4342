   M S B A M L   `   `   `  ����T  PStudent management system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Student_management_systemStudent_management_system  5   	   *    $Student_management_system.TeacherReg   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Student_management_system     5   	     � Title$  
TeacherReg��5   	   $	��550��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�5	   	   
������  � AllowsTransparency$
 True��65    � 	Resources 5
         WindowBackgroundBrush �� 
StartPoint �� EndPoint � Color � Offset��%   &	        �� 5   
   $	 0,0&�6<   $	 1,1&�6M   .��5      � $ #0D47A1��6   $	 0.5Q�6+   � 5      $ #FFD700��6   $	 0.9Q�6+   � 5      $ #42A5F5��6   $	 0.6Q�6+   � 5      $ #FFEF9C��6   $ 1Q�6+   5      5      .��5      �� #��[  6   	 �� CornerRadius$	 30��6A   ._�5   
   � .+�5      �� $!��Teacher Registration window��6     LableSt#��[ 5      $��Center=�61   �� 5      .+�5      �� $��
First name��6     TxBlock#��[ 6.   $��	20 70 0 0q�6O   �� 5      -   5        
 ��Name$
 Fnametb��5      $��30��6+   $	��500��67   $��100 -30 0 0q�6C   5      �� 5      .+�5      �� $��	Last name��6   #��[ 6-   $��
20 120 0 0q�6N   �� 5      -   5        $
 Lnametb��5      $��30��6+   $	��500��67   $��100 -30 0 0q�6C   5      �� 5      .+�5      �� $��Teacher ID No��6   #��[ 61   $��
20 170 0 0q�6R   �� 5       -   5        $
 TecIDtb��5       $��30��6+   $	��500��67   $��100 -30 0 0q�6C   5!      �� 5"      .+�5#      �� $
��Mail��6   #��[ 6(   $��
20 220 0 0q�6I   �� 5$      -   5        $
 Emailtb��5$      $��30��6+   $	��500��67   $��100 -30 0 0q�6C   5%      �� 5&      .+�5'      �� $��Username��6   #��[ 6,   $��
20 270 0 0q�6M   �� 5(      -   5        $
 
USernametb��5(      $��30��6.   $	��500��6:   $��100 -30 0 0q�6F   5)      �� 5*      .+�5+      �� $��Password��6   #��[ 6,   $��
20 320 0 0q�6M   G� 5,      -   5         G�Name$ PSwordtb��5,      $��30��60   $	��500��6<   $��100 -30 0 0q�6H   5-      �� 5.      .+�5/      �� $��Confirm Password��6   #��[ 64   $��
20 370 0 0q�6U   G� 50      -   5        $ ConPStb��50      $��30��6/   $	��500��6;   $��100 -30 0 0q�6G   51      �� 52      .+�53      �� -   5        $��Register��53        ButtonM#��[ 6,   $��-350 450 0 0q�54      $	��300��6+   67   �� 55      -	   5        $��Close��55      #��[ 6)   $��400 -40 0 0q�56      $	��300��6*   66   57      58      59      5:      