   M S B A M L   `   `   `  ����
  Vistas0    *Vistas.VistaPreviaDeImpresionListadoVentas   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$4  .Vista previa de impresión - Listado de ventas��5   	   $
��1425��6?    � WindowStartupLocation$ CenterScreen=�6L   $	��725��6q    � Icon$3 -/Vistas;component/Images/mascaraspiderman.jpg��6�   .��5      �� $
��1400��6    �� Orientation$ Vertical=�6   $��LeftToRight=�65   $	��665��6Q   .+�5   
   -�  �� Left$ 12��6   
 �� Top$ 28��6.   $
��Left=�6>   $	��Top=�6`   $	��635��6   .��5      /� -   5         �Name$ DocMain��5      .T�5      J� -   5         J�Name$ 	prgTitulo��5      $
��Bold"�6/    �� Margin$ 0q�6A   	 �� TextAlignment$	 Center=�6L   .*�6c   LISTADO DE VENTAS6v   J� 5	      -   5        $ prgTotal��5	      $
��Bold"�6.   $ 0q�6@   $	 Center=�6K   .*�6b   
Total: $6l   �� 5
      .r�5      �� -   5        $��lsvVenta��5   ,   $��1��6   $��	0,30,0,10q�6T   ��6<   �� 
 �� View
 5      �� 5      ! �� ColumnHeaderContainerStyle 5   "   �� 5   &   .�5   *   ��  �� Property � �� �� Value$ 12(�6M   5   '   .P�5   "   �� $��
N° Ticket��61    �� DisplayMemberBinding 6D   �� *	TicketNro+�� 5   "   $��Fecha de entrada��61    �� Width$	 140��6K    6W   �� *FechaHoraEnt+�� 5   "   $��Fecha de salida��61   $	 140��6K    6W   �� *FechaHoraSal+�� 5   "   $��DNI Cliente��61    6G   �� *
ClienteDNI+�� 5   "   $	��AyN��61   $	 170��6>    6J   �� *AyN+�� 5   "   $��Telefono��61   $	 120��6C    6O   �� *
Telefono+�� 5   "   $��TVCodigo��61    6C   �� *
TVCodigo+�� 5   "   $��Tipo Vehiculo��61    6H   �� *TipoVehiculo+�� 5   "   $��Tarifa��61   $ 70��6A    6L   �� *Tarifa+�� 5   "   $��Patente��61   $ 80��6B    6M   �� *	Patente+�� 5   "   $��Codigo Sector��61    6H   �� *SectorCodigo+�� 5   "   $��Descripcion��61    6F   �� *SectorDescripcion+�� 5   "   $
��Zona��61   $ 80��6?    6J   �� *SectorIdentificador+�� 5    "   $��	Duración��61   $ 85��6C    6N   �� *
Duracion+�� 5!   "   $��Total��61   $ 70��6@    6K   �� *Total+5"      ��5$      �� 5%       �� 
TargetType" ��6$   .�5&   "   ��  � ��$ 12(�6=   5'      5)      5*      5+      5,      �� 5-   
   -   5        $��btnImprimir��5-   0   $��Imprimir��6   $��30��6$   $��0q�6]   $��0q�6h   $��Stretch=�6t   5.      5/      