   M S B A M L   `   `   `  ����  PB_SN_AlesBrelih_270913271    +PB_SN_AlesBrelih_27091327.Windows.OsebaMain   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  	OsebaMain��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � 
ResizeMode$ CanResizeWithGrip=�5   +    � WindowStartupLocation$ CenterOwner=�5   	   $��2q�5   	   
������� J� SnapsToDevicePixels .  � UseLayoutRounding .  � SizeToContent$ WidthAndHeight=�6d   $	��300��6�    � 	Resources 5	      	 �� Source�� 5
   
   $/	 )../Resources/Dictionaries/MainLayout.xaml?�6   %    .��5      � 
 � RowDefinitions
 5   
   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��0��6   .+�5      �� -   5        $��LabelOsebaMain��5         LabelH1Style#���   6*   $��PB-SN-Pregled Oseb��6Q   � 5      $��RightToLeft=�6   $��Center=�64   .+�5      �� -   5        $��BtnClose��5        WindowStateClose#���  6)    � ToolTip$ 
Zapri Okno��6m   �� 5      -   5        $��BtnMinimize��5        WindowStateMinimize#���  6,   $ Minimiziraj Okno��6v   5      5      � 5   
   $��1��6   
 5      �� 5      $��2* �6    �� 5      $��8* �6    �� 5      $��2* �6    .+�5      �� $��Izbor��6   .��5!      � $��0��6    � ColumnDefinitions 5"      �� 5#      $��1* �6+   �� 5$      $��2* �6+   .+�5&      �� -   5        $��LblOseba��5&   ,   $��0��6   $��Oseba��6<     LabelManageOsebaInfo#���  6L   �� 5'      -   5        $��	CBoxOsebe��5'   /   $��1��6   $ Izbor Osebe��6�   ��6@   �� *
VseOsebe+6�   5(      5)      �� 5+      $��1��6   $��Osebni Podatki��6$   {�6<   �� *PodatkiOsebeOmogoceni+.��5,      � 
 5-      �� 5.      $��1* �6(   �� 5/      $��1* �6(   �� 50      $��1* �6(   �� 51      $��1* �6(   �� 52      $	��0.2 �6(   �� 53      $��1* �6(    55      �� 56      $��1* �6+   �� 57      $��1* �6+   .+�59      �� -   5        $��LblIme��59      $	��Ime��6*   #���  68   �� 5:      -   5        $��
LblPriimek��5:   )   $��1��6   $��Priimek��6;   #���  6M   �� 5;      -	   5        $��LblEmail��5;   )   $��2��6   $��Email��69   #���  6I   �� 5<      -
   5        $��
LblTelefon��5<   )   $��3��6   $��Telefon��6;   #���  6M   �� 5=      -   5        $��LblUredi��5=   *   $��5��6   $��Uredi��6:   
�������$ Uredi Osebo��6u   � 5?      $��4��6   
���  ��6(   � 5@      $��4��6   $��1��6(   
���  ��6K   �� 5B      -   5        $��
LblImeVnos��5B   9   $��0��6   $��1��6)   ��6K   �� *TrenutnoPrikazana.Ime+�� 5C      -   5        $��LblPriimekVnos��5C   9   $��1��6   $��1��6)   ��6O   �� *TrenutnoPrikazana.Priimek+�� 5D      -   5        $��LblEmailVnos��5D   9   $��2��6   $��1��6)   ��6M   �� *TrenutnoPrikazana.EMail+�� 5E      -   5        $��LblTelefonVnos��5E   9   $��3��6   $��1��6)   ��6O   �� *TrenutnoPrikazana.Telephone+�� 5F      -   5        $��
BtnIzbrisi��5F   :   $��5��6   $��1��6*   $��Izbriši��6L   
�������$ Izbriši Osebo��6�   5G      5H      � 5I      $��2��6    5J      �� 5K      $��1* �6'   �� 5L      $��1* �6'   .+�5N      �� -   5        $��BtnOK��5N   &   $��OK��6   63   5O      5P      5Q      5R      