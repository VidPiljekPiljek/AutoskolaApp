   M S B A M L   `   `   `  ����G  CAutoskolaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AutoskolaApp.ViewsAutoskolaApp.Views  5      #    AutoskolaApp.Views.SignUpView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:AutoskolaApp.Views     5      M IWpf.Ui, Version=4.0.0.0, Culture=neutral, PublicKeyToken=11f9f5cc97b3ffd6/ui&http://schemas.lepo.co/wpfui/2022/xaml  5         ApplicationBackgroundBrush  Wpf.Ui.Markup.Design    
Background#  �   5      #���   5	        TextFillColorPrimaryBrush   
Foreground# �  5
      #���  5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��35 �6   �� 5      �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Korisničko ime:��6   $��4��6*   $��0��67   $��Center=�6G   $��Right=�6b   $��5q�6~   �� 5    
   $��Lozinka:��6   $��6��6#   $��0��60   $��Center=�6@   $��Right=�6[   $��5q�6w   �� 5!   
   $��Vid Piljek, 2024.��6   $��7��6,   $��2��69   $��Bottom=�6I   $��Right=�6d   $��5q�6�     Wpf.Ui.Controls.TextBox  5"   
   $��4��6   $��1��6"   !  Wpf.Ui.Controls.PasswordBox  5#   
   $��6��6   $��1��6&   �� 5%   
   $��1��6   $��1��6%   $��2��62   $��Bottom=�6C   .+�5&      	� $	��5 0q�6   $��Korisnik��6'   	� 5'      $	��5 0q�6   $��
Instruktor��6'   	� 5(      $	��5 0q�6   $��Administrator��6'   5)      �� 5+   
   $��1��6   $��0��6%   .+�5,      �� $��Center=�6   $
��Wrap=�65   $��To Do List App��6I   $��Center=�6_   $��40(�6z   �� 5-      $%��Molimo vas da napravite račun.��6   $��Center=�6=   $��Center=�6Z   5.      %  Wpf.Ui.Controls.HyperlinkButton  5/   
   $��Center=�6   $��Već imam račun.��6N   $��5��6h   $��2��6u   ��6:   �� 6u   �� 50   
   $��Odaberite vrstu računa:��6   $��2��62   $��0��6?   $��Center=�6O   $
��Left=�6j   $��	118,0,0,0q�6�   51      52      