   M S B A M L   `   `   `  ����  PB_SN_AlesBrelih_270913273    -PB_SN_AlesBrelih_27091327.Windows.ProstorMain   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  ProstorMain��5   	    � WindowStartupLocation$ CenterOwner=�5   	    � WindowStyle$
 None=�5   	   
�������$��3q�6/    � AllowsTransparency .  � 
ResizeMode$ CanResizeWithGrip=�5   #    J� SnapsToDevicePixels .  � SizeToContent$ WidthAndHeight=�5   H   $	��300��6g    � UseLayoutRounding .  � 	Resources 5	      	 �� Source�� 5
   
   $/	 )../Resources/Dictionaries/MainLayout.xaml?�6   %    .��5      � 
 � RowDefinitions
 5   
   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� -   5        $��LblMainProstorWindow��5      $��Pregled prostorov��60      LabelH1Style#���   6L   � 5      $��Center=�6   $��RightToLeft=�63   .+�5      �� -   5        $��BtnClose��5   D     WindowStateClose#���  6    � ToolTip$ 
Zapri Okno��6m   �� 5      -   5        $��BtnMinimize��5   G     WindowStateMinimize#���  6   $ Minimiziraj Okno��6v   5      5      � 5   
   $��1��6   
 5      �� 5      $��1* �6    �� 5      $��2* �6    �� 5      $��1* �6    .+�5      �� $��0��6   $��VsiProstori��6$   .��5       �  � ColumnDefinitions 5!      �� 5"      $��1* �6+   �� 5#      $��2* �6+   .+�5%      ��   LabelManageOsebaInfo#���  6   $��Prostor��6K   �� 5&      -   5        $��CBoxProstori��5&   /   $��1��6   $ Izbor Prostora��6�   ��6C   �� *VsiProstori+6�   5'      5(      �� 5)      $��1��6   $��Podatki o prostoru��6$   {�6@   �� *PodatkiProstoraOmogoceni+.��5*      � 
 5+      �� 5,      $��1* �6(   �� 5-      $��1* �6(   �� 5.      $
��0.2* �6(   �� 5/      $��1* �6(    51      �� 52      $��1* �6+   �� 53      $��1* �6+   .+�55      �� $��Ime Prostora��6   #���  63   �� 56      $��0��6   $��1��6)   ��69   �� *IzbraniProstor.ImeProstora+�� 58      $��1��6   $��Dnevna Cena��6)   #���  6?   �� 59      $��1��6   $��1��6)   ��69   �� *IzbraniProstor.DnevnaCena+�� 5;      -   5        $��BtnUredi��5;   *   $��3��6   
�������$��Uredi��6L   $ Uredi Prostor��6u   �� 5<      -   5        $��
BtnIzbrisi��5<   *   $��3��6   $��1��6=   
�������$��Izbriši��6_   $ Izbriši prostor��6�   6�   5=      5>      � 5?      $��2��6    5@      �� 5A      $��1* �6'   �� 5B      $��1* �6'   .+�5D      �� -   5        $��BtnOk��5D      $��Zapri��6&   $ 
Zapri Okno��6L   6c   5E      5F      5G      5H      