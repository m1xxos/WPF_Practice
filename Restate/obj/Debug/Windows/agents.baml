   M S B A M L   `   `   `  ����B  >Restate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Restate.WindowsRestate.Windows  5   	       Restate.Windows.agents   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Restate.Windows     5   	     � Title$  Агенты��5   	   $��487.895��6   $	��928��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��250 �6   �� 5      $��* �6   �� 5      $	��150 �6   .+�5   
   �� .+�5      �� -   5        $��LbAgents��5      $	��200��6T   $��10q�6`   $	��360��6l   ��5      �� 5      .R�5      �� ��6$   �� *PersonSet.FullName+5      5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��BtnNew��5      $	��New��6'      ButtonAgent#��[  65   �� 5      -   5        $��	BtnDelete��5      $��Delete��6*   #��[  6;   6`   5      5      �� 5   
   $	��150��6   $��2��6!   .+�5      �� $��
First name��6     TextBlockSPEl#��[ 6*   �� 5      -   5         ��Name$ TbFirstName��5        TextBoxSPEl#��[ 6+   {�.  6P   �� 5      $��Middle name��6   #��[ 6+   �� 5       -   5        $ TbMiddleName��5       #��[ 6-   {�.  6R   �� 5!      $��	Last name��6   #��[ 6)   �� 5"      -   5        $ 
TbLastName��5"      #��[ 6+   {�.  6P   �� 5#      $��
Deal Share��6   #��[ 6*   �� 5$      -   5        $ TbDealShare��5$      #��[ 6,   {�.  6Q   �� 5%      -   5         ��Name$ BtnEdit��5%      $
��Edit��6&     
ButtonSPEl#��[ 65   6Y   5&      �� 5'   
   $��1��6   $	�� 10q�6%   .+�5(      �� $��Demands��6   #��[ 6'   &   System.Windows.Controls.DataGrid  5)      -	   5          Name$ 	DgDemands��5)         
IsReadOnly .    AutoGenerateColumns .  $	��150��6X   $��
5, 5, 5, 5q�6e      SelectionMode$ Single=�6y   	   HeadersVisibility$	 Column=�6�   
   Columns
 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn   Header$
 Type��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *RealEstateFilterSet.Type+  5,      $ Client��6)    69   �� *%#PersonSet_Client.PersonSet.FullName+  5-      $ Agent��6)    68   �� *$"PersonSet_Agent.PersonSet.FullName+  5.      $ Address��6)    6:   �� *Address_City+  5/      $ 	Max Price��6)    6<   �� *
MaxPrice+51      �� 52      $��Supplies��6   #��[ 6(     53      -
   5        $ 
DgSupplies��53       .  .  $	��150��6Y   $��
5, 5, 5, 5q�6f   $ Single=�6z   $	 Column=�6�   
 54        55      $ 
RealEstate��6)    6=   �� *RealEstateSet.Info+  56      $ Price��6)    68   �� *Price+  57      $ Client��6)    69   �� *%#PersonSet_Client.PersonSet.FullName+  58      $ Agent��6)    68   �� *$"PersonSet_Agent.PersonSet.FullName+5:      5;      5<      5=      