   M S B A M L   `   `   `  ����G  CAutoskolaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AutoskolaApp.ViewsAutoskolaApp.Views  5      "    AutoskolaApp.Views.LoginView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:AutoskolaApp.Views     5      M IWpf.Ui, Version=4.0.0.0, Culture=neutral, PublicKeyToken=11f9f5cc97b3ffd6/ui&http://schemas.lepo.co/wpfui/2022/xaml  5         ApplicationBackgroundBrush  Wpf.Ui.Markup.Design    
Background#  �   5      #���   5	        TextFillColorPrimaryBrush   
Foreground# �  5
      #���  5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��35 �6   �� 5      �� 5      $��35 �6   �� 5      $��40 �6   �� 5      $��35 �6   �� 5      $��40 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5    
   �� $��0 0 5 0q�6   $��Korisničko ime:��6!   $��4��6;   $��0��6H   $��Center=�6X   $��Right=�6s   �� 5!   
   $��0 0 5 0q�6   $��Lozinka:��6!   $��6��64   $��0��6A   $��Center=�6Q   $��Right=�6l   �� 5"   
   $��0 0 5 0q�6   $��Vid Piljek, 2025.��6!   $��7��6=   $��2��6J   $��Bottom=�6Z   $��Right=�6u     Wpf.Ui.Controls.TextBox  5#   
   $��4��6Y   $��1��6f   ��6   �� *KorisnickoIme+ �� UpdateSourceTrigger$ PropertyChanged=�6f   !  Wpf.Ui.Controls.PasswordBox  5$   
   $��6��6W   $��1��6d   ��6   �� *	Lozinka+$ PropertyChanged=�6d     Wpf.Ui.Controls.Button  5%   
   $��1��65   $��Login��6E   $��7��6U   $��Center=�6b   $��Center=�6}   $	��100��6�   ��6   �� *LoginCommand+6�   �� 5(   
   $��1��6   $��0��6%   .+�5)      �� $��Center=�6   $
��Wrap=�65   $��
Autoškola��6I   $��Center=�6Z   $��40(�6u   �� 5*      $!��Molimo vas da se prijavite.��6   $��Center=�6:   $��Center=�6W   5+      5,      5-      