   M S B A M L   `   `   `  ����G  CAutoskolaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AutoskolaApp.Views.Pages.Instruktor#AutoskolaApp.Views.Pages.Instruktor  5      4    .AutoskolaApp.Views.Pages.Instruktor.IspitiPage   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:AutoskolaApp.Views.Pages.Instruktor     5      M IWpf.Ui, Version=4.0.0.0, Culture=neutral, PublicKeyToken=11f9f5cc97b3ffd6/ui&http://schemas.lepo.co/wpfui/2022/xaml  5         ApplicationBackgroundBrush  Wpf.Ui.Markup.Design    
Background#  �   5	       N� 
Background# �   5
        TextFillColorPrimaryBrush   
Foreground# �  5       N� 
Foreground# �  5       N� Title$ 
IspitiPage��5      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $	��300 �6   �� 5       $��30 �6   �� 5!      $��* �6   �� 5"      $��20 �6   .+�5%   
   �� $��Ispiti��6   $��1��6!   $��1��6.   $
��Left=�6>   �� 5&   
   $��	Rezultati��6   $��1��6$   $��3��61   $
��Left=�6A   �� 5'   
   $��
Statistika��6   $��5��6%   $��1��62   $
��Left=�6B     Wpf.Ui.Controls.DataGrid  5)   
   $��3��6   $��1��6#   ��63   ��   5*   
   $��3��6   $��3��6#   ��63   ��   5+   
   $��7��6   $��1��6#   $��3��63   ��6G   �� �� 5-   
    �� Orientation$ 
Horizontal=�6   $��5��6.   $��3��6;   .+�5.        Wpf.Ui.Controls.Button  -   5          Name$ btnDodajUpis��5.      $��	Novi upis��6.     5/      -   5        $ btnUrediOdabir��5/      $��Uredi odabir��60   $��20, 0, 0, 0q�6G   50      51      52      