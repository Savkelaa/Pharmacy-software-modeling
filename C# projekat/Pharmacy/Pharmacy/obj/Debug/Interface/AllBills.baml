   M S B A M L   `   `   `  ����C  ?Pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Pharmacy.InterfacePharmacy.Interface  5   	   !    Pharmacy.Interface.AllBills   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Pharmacy.Interface     5   	     � Title$  AllBills��5   	   $	��450��6   $	��800��6'   .��5	      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF4ED360��6    � Offset$ 0Q�61   � 5      $ White��6   $ 1Q�6-   5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	gridBills��5         SelectionMode$ Single=�6'      AutoGenerateColumns .  $
��Left=�6Z   $	��255��6u   $	��Top=�6�   $	��596��6�   $��	97,70,0,0q�6�      Columns 5   
   0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6!   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 20* 6E   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *Id+6E   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 
Components��6)   $	
 70* 6=      CellTemplate 5      �� 5      .R�5      �� ��6+   �� *MedicineAndQuantity+5      5        5      $	 Date and time��6%   $	
 72* 6Y    6<   �� *
DateTime+6Y     5      $	 Total Price��6!   $	
 35* 6U    66   �� *
TotalPrice+6U   5      5       5!      