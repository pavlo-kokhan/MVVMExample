   M S B A M L   `   `   `  ����B  >Booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BookingBooking  5   	       Booking.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Booking     5   	     � Title$  Booking Management��5   	   $	��350��6$   $	��600��61   .��5
      �� .@�5   
   �� $��Bookings��6   .��5      � .+�5      &   System.Windows.Controls.DataGrid     CanUserAddRows$ False��5         CanUserDeleteRows$ False��5         AutoGenerateColumns$ False��5      $��10q�5      ��5      �� *
Bookings+ �� SelectedItem 5      �� *SelectedBooking+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-      
IsReadOnly$
 True��5   -      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6?   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5   9   �� *	BookingId+5   ?     5      $ Service Name��6-   $
 True��5   -   $ * 6?   	 5   C   �� *ServiceName+5   ?     5      $ 
Start Date��6-   $
 True��5   -   $ * 6?   	 5   A   �� *	StartDate+5   ?     5      $ End Date��6-   $
 True��5   -   $ * 6?   	 5   ?   �� *	EndDate+5   ?     5      $ Is Confirmed��6-   $
 True��5   -   $ * 6?   	 5   C   �� *IsConfirmed+5   ?   5       �� 5"      
 �� Orientation$
 
Horizontal=�6   $��Center=�5#      $��Bottom=�5$      $��10q�5%      .+�5&      �� $	��Add��5'      $��5q�5(      ��5)      �� *AddBookingCommand+�� 5*      $��Delete��5+      $��5q�5,      ��5-      �� *DeleteBookingCommand+�� 5.      $��Update��5/      $��5q�50      ��51      �� *UpdateBookingCommand+52      53      54      �� 56   
   $��Clients��6   .��57      � .+�58        $ False��5:      $ False��5;      $ False��5<      $��10q�5=      ��58      �� *	Clients+ 59      �� *SelectedClient+ 5>        5?      $ ID��6-   $
 True��5@   -   $ 50 6?   	 5?   9   �� *
ClientId+5@   ?     5A      $ 	Full Name��6-   $
 True��5B   -   $ * 6?   	 5A   @   �� *
FullName+5B   ?     5C      $ Contact Email��6-   $
 True��5D   -   $ * 6?   	 5C   D   �� *ContactEmail+5D   ?     5E      $ Contact Number��6-   $
 True��5F   -   $ * 6?   	 5E   E   �� *ContactNumber+5F   ?   5H      �� 5J      $
 
Horizontal=�6   $��Center=�5K      $��Bottom=�5L      $��10q�5M      .+�5N      �� $	��Add��5O      $��5q�5P      ��5Q      �� *AddClientCommand+�� 5R      $��Delete��5S      $��5q�5T      ��5U      �� *DeleteClientCommand+�� 5V      $��Update��5W      $��5q�5X      ��5Y      �� *UpdateClientCommand+5Z      5[      5\      5]      5_      