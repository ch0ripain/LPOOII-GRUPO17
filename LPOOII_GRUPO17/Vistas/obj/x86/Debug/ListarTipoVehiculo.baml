   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   
 Vistas   Vistas.ListarTipoVehiculo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <svc,clr-namespace:ClasesBase;assembly=ClasesBase     5   	     � Title$8  2PETER PARKING - Listado de los tipos de vehículos��5   	   $	��400��6C   $	��600��6P    � Icon$3 -/Vistas;component/Images/mascaraspiderman.jpg��6\    � 
ResizeMode$ CanMinimize=�6�    � WindowStartupLocation$ CenterScreen=�6�   ��5      �� 5   
    �� ImageSource$+ %/Vistas;component/Images/fondodoc.png��6    j� Stretch$
 Fill=�6I    j� TileMode$
 None=�6X    � 	Resources 5	         misTipoVehiculo S� 
ObjectType&    ClasesBase.TrabajarTiposVehiculo	 S� 
MethodName��%@   &	        S� 5
   
   "  65   $	 TraerTiposVehiculo��6e   5      .��5      �� $	��300��6   $	��500��6   ��6(   �� 
 �� Source#
 [   �� View 5   
   �� 5      P�5      �� 5       �� Width$	 165��6%   $#��Código del tipo de vehículo��61    �� DisplayMemberBinding 6V   ��  �� Path$ TVCodigo��� 5      $	 165��6%   $��Descripción��61    6F   �� $ Descripcion��� 5      $	 162��6%   $��Tarifa��61    6A   �� $ Tarifa�5      5      5      