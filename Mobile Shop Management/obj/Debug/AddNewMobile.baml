   M S B A M L   `   `   `  ????O  KMobileShopManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MobileShopManagementMobileShopManagement  5   	   '    !MobileShopManagement.AddNewMobile   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:MobileShopManagement     5   	     ? Title$  AddNewMobile??5
   	   $??609.756??6   $??841.463??6/   ??5      ?? 5   
    ?? EndPoint$ 0.5,1&?6    ?? 
StartPoint$ 0.5,0&?6/   .??5      ?  ? Color$ Black??6    ? Offset$ 0.413Q?6)   ? 5      $ 	#FF8000FF??6   $ 1Q?6-   ? 5      $ 	#FF110022??6   $ 0.137Q?6-   5      .??5      ? $??0,0,2,0q?6   $	??560??6   $??Bottom=?6)   ??5   
   ?? 5       ?? ImageSource 5      ?? 5       ?? 	UriSource$ file:///D:/b.png.jpg??6"   5       J? Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      .+?5   
   ?? -   5        $??Save Mobile
??5   %   $??Center=?6@   $??311,473,341,38q?6]   $	??179??6u   $??21(?6?   $??5q?6?   $??Algerian)?6?   ???	#FFE2ECE1???	#FF0F1D5B$
??Bold"?6?   $??Italic$?6?   ???	#FF14147A6  ?? 5   
   $
??Name??6   $
??Left=?6   $??	66,44,0,0q?6:   $	??Top=?6M   $
??Bold"?6e   $	??292??6w   ???	#FFE4E0DD6?   ?? 5   
   $??Model??6   $
??Left=?6    $??	66,88,0,0q?6;   $	??Top=?6N   ???	#FFE4E0DD$
??Bold"?6}   $	??292??6?   ?? 5    
   $??Company??6   $
??Left=?6"   $??
66,131,0,0q?6=   $	??Top=?6Q   ???	#FFE4E0DD$
??Bold"?6?   $	??292??6?   ?? 5!   
   $	??RAM??6   $
??Left=?6   $??66,174,475,0q?69   $	??Top=?6O   ???	#FFE4E0DD$
??Bold"?6~   $	??292??6?   ?? 5"   
   $??Storage??6   $
??Left=?6"   $??
66,217,0,0q?6=   $	??Top=?6Q   ???	#FFE4E0DD$
??Bold"?6?   $	??292??6?   ?? 5#   
   $??Battery??6   $
??Left=?6"   $??
66,261,0,0q?6=   $	??Top=?6Q   ???	#FFE4E0DD$
??Bold"?6?   $	??292??6?   ?? 5$   
   $??Front Camera??6   $
??Left=?6'   $??
66,304,0,0q?6B   $	??Top=?6V   ???	#FFE4E0DD$
??Bold"?6?   $	??292??6?   ?? 5%   
   $??Rear Camera??6   $
??Left=?6&   $??
66,345,0,0q?6A   $	??Top=?6U   ???	#FFE4E0DD$
??Bold"?6?   $	??292??6?   ?? 5&   
   $??Display??6   $
??Left=?6"   $??66,383,0,-8q?6=   $	??Top=?6R   ???	#FFE4E0DD$
??Bold"?6?   $	??292??6?   ?? 5'   
   $??Price??6   $
??Left=?6    $??66,424,0,-49q?6;   $	??Top=?6Q   ???	#FFE4E0DD$
??Bold"?6?   $	??292??6?   ?? 5(   
   -   5        $??txtmobileName??5(      $
??Left=?6'   $??26??6B   $??
430,44,0,0q?6N    ?? TextWrapping$
 Wrap=?6b   $?? ??6v   $	??Top=?6~   $	??292??6?   ???	#FFE4E0DD$??4q?6?   ?? 5)   
   -   5        	 ??Name$	 txtMobileModel??5)      $
??Left=?6*   $??26??6E   $??
430,88,0,0q?6Q   $
 Wrap=?6e   $?? ??6y   $	??Top=?6?   $	??292??6?   ???	#FFE4E0DD$??4q?6?   ?? 5*   
   -   5        $	 txtPrice??5*      $
??Left=?6$   $??23??6?   $??430,424,0,-46q?6K   $
 Wrap=?6b   $?? ??6v   $	??Top=?6~   $	??292??6?   ???	#FFE4E0DD$??4q?6?   ?? 5+   
   -   5        $	 
txtDisplay??5+      $
??Left=?6&   $??23??6A   $??430,383,0,0q?6M   $
 Wrap=?6b   $?? ??6v   $	??Top=?6~   $	??292??6?   ???	#FFE4E0DD$??4q?6?   ?? 5,   
   -   5        $	 
txtRCamera??5,      $
??Left=?6&   $??23??6A   $??430,345,0,0q?6M   $
 Wrap=?6b   $?? ??6v   $	??Top=?6~   $	??292??6?   ???	#FFE4E0DD$??4q?6?   ?? 5-   
   -   5        $	 
txtFCamera??5-      $
??Left=?6&   $??23??6A   $??430,304,0,0q?6M   $
 Wrap=?6b   $?? ??6v   $	??Top=?6~   $	??292??6?   ???	#FFE4E0DD$??4q?6?   ?? 5.   
   -   5        $	 
txtBattery??5.      $
??Left=?6&   $??23??6A   $??430,261,0,0q?6M   $
 Wrap=?6b   $?? ??6v   $	??Top=?6~   $	??292??6?   ???	#FFE4E0DD$??4q?6?   ?? 5/   
   -	   5        $	 
txtstorage??5/      $
??Left=?6&   $??23??6A   $??430,217,0,0q?6M   $
 Wrap=?6b   $?? ??6v   $	??Top=?6~   $	??292??6?   ???	#FFE4E0DD$??4q?6?   ?? 50   
   -
   5        $	 txtRam??50      $
??Left=?6"   $??23??6=   $??430,174,0,0q?6I   $
 Wrap=?6^   $?? ??6r   $	??Top=?6z   $	??292??6?   ???	#FFE4E0DD$??4q?6?   ?? 51   
   -   5        
 ??Name$
 
cmbCompany??51      $
??Left=?6)   $??430,131,0,0q?6D   $	??Top=?6Y   $	??292??6q   $??25??6}    ? Cursor$
 Hand??6?   .@?52      ?? $??Apple??6   60   ?? 53      $
??Aqua??6   6,   ?? 54      $
??Oppo??6   6,   ?? 55      $
??Vivo??6   6,   ?? 56      $??Samsung??6   6/   ?? 57      $??Infinix??6   6/   ?? 58      $??Techno??6   6.   ?? 59      $??Huawei??6   6.   ?? 5:      $??Real Me??6   6/   ?? 5;      $??Nokia??6   6-   ?? 5<      $??QMobile??6   6/   5>      5C      5D      