   M S B A M L   `   `   `  ����  PB_SN_AlesBrelih_270913273    -PB_SN_AlesBrelih_27091327.Windows.OsebaManage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  OsebaManage��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � 
ResizeMode$ CanResizeWithGrip=�5   	   $��3q�5   	   
������� � SizeToContent$ WidthAndHeight=�60    � WindowStartupLocation$ CenterOwner=�6O   $	��300��6s    � 	Resources 5	       �� Source�� 5
   
   $/ )../Resources/Dictionaries/MainLayout.xaml?�6   %    .��5      �  � UseLayoutRounding . 	 � RowDefinitions	 5   
   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� -   5        $��ManageOsebaLabel��5         LabelH1Style#���   6,   $��PB-SN-Oseba��6S   � 5      $��RightToLeft=�6   $��Center=�64   .+�5      �� -   5        $��BtnClose��5        WindowStateClose#���  6C   
 � ToolTip$
 
Zapri Okno��6n   �� 5      -   5        $��BtnMinimiye��5        WindowStateMinimize#���  6H   $
 Minimiziraj Okno��6v   5      5      � 5   
   $��1��6   .+�5      �� $��Osebni Podatki��6   $
 Podatki o Osebi��6/   .��5      � 	 5      �� 5      $��1* �6(   �� 5      $��1* �6(   �� 5      $��1* �6(   �� 5       $��1* �6(   �� 5!      $
��0.3* �6(   �� 5"      $��1* �6(    � ColumnDefinitions 5$      �� 5%      $��1* �6+   �� 5&      $��1* �6+   .+�5(      �� $��0��6   $��0��6)     LabelManageOsebaInfo#���  69   $	��Ime��6h   �� 5)      $��1��6   $��0��6)   #���  69   $��Priimek��6h   �� 5*      $��2��6   $��0��6)   #���  69   $��E-mail��6h   �� 5+      $��3��6   $��0��6)   #���  69   $��Telefon��6h   �� 5,      -   5        $��TboxIme��5,   ;   $��0��6   $��1��6+   $
 Ime Kontaktne Osebe��6r   ��6J   �� *	Oseba.Ime+ �� Mode$ TwoWay=�6r   �� 5-      -   5        $��TboxPriimek��5-   ;   $��1��6   $��1��6+   $
 Priimek Kontaktne Osebe��6z   ��6N   �� *Oseba.Priimek+$ TwoWay=�6z   �� 5.      -   5        $��	TboxEmail��5.   ;   $��2��6   $��1��6+   $
 Email Kontaktne Osebe��6v   ��6L   �� *Oseba.EMail+$ TwoWay=�6v   �� 5/      -   5        $��TboxTelefon��5/   ;   $��3��6   $��1��6+   $
 Telefon Kontaktne Osebe��6|   ��6N   �� *Oseba.Telephone+$ TwoWay=�6|   �� 50      -	   5        $��BtnOk��50   T   $��5��6   $��0��6*   $��Shrani in Izhod��6:   $
 Shrani In Izhod��6u   �� 51      -
   5        $��	BtnCancel��51   J   $��5��6   $��1��6*   $��Izhod��6:   $
 Izhod��6u   53      54      55      56      57      