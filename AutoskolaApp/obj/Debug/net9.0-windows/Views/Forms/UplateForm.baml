   M S B A M L   `   `   `  ����G  CAutoskolaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:AutoskolaApp.Views.FormsAutoskolaApp.Views.Forms  5      )    #AutoskolaApp.Views.Forms.UplateForm   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:AutoskolaApp.Views.Forms     5      M IWpf.Ui, Version=4.0.0.0, Culture=neutral, PublicKeyToken=11f9f5cc97b3ffd6/ui&http://schemas.lepo.co/wpfui/2022/xaml  5         ApplicationBackgroundBrush  Wpf.Ui.Markup.Design    
Background#  �   5	       N� 
Background# �   5
        TextFillColorPrimaryBrush   
Foreground# �  5       N� 
Foreground# �  5       N� Title$ 
UplateForm��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��150 �6   �� 5      $��30 �6   �� 5      $��65 �6   �� 5      $��20 �6   �� 5      $��65 �6   �� 5      $��30 �6   �� 5      $	��150 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��30 �6   �� 5       $��30 �6   �� 5!      $��30 �6   �� 5"      $��30 �6   �� 5#      $��30 �6   �� 5$      $��50 �6   �� 5%      $��30 �6   �� 5&      $��* �6   .+�5)   
   �� $��1��6   $��1��6    $��Datum Uplacenja��6-   �� 5*   
   $��3��6   $��1��6    $��Iznos��6-   �� 5+   
   $��7��6   $��1��6    $��Način Uplate��6-   �� 5,   
   $��1��6   $��4��6    $��Student��6-     Wpf.Ui.Controls.TextBox  5.   
   -   5          Name$ txtIznos��5.      $��3��6'   $��2��67   $��3��6D   �� 5/   
   -   5         ��Name$ cmbNacinUplate��5/      $��7��6+   $��2��6;   �� 50   
   -   5        $ 
cmbStudent��50      $��1��6'   $��5��67   (  "Wpf.Ui.Controls.CalendarDatePicker  52   
   -   5        	  Name$	 dtpDatumUplacenja��52       $��1��6;   $��2��6K   �� 54   
   -   5        
 ��Name$
 btnDodaj��54      $��Dodaj��6#   $��3��63   $��7��6C   �� 55   
   -   5        $
 btnOtkaži��55      $��Otkaži��6%   $��5��67   $��7��6G   56      57      