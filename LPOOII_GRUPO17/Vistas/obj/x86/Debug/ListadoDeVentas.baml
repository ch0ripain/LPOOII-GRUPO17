   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   
 Vistas   Vistas.ListadoDeVentas   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   HcoleccionVentas,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   ScomponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase     5   	   -   5          � Title$  PETER PARKING��5   	   $	��500��6   $
��1250��6,    � WindowStartupLocation$ CenterScreen=�6P    � Icon$3 -/Vistas;component/Images/mascaraspiderman.jpg��6u    � AllowsTransparency .  $y�Visible=�6�    � WindowStyle$ SingleBorderWindow=�6�    � 
ResizeMode$ CanMinimize=�6�   ��5      �� 5   
    �� ImageSource$+ %/Vistas;component/Images/fondodoc.png��6    j� Stretch$ UniformToFill=�6I    j� TileMode$
 None=�6a   	 � 	Resources	 5
         dsVentas
 S� 
ObjectType   ClasesBase.TrabajarTicket S� 
MethodName  VentasFiltradas �� Source �� SortDescriptions+  %System.ComponentModel.SortDescription   PropertyName   	Direction��%�   &	        &	 @     7   S� 5   
   "
  5      $ TraerVentas��5      5      �� 5   
   -   5        8    5        5      $ 	TicketNro��61   $ 	Ascending=�6J   5      5      .��5      � $��0q�6   .+�5   
   �� -   5        $��	lblTitulo��5   �   $��LISTADO DE VENTAS��6     	lblSombra#��[ 6,   $
��Bold"�6O   $��34��6a   $��Center=�6m   $	��Top=�6�   $	��188��6�   $��0,15,0,0q�6�   $��18(�6�   �� 5   
   -   5        $��lsvVenta��5       $��1��6   $��10,75,10,45q�6p   ��60   ��  �� Source# [  �� View 5      �� 5      .P�5      �� $��
N° Ticket��6%    �� Width$ 60��68    �� DisplayMemberBinding 6C   �� *	TicketNro+�� 5      $��Fecha de entrada��6%   $	 135��6?    6L   �� *FechaHoraEnt+�� 5       $��Fecha de salida��6%   $	 135��6>    6K   �� *FechaHoraSal+�� 5!      $��DNI Cliente��6%   $ 75��6:    6E   �� *
ClienteDNI+�� 5"      $	��AyN��6%   $	 125��62    6>   �� *AyN+�� 5#      $��Telefono��6%   $ 80��67    6B   �� *
Telefono+�� 5$      $��TVCodigo��6%   $ 60��67    6B   �� *
TVCodigo+�� 5%      $��Tipo Vehiculo��6%   $ 90��6<    6G   �� *TipoVehiculo+�� 5&      $��Tarifa��6%   $ 65��65    6@   �� *Tarifa+�� 5'      $��Patente��6%   $ 70��66    6A   �� *	Patente+�� 5(      $��Codigo Sector��6%   $ 80��6<    6G   �� *SectorCodigo+�� 5)      $��Descripcion��6%   $ 70��6:    6E   �� *SectorDescripcion+�� 5*      $��Identificador��6%   $ 71��6<    6G   �� *SectorIdentificador+�� 5+      $��	Duración��6%   $ 70��67    6B   �� *
Duracion+�� 5,      $��Total��6%   $ 60��64    6?   �� *Total+5-      5/      �� 50   
   -   5        $��lblFiltroFecha��50   �   $"��Filtrar por rango de fechas:��6   #��[ 67   $��28��6Z   $
��Left=�6f   $��	12,42,0,0q�6�   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  51   
   -   5        $��	dtpInicio��51   P   $��25��6   $
��Left=�6!   $��
192,45,0,0q�6<   $	��Top=�6a   $	��115��6y      SelectedDate$ 1/1/2023X�6�   6�     52   
   -   5        $��dtpFinal��52   P   $��25��6   $
��Left=�6!   $��
313,45,0,0q�6<   $	��Top=�6`   $	��115��6x   $ 
12/31/2023X�6�   6�   �� 53   
   -   5        $��btnVistaPrevia��53   �   $��Vista Previa��6     EstiloBoton#��[ 6(   $��24��6M   $��Right=�6Y   $��	0,49,10,0q�6u   $	��Top=�6�   $��97��6�   $��RightToLeft=�6�   �� 54   
   -	   5        $��lblTotal��54   �   $��Total: $��6   #��[ 6#   $��28��6F   $
��Left=�6R   $��12,421,0,10q�6m   $��Bottom=�6�   $
��Bold"�6�   55      56      