   M S B A M L   `   `   `  ����G  CAutoskolaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AutoskolaApp.ViewsAutoskolaApp.Views  5      &     AutoskolaApp.Views.DashboardView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:AutoskolaApp.Views     5      M IWpf.Ui, Version=4.0.0.0, Culture=neutral, PublicKeyToken=11f9f5cc97b3ffd6/ui&http://schemas.lepo.co/wpfui/2022/xaml  5         ApplicationBackgroundBrush  Wpf.Ui.Markup.Design    
Background#  �   5      #���   5	        TextFillColorPrimaryBrush   
Foreground# �  5
      #���  5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $��35 �6   �� 5      $��20 �6   �� 5      $��35 �6   �� 5      $��20 �6   �� 5      $��35 �6   �� 5      $��20 �6   �� 5      $��35 �6   �� 5      $��20 �6   �� 5      $��35 �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5       $	��100 �6   �� 5!      $
��auto �6   .+�5%   
   �� $��
Dobar dan!��6   $��1��6&   $��2��63   6E     Wpf.Ui.Controls.Button  5&   
   $��Instruktori��6E   $��2��6[   $��1��6h   $	��100��6x   ��6   �� *NavigateToInstruktoriCommand+6x     5'   
   $��Ispiti��6@   $��4��6Q   $��1��6^   $	��100��6n   ��6   �� *NavigateToIspitiCommand+6n     5(   
   $��Studenti��6B   $��6��6U   $��1��6b   $	��100��6r   ��6   �� *NavigateToStudentiCommand+6r     5)   
   $��Uplate��6@   $��8��6Q   $��1��6^   $	��100��6n   ��6   �� *NavigateToUplateCommand+6n     5*   
   $��Voznje��6@   $��10��6Q   $��1��6_   $	��100��6o   ��6   �� *NavigateToVoznjeCommand+6o   5+      5,      