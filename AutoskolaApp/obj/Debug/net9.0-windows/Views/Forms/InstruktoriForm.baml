   M S B A M L   `   `   `  ����G  CAutoskolaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:AutoskolaApp.Views.FormsAutoskolaApp.Views.Forms  5      .    (AutoskolaApp.Views.Forms.InstruktoriForm   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:AutoskolaApp.Views.Forms     5      M IWpf.Ui, Version=4.0.0.0, Culture=neutral, PublicKeyToken=11f9f5cc97b3ffd6/ui&http://schemas.lepo.co/wpfui/2022/xaml  5         ApplicationBackgroundBrush  Wpf.Ui.Markup.Design    
Background#  �   5	      #���   5
        TextFillColorPrimaryBrush   
Foreground# �  5      #���  5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��150 �6   �� 5      $��30 �6   �� 5      $��65 �6   �� 5      $��20 �6   �� 5      $��65 �6   �� 5      $��30 �6   �� 5      $	��150 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��30 �6   �� 5      $��40 �6   �� 5       $��30 �6   �� 5!      $��30 �6   �� 5"      $��40 �6   �� 5#      $��30 �6   �� 5$      $��30 �6   �� 5%      $��40 �6   �� 5&      $��50 �6   �� 5'      $��35 �6   �� 5(      $��* �6   .+�5+   
   �� $��1��6   $��1��6    $��Korisnicko Ime��6-   �� 5,   
   $��3��6   $��1��6    $��Lozinka��6-   �� 5-   
   $��1��6   $��4��6    $	��OIB��6-   �� 5.   
   $��3��6   $��4��6    $	��Ime��6-   �� 5/   
   $��7��6   $��4��6    $��Prezime��6-   �� 50   
   $��1��6   $��7��6    $��Datum Početka��6-   �� 51   
   $��3��6   $��7��6    $��Napomena��6-   $��3��6@     Wpf.Ui.Controls.TextBox  53   
   -   5          Name$ txtKorisnickoIme��53      $��1��6/   $��2��6?   ��6L   �� *KorisnickoIme+ �� UpdateSourceTrigger$ PropertyChanged=�  54   
   -   5        $ 
txtLozinka��54      $��3��6)   $��2��69   $��3��6F   ��6Z   �� *	Lozinka+$ PropertyChanged=�  55   
   -   5        $ txtOIB��55      $��1��6%   $��5��65   ��6C   �� *OIB+$ PropertyChanged=�  56   
   -   5        $ txtIme��56      $��3��6%   $��5��65   $��3��6B   ��6V   �� *Ime+$ PropertyChanged=�  57   
   -   5        $ 
txtPrezime��57      $��5��6)   $��7��66   ��6F   �� *	Prezime+$ PropertyChanged=�(  "System.Windows.Controls.DatePicker  59   
   -   5          Name$ dtpDatumZaposlenja��59      $��1��61   $��8��6A      SelectedDate 6N   �� *DatumPocetka+$ PropertyChanged=�  5:   
   -   5        $ txtNapomena��5:      $��3��6*   $��8��6:   $��3��6G   ��6[   �� *
Napomena+$ PropertyChanged=��� 5<   
   -   5         ��Name$ btnDodaj��5<   3   $��Dodaj��6E   $��3��6U   $��10��6e   ��6   �� *SubmitCommand+6e   �� 5=   
   -	   5        $ btnOtkaži��5=   3   $��Otkaži��6G   $��5��6Y   $��10��6i   ��6   �� *CancelCommand+6i   5>      5?      