   M S B A M L   `   `   `  ????  TestTask    TestTask.Frames.Cryptos   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      R NOxyPlot.Wpf, Version=2.1.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0Y UOxyPlot.Wpf.Shared, Version=2.1.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0"oxyhttp://oxyplot.org/wpf   5        N? 
Background
  ????? N? Title$ Cryptos??5	      .??5      ? -   5         ? RowDefinitions 5   
   ?? 5      $	??163 ?6   ?? 5      $??57 ?6    ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6!   .+?5   
   ?? $
??Name??6   $
??Left=?6   $??9,17,0,0q?6:   $	??Top=?6L   ?? 5   
   $??Price??6   $
??Left=?6    $??9,43,0,0q?6;   $	??Top=?6M   ?? 5   
   $	??24%??6   $
??Left=?6   $??10,0,0,0q?69   $??Center=?6K   ?? 5   
   $??Symbol??6   $
??Left=?6!   $??
10,119,0,0q?6<   $	??Top=?6P   ?? 5   
   $??Supply??6   $
??Left=?6!   $??	10,88,0,0q?6<   $	??Top=?6O   ?? 5   
   $??History??6   $
??Left=?6"   $	??Top=?6=   $??65??6U   $??	201,9,0,0q?6`   ?? 5   
   $??51,17,264,120q?6.   ??6   ??  ?? Path$
 Name?6.   ?? 5   
   $??64,119,251,18q?60   ??6   ?? $ Symbol?60   ?? 5   
   $??51,43,264,94q?62   ??6   ?? $ PriceUsd?62   ?? 5   
   $??56,88,259,49q?60   ??6   ?? $ Supply?60   ?? 5   
   $??43,68,272,69q?6;   ??6   ?? $ ChangePercent24Hr?6;   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ HistoryTable??5   0      AutoGenerateColumns$ False??6   $??
201,0,0,24q?6G   $
??Left=?6[   $	??280??6v   $	??161??6?   $??Bottom=?6?   $??2??6?   $??2??6?      Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   CanUserResize$ False??6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6;   
   Header$
 PriceUsd??6E      
IsReadOnly$
 True??6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6j   ?? $ PriceUsd?  5"      $ False??6%   $	 * 6;   $

 Date??6E   $
 True??6T    6f   ?? $
 Date?5$      ?? 5%   
   $??Market??6   $
??Left=?6!   $	??Top=?6<   $??65??6T   $??98,2,0,0q?6_   $??1??6q     5&   
   -   5        $ MarketTable??5&   /   $ False??6   $??	89,22,0,0q?6E   $
??Left=?6X   $	??303??6s   $	??175??6   $	??Top=?6?   $??1??6?   $??2??6?    5'        5(      $ False??6%   $	 * 6;   $
 Market??6E   $
 True??6V    6h   ?? $ 
ExchangeId?  5)      $ False??6%   $	 * 6;   $
 PriceUsd??6E   $
 True??6X    6j   ?? $ PriceUsd?  5*      $ False??6%   $	 * 6;   $

 Date??6E   $
 True??6T    6f   ?? $ VolumePercent?5,        OxyPlot.Wpf.PlotView  5-   
   -   5          Name$ pm??5-      $??0,39,0,-196q?6#   $??2??68   $??1??6L   ? 5.   
   -   5         ?Name$ ProgressBar??5.      $??4??6+   $	??Top=?66   $??2??6N   ?? 5/   
   -   5         ??Name$ LoadingLayout??5/      $y?Hidden=?6,   $
??Left=?6@   $	??416??6[   $??1,0,0,0q?6h   
???   ?$	??Top=?6?   $	??803??6?   $??2??6?   $??2??6?   50      51      