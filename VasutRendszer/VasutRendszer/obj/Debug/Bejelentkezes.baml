   M S B A M L   `   `   `  ����H  DVasutRendszer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:VasutRendszerVasutRendszer  5   	   !    VasutRendszer.Bejelentkezve   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:VasutRendszer     5   	   -   5          � Title$  Bejelentkezve��5   	   $	��450��6   $	��800��6,    � WindowStyle$ 
ToolWindow=�68    � WindowStartupLocation$ CenterScreen=�6Q    � Cursor$  ��6v    � Topmost . .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��198* �6   �� 5      $
��199* �6   .+�5   
   �� -   5         ��Name$ textBoxName��5      $
��Left=�6'   $��23��6B   $��	50,74,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�    J� RenderTransformOrigin$ 0.129,0.134&�6�   �� 5   
   -   5        $ textBoxPassW��5      $
��Left=�6(   $��23��6C   $��
50,133,0,0q�6O   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��120��6�   �� 5   
   -   5        	 ��Name$	 label��5      $��Felhasznalo név��6   $
��Left=�69   $��	50,43,0,0q�6T   $	��Top=�6g   $ 4.218,-5.913&�6   $��26��6�   $��93��6�   �� 5   
   -   5        $	 label1��5      $��Jelszó��6    $
��Left=�61   $��
50,102,0,0q�6L   $	��Top=�6`   $ 
1.337,0.99&�6x   $��26��6�   $��42��6�   �� 5   
   -   5        
 ��Name$
 LogIn��5      $��Bejelentkezés��6    $
��Left=�68   $��
68,186,0,0q�6S   $	��Top=�6g   $��75��6   $��19��6�   �� 5   
   -   5        $
 Registration��5      $��Regisztráció��6'   $
��Left=�6>   $��121,186,0,0q�6Y   $	��Top=�6n   $��75��6�   $��1��6�   $��19��6�   6�   �� 5   
   -   5        $ textBoxNameNew��5      $
��Left=�6*   $��23��6E   $��	99,87,0,0q�6Q   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   $ 0.129,0.134&�6�   $��1��6�   �� 5   
   -	   5        $ textBoxPassWNew��5      $
��Left=�6+   $��23��6F   $��
99,146,0,0q�6R   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��120��6�   $��1��6�   �� 5   
   -
   5        $	 
label_Copy��5      $��Felhasznalo név��6$   $
��Left=�6>   $��	99,56,0,0q�6Y   $	��Top=�6l   $ 4.218,-5.913&�6�   $��26��6�   $��93��6�   $��1��6�   �� 5   
   -   5        $	 label1_Copy��5      $��Jelszó��6%   $
��Left=�66   $��
99,115,0,0q�6Q   $	��Top=�6e   $ 
1.337,0.99&�6}   $��26��6�   $��42��6�   $��1��6�   5      5      