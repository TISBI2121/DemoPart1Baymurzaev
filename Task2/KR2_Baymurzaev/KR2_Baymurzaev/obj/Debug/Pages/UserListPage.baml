   M S B A M L   `   `   `  ����I  EKR2_Baymurzaev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:KR2_Baymurzaev.PagesKR2_Baymurzaev.Pages  5      '    !KR2_Baymurzaev.Pages.UserListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:KR2_Baymurzaev.Pages     5      -   5          N� Title$  UserListPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Поиск по ФИО��6   �� 5      -   5         ��Name$ TBSearch��5      $	��250��6(   $	��5,0q�64   6A   5      �� 5      -   5         ��Name$
 BAdd��5      $+��%Добавить сотрудника��6#   $��Right=�6T   $	��5,0q�6p   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGUsers��5         AutoGenerateColumns .     
IsReadOnly . $��1��6R      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ФИО��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 62   �� *FIO+  5      $	 Ставка��6%   
 65   �� *Rate+  5      $	 
Адрес��6%   
 64   �� *	Address+  5      $	 Телефон��6%   
 66   �� *	Telephone+5      5      5       