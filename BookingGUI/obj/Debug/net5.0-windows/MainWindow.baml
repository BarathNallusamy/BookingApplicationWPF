   M S B A M L   `   `   `  ����E  ABookingGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BookingGUI
BookingGUI  5   	       BookingGUI.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BookingGUI     5   	     � Title$  ABC Booking Application��5   	   $	��300��6)   $	��700��66   .��5	      � .+�5
   
   �  � RowDefinitions 5      �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      � $��0��6    5      �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$    5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� -   5         ��Name$ 
LabelTitle��5      $��0��6,   $��2��69   
����  �$��30(�6c   
�������.��6�   	Welcome6�   �� 5      -   5        $ LabelFirstName��5      $��1��60   $��0��6=   
�������.��6e   	FirstName6p   �� 5       -   5        $ LabelLastName��5       $��2��6/   $��0��6<   
�������.��6d   
LastName6n   �� 5!      -   5        $ 
LabelEmail��5!      $��3��6,   $��0��69   
�������.��6a   Email6h   �� 5$      -   5         ��Name$ TextFirstName��5$      $��1��61   $��1��6>   
��� ���6d   �� 5%      -   5        $ TextLastName��5%      $��2��60   $��1��6=   
��� ���6c   �� 5&      -   5        $ 	TextEmail��5&      $��3��6-   $��1��6:   
��� ���6`   �� 5(      -   5         ��Name$ ButtonRegister��5(      $��4��61   $��2��6>   ���#8db0e8$��Register��6g   6z   5*      � 5+      $��1��6    5,      �� 5-      $��* �6$   �� 5.      $��* �6$   �� 5/      $��* �6$   �� 50      $��* �6$   .+�52      �� -	   5        $ btnViewStudents��52      $��0��62   $��1��6?   ���#8db0e8$��View Students��6d   6|   �� 53      -
   5        $ CreateBooking��53      $��1��60   $��1��6=   ���#8db0e8$��Create Booking��6b   6{   �� 54      -   5        $ ViewBooking��54      $��2��6.   $��1��6;   ���#8db0e8$��View/Cancel Booking��6`   6~   �� 55      -   5        $
 Exit��55      $��3��6'   $��1��64   
���\\��$��Close Application��6[   6w   56      57      58      59      