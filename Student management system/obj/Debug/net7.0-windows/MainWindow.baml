   M S B A M L   `   `   `  ����T  PStudent management system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Student_management_systemStudent_management_system  5   	   *    $Student_management_system.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Student_management_system     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   
������  � AllowsTransparency$
 True��5	   "    � WindowStyle$
 None=�6<    � DataContext 5
      ,   &Student_management_system.MainWindowVM  5   
    � 	Resources 5         WindowBackgroundBrush �� 
StartPoint �� EndPoint � Color	 � Offset��%�   &	        �� 5   
   $	 0,0&�6<   $	 1,1&�6M   .��5      � $ #300030��6   $	 0Q�6+   � 5      $ #C0C0C0��6   $	 1Q�6+   � 5      $ #6B006B��6   $		 0.6Q�6+   � 5      $ #F5F5F5��6   $	 1Q�6+   5      5      .��5      �� #��[  6   
 �� CornerRadius$
 20��6A   ._�5      � .+�5   
   �� $!��Student Registration System��6   $��40(�66   $��Center=�6D     LableSt#��[ 6a   �� 5   
   .+�5   
   �� $��Username��6   $��30(�6$   $��	80 80 0 0q�62     TxBlock#��[ 6E   �� 5      -   5         ��Name$ 
Usernametb��5      $��250 -32 30 0q�6*   $��20(�6@   5      �� 5   
   .+�5      �� $��Password��6   $��30(�6(   $��
80 160 0 0q�66   #��[ 6J   G� 5      -   5         G�Name$ 
Passwordtb��5      $��250 -32 30 0q�6.   $��20(�6D   5       �� 5!   
   -   5        $��Login��5!      $��	400 0 0 0q�6!   $��Center=�64     ButtonM#��[ 5"      62   �� 5#   
   $=��7If you don't have an account click 'Create new account'��6   $��
20 290 0 0q�6R     LableSub#��[ 6f   $��20(�5$      �� 5%   
   -   5        $��Create new account��5%      $��Center=�5&      $��400 220 0 0q�6.   #��[ 5'      62   �� 5(   
   $��Close��6   $��Center=�5)      $��400 350 0 0q�6.   #��[ 5*      ��62   �� *CloseCommand+�� 5+   
   $f��`Example login: username - Nifras and password - 4366 or you can create a account and login again��6   $��
20 470 0 0q�5,      $��12(�6$   #��[ 62   5-      5.      5/      