   M S B A M L   `   `   `  ����  PB_SN_AlesBrelih_27091327*    $PB_SN_AlesBrelih_27091327.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  
MainWindow��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . $��2q�5   	   
������� J� SnapsToDevicePixels .  � SizeToContent$ WidthAndHeight=�6K    � WindowStartupLocation$ CenterScreen=�6j   $	��200��6�    � UseLayoutRounding .  � 	Resources 5       �� Source�� 5   
   $, &Resources/Dictionaries/MainLayout.xaml?�6   %    .��5
      � 	 � RowDefinitions	 5   
   �� 5      $��40 �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� -   5        $��lblMainWindowTopBar��5         LabelH1Style#���   6/   $(��"Vodenje Najema Poslovnih Prostorov��6V   6�   � 5      $��RightToLeft=�6   $��Center=�64   .+�5      �� -   5        $��
ExitButton��5        WindowStateClose#���  6+   
 � ToolTip$
 
Zapri Okno��6q   �� 5      -   5        $��MinimizeButton��5        WindowStateMinimize#���  6/   $
 Minimiziraj Okno��6|   6�   5      5      o� 5   
   $��1��6    . ���	#FFF7EDED��5      �� 5       �� EndPoint$ 0.5,1&�6     � MappingMode$ RelativeToBoundingBox=�61    �� 
StartPoint$ 0.5,0&�6U   .��5      �  � Color$ 	#FF6E2828��6    � Offset$ 1Q�6,   � 5      $ 	#FFDE0202��6   5      .@�5      m� $��	_Datoteka��6   ���	#FFFBF7F7.@�5#      m� $��_Exit��6   $
 Izhod Iz Programa��6*   
���  ��6F   5$      m� 5%      $��Najem��6   
�������.@�5&      m� -   5        $��MenuItemPregledNajem��5&   ,   $��Pregled��6   $
 Pregled Vseh Najemov��6k   
���  ��6�   �� 5'      
���  ��6   m� 5(      -   5        $��MenuItemNovNajem��5(   (   $	��Nov��6   $
 Ustvari Nov Najem��6_   
���  ��6{   5)      m� 5*      $��	_Prostori��6   
�������.@�5+      m� -   5        $��MenuItemPregledProstorov��5+   -   $��_Pregled��6   
���  ��$&
  Pregled Vseh Poslovnih Prostorov��6�   �� 5,      
���  ��6   m� 5-      -   5        $��MenuItemNovProstor��5-   )   $
��_Nov��6   $"
 Ustvari Nov Poslovni Prostor��6d   
���  ��6�   5.      m� 5/      $��	_Podjetja��6   
�������.@�50      m� -	   5        $��PregledPodjetjaMenuItem��50   -   $��_Pregled��6   $
 Pregled Vseh Podjetij��6t   
���  ��6�   �� 51      
���  ��6   m� 52      -
   5        $��NovoPodjetjeMenuitem��52   0   $��Dodaj _Novo��6   $
 Ustvari Novo Podjetje��6q   
���  ��6�   53      m� 54      $��_Osebe��6   
�������.@�55      m� -   5        $��PregledOsebaMenuItem��55   -   $��_Pregled��6   $
 Pregled Vseh Oseb��6n   
���  ��6�   �� 56      
���  ��6   m� 58      -   5        $��NovaOsebaMenuItem��58   E   $��Dodaj _Novo��6   
���  ��$
 Ustvari Novo Osebo��6�   59      5:      � 5;   
   $��2��6   .+�5<      �� $��    Pregled Poslovanja   ��6   .��5=      &   System.Windows.Controls.DataGrid  -   5        $��DataGridMain��5=         AutoGenerateColumns .  ��6/   �� *	VsiNajemi+ �� NotifyOnSourceUpdated .  5>      ��%    5@         Columns 5A      0  *System.Windows.Controls.DataGridTextColumn  5B      ,  &System.Windows.Controls.DataGridColumn   Header$ Ime Podjetja��6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *Podjetje.ImePodjetja+6V     5C      $ Kontaktna Oseba��6_    6-   �� *Podjetje.KontaktnaOseba.Izpis+6_     5E      $ Poslovni Prostor��6U    6-   �� *Prostor.ImeProstora+6U     5F      $	 Od:��6N    6-   �� *ZacetniIzpis+6N     5G      $	 Do:��6M    6-   �� *KoncniIzpis+6M   5K      5L      5M      5O      5P      