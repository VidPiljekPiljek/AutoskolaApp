   M S B A M L   `   `   `  ����G  CAutoskolaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:AutoskolaApp.Views.FormsAutoskolaApp.Views.Forms  5      )    #AutoskolaApp.Views.Forms.UplateForm   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:AutoskolaApp.Views.Forms     5      M IWpf.Ui, Version=4.0.0.0, Culture=neutral, PublicKeyToken=11f9f5cc97b3ffd6/ui&http://schemas.lepo.co/wpfui/2022/xaml  5         ApplicationBackgroundBrush  Wpf.Ui.Markup.Design    
Background#  �   5	      #���   5
        TextFillColorPrimaryBrush   
Foreground# �  5      #���  5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��150 �6   �� 5      $��30 �6   �� 5      $��65 �6   �� 5      $��20 �6   �� 5      $��65 �6   �� 5      $��30 �6   �� 5      $	��150 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5       $��30 �6   �� 5!      $��40 �6   �� 5"      $��30 �6   �� 5#      $��30 �6   �� 5$      $��40 �6   �� 5%      $��50 �6   �� 5&      $��35 �6   �� 5'      $��* �6   .+�5*   
   �� $��1��6   $��1��6    $��Datum Uplacenja��6-   �� 5+   
   $��3��6   $��1��6    $��Iznos��6-   �� 5,   
   $��7��6   $��1��6    $��Način Uplate��6-   �� 5-   
   $��1��6   $��4��6    $��Ime Studenta��6-   �� 5.   
   $��3��6   $��4��6    $��3��6-   $��Prezime Studenta��6A     Wpf.Ui.Controls.TextBox  50   
   -   5          Name$ txtIznos��50   Q   $��3��6c   $��2��6s   $��3��6�   ��6   �� *Iznos+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 51   
   -   5         ��Name$ cmbNacinUplate��51   ^   $��7��6v   $��2��6�    �� SelectedValue 6   �� *NacinUplate+$ PropertyChanged=�.@�52      �� -   5        $��Kartica��52   -   $��Kartica��6   6-   �� 53      -   5        $��Gotovina��53      .��6+   
Gotovina65   54        55   
   -   5        $ txtStudentIme��55   W   $��1��6n   $��5��6~   ��6   �� *ImeStudenta+$ PropertyChanged=�6~     56   
   -   5        $ txtStudentPrezime��56   [   $��3��6v   $��3��6�   $��5��6�   ��6   �� *PrezimeStudenta+$ PropertyChanged=�6�   (  "System.Windows.Controls.DatePicker  58   
   -   5          Name$ dtpDatumUplacenja��58   _   $��1��6z   $��2��6�   	   SelectedDate	 6   �� *DatumUplate+$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  59   
   $��9��6]   $��2��6m   $��3��6z   
 �� SelectedItem
 6   �� *SelectedStudent+��6<   �� *
Studenti+6�   �� 5;   
   -   5         ��Name$ btnDodaj��5;   3   $��Dodaj��6E   $��3��6U   $��7��6e   ��6   �� *SubmitCommand+6e   �� 5<   
   -	   5        $ btnOtkaži��5<   3   $��Otkaži��6G   $��5��6Y   $��7��6i   ��6   �� *CancelCommand+6i   �� 5=   
   -
   5        $ 	btnSearch��5=   3   $��Traži��6F   $��7��6V   $��5��6f   $��Center=�6s   ��6   �� *SearchCommand+6s   5>      5?      