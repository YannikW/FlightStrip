   M S B A M L   `   `   `  ����%  !Flight Strip Config Tool WPF V0.14    .Flight_Strip_Config_Tool_WPF_V0._1.Knightrider   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=2.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Effekt Parameter��5   	   $	��509��6"   $	��604��6/    � WindowStartupLocation$ CenterScreen=�6;   .��5      � .+�5   
   #  Xceed.Wpf.Toolkit.ColorCanvas  -   5          Name$ color1��5      $
��Left=�6+   $��	50,80,0,0q�6F   $	��Top=�6Y   �� 5   
   -   5         ��Name$ effektLabel��5      $��Effekt :��6%   $
��Left=�68   $��	10,10,0,0q�6S   $	��Top=�6f   �� 5	   
   $��Farbe des Lauflichts :��6   $
��Left=�61   $��
103,49,0,0q�6L   $	��Top=�6`   �� 5
   
   -   5         ��Name$ savebtn��5
      $��	Speichern��6"   $
��Left=�66   $��145,443,0,0q�6Q   $	��Top=�6f   $	��110��6~   6�   �� 5   
   -   5        $ 	cancelbtn��5      $��	Abbrechen��6$   $
��Left=�68   $��343,443,0,0q�6S   $	��Top=�6h   $	��110��6�   6�   �� 5   
   -   5         ��Name$ 
effectText��5      $
��Left=�6&   $��23��6A   $��	61,14,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $��TextBox��6t   $	��Top=�6�   $	��251��6�     5   
   -   5        $ color2��5      $
��Left=�6+   $��
315,80,0,0q�6F   $	��Top=�6Z   �� 5   
   $��Hintergrundfarbe :��6   $
��Left=�6-   $��
374,49,0,0q�6H   $	��Top=�6\   �� 5   
   $��Zeit bis zum Wechsel :��6   $
��Left=�61   $��
45,396,0,0q�6L   $	��Top=�6`   %  Xceed.Wpf.Toolkit.IntegerUpDown  5   
   -   5          Name$
 time��5      $
��Left=�6+   $��177,401,0,0q�6F   $	��Top=�6[   $��78��6s   �� 5   
   $��Millisekunden��6   $
��Left=�6(   $��260,396,0,0q�6C   $	��Top=�6X   �� 5   
   $��Breite des Lauflichts :��6   $
��Left=�62   $��
45,366,0,0q�6M   $	��Top=�6a     5   
   -   5        $ breite��5      $
��Left=�6-   $��177,371,0,0q�6H   $	��Top=�6]   $��78��6u   �� 5   
   $
��LEDs��6   $
��Left=�6   $��260,366,0,0q�6:   $	��Top=�6O   5      5      