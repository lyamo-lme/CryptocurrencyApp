   M S B A M L   `   `   `  ????C  ?TestTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TestTask.ConverterTestTask.Converter  5          TestTask.Frames.Table   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3localr clr-namespace:TestTask.Converter     5        N? 
Background
  ????? N? Title$ Table??5	       ? 	Resources 5
      &    TestTask.Converter.CostConverter   CostConverter'   !TestTask.Converter.ColorConverter  ColorConverter??%:   &	        &	        5   
   67     5   
   69   5      .??5      ? -   5        .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ CurrencyTable??5   !   $
??auto??6      
IsReadOnly$
 True??68      AutoGenerateColumns$ False??5         FrozenColumnCount$ 1??6/   $??
10,29,10,0q?6E      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   CanUserResize$ False??6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 45 6;   
   Header$

 Rank??6F      
IsReadOnly$
 True??6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   ??  ?? Path$
 Rank?  5      $	 * 6%   $

 Name??6/      CanUserSort$
 True??6=   $ False??5   %   $
 True??6;    5   P   ?? $
 Name?5   ;     5      $ False??6%   $
	 auto 6;   $
 Symbol??6H   $
 True??6X    5   %   ?? $ Symbol?  5      $ False??6%   $	 * 6;   $
 Price??6E   $
 True??6T    5   %   ?? $ PriceUsd? ?? 	Converter# [   ?? StringFormat$ {0:C}??  5      $ False??6%   $
	 auto 6;   $	
 24%??6H   $
 True??6U    5   %   ?? $ ChangePercent24Hr?# [     ElementStyle 5      ?? 5       ?? 
TargetType" ??6    .?5      ??  ?? Property ? ?? ?? Value 5    %   ?? $ ChangePercent24Hr?# [ 5!      5#        5$      $ False??6%   $
	 auto 6;   $
 Market Capitalization??6H   $
 True??6g    5%   %   ?? $ MarketCapUsd?# [    5&      $ False??6%   $	 * 6;   $
 Volume??6E   $
 True??6U    5'   %   ?? $ VWap24Hr?# [    5(      $ False??6%   $	 * 6;   $
 Supply??6E   $
 True??6U    5)   %   ?? $ Supply?# [  5+      ?? 5,   
   -   5         ??Name$ CountElement??5,      $
??Left=?6(   $??71,6,0,0q?6C    ?? TextWrapping$
 Wrap=?6U   $??10??6i   $	??Top=?6s   $	??120??6?   6?   ?? 5-   
   -   5        $
 Find??5-      $??0,6,10,0q?6    $
 Wrap=?62   $?? ??6F   $??Right=?6t   $	??190??6?   $??18??6?   $	??Top=?6?   ?? 5.   
   $??Count??6   $??21,2,0,0q?6    $
??Left=?62   $??50??6M   $??25??6X   $	??Top=?6d   ?? 5/   
   $??50??6   $??25??6   $
??Find??6'   $??	0,2,192,0q?66   $??Right=?6I   $	??Top=?6e   51      52      