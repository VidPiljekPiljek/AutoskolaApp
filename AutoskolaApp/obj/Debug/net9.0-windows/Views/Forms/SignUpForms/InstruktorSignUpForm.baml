   M S B A M L   `   `   `  ����G  CAutoskolaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:AutoskolaApp.Views.Forms.SignUpForms$AutoskolaApp.Views.Forms.SignUpForms  5      ?    9AutoskolaApp.Views.Forms.SignUpForms.InstruktorSignUpForm   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:AutoskolaApp.Views.Forms.SignUpForms     5      M IWpf.Ui, Version=4.0.0.0, Culture=neutral, PublicKeyToken=11f9f5cc97b3ffd6/ui&http://schemas.lepo.co/wpfui/2022/xaml  5         ApplicationBackgroundBrush  Wpf.Ui.Markup.Design    
Background#  �   5      #���   5	        TextFillColorPrimaryBrush   
Foreground# �  5
      #���  5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��150 �6   �� 5      $��30 �6   �� 5      $��65 �6   �� 5      $��20 �6   �� 5      $��65 �6   �� 5      $��30 �6   �� 5      $	��150 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5       $��30 �6   �� 5!      $��30 �6   �� 5"      $��50 �6   �� 5#      $��30 �6   �� 5$      $��* �6   .+�5'   
   �� $��1��6   $��1��6    $	��OIB��6-   �� 5(   
   $��3��6   $��1��6    $	��Ime��6-   �� 5)   
   $��7��6   $��1��6    $��Prezime��6-   �� 5*   
   $��3��6   $��4��6    $��Datum Zaposlenja��6-   $��3��6H     Wpf.Ui.Controls.TextBox  5,   
   -   5          Name$ txtOIB��5,      $��1��6%   $��2��65     5-   
   -   5        $ txtIme��5-      $��3��6%   $��2��65   $��3��6B     5.   
   -   5        $ 
txtPrezime��5.      $��2��6)   $��7��66   (  "Wpf.Ui.Controls.CalendarDatePicker  50   
   -   5          Name$ dtpDatumZaposlenja��50       $��3��6<   $��3��6L   $��5��6`     51   
   -   5        $ txtNapomena��51      $��3��6*   $��5��6:   $��3��6G   �� 53   
   -   5         ��Name$ btnDodaj��53      $��Dodaj��68   $��3��6H   $��7��6X   ��6#   �� 6X   �� 54   
   -   5        $ btnOtkaži��54      $��Otkaži��6%   $��5��6L   $��7��6\   ��67   �� 6\   55      56      