   M S B A M L   `   `   `  ����G  CAutoskolaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:AutoskolaApp.Views.FormsAutoskolaApp.Views.Forms  5      )    #AutoskolaApp.Views.Forms.VoznjeForm   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:AutoskolaApp.Views.Forms     5      M IWpf.Ui, Version=4.0.0.0, Culture=neutral, PublicKeyToken=11f9f5cc97b3ffd6/ui&http://schemas.lepo.co/wpfui/2022/xaml  5         ApplicationBackgroundBrussh  Wpf.Ui.Markup.Design    
Background#  �   5	        ApplicationBackgroundBrush#���  5
        TextFillColorPrimaryBrush   
Foreground# �  5      #���  5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��150 �6   �� 5      $��30 �6   �� 5      $��65 �6   �� 5      $��20 �6   �� 5      $��65 �6   �� 5      $��30 �6   �� 5      $	��150 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5!      $��30 �6   �� 5"      $��40 �6   �� 5#      $��30 �6   �� 5$      $��30 �6   �� 5%      $��40 �6   �� 5&      $��30 �6   �� 5'      $��35 �6   �� 5(      $��30 �6   �� 5)      $��* �6   .+�5,   
   �� $��1��6   $��1��6    $��Datum Voznje��6-   �� 5-   
   $��3��6   $��1��6    $��Ime Instruktora��6-   $��3��6G   �� 5.   
   $��7��6   $��1��6    $��Prezime Instruktora��6-   �� 5/   
   $��1��6   $��4��6    $��Ime Studenta��6-   �� 50   
   $��3��6   $��4��6    $��Prezime Studenta��6-   $��3��6H   (  "System.Windows.Controls.DatePicker  52   
   $��1��6_   $��2��6o      SelectedDate 6   �� *DatumVoznje+ �� UpdateSourceTrigger$ PropertyChanged=�6o     Wpf.Ui.Controls.TextBox  53   
   $��3��6Y   $��2��6i   $��3��6v   ��6   �� *InstruktorIme+$ PropertyChanged=�6v     54   
   $��7��6]   $��2��6m   ��6   �� *InstruktorPrezime+$ PropertyChanged=�6m     55   
   $��1��6V   $��5��6f   ��6   �� *
StudentIme+$ PropertyChanged=�6f     56   
   $��3��6Z   $��5��6j   $��3��6w   ��6   �� *StudentPrezime+$ PropertyChanged=�6w   &   System.Windows.Controls.DataGrid  57   
   $��9��6c   $��1��6s   $��3��6�    �� SelectedItem 6   �� *SelectedInstruktor+��6?   �� *Instruktori+6�     58   
   $��9��6]   $��4��6m   $��3��6z    6   �� *SelectedStudent+��6<   �� *
Studenti+6�   �� 5:   
   -   5         ��Name$ btnDodaj��5:   3   $��Dodaj��6E   $��3��6U   $��7��6e   ��6   �� *SubmitCommand+6e   �� 5;   
   -   5        $ btnOtkaži��5;   3   $��Otkaži��6G   $��5��6Y   $��7��6i   ��6   �� *CancelCommand+6i   �� 5<   
   -   5        $ 	btnSearch��5<   3   $��Traži��6F   $��7��6V   $��5��6f   $��Center=�6s   ��6   �� *SearchCommand+6s   5=      5>      