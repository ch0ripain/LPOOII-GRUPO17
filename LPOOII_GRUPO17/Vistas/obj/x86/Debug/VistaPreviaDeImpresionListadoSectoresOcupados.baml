   M S B A M L   `   `   `  ����
  Vistas:    4Vistas.VistaPreviaDeImpresionListadoSectoresOcupados   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$?  9Vista previa de impresión - Listado de sectores ocupados��5   	   $	��485��6J   $	��725��6W    � WindowStartupLocation$ CenterScreen=�6c    � Icon$3 -/Vistas;component/Images/mascaraspiderman.jpg��6�    � 
ResizeMode$ CanMinimize=�6�   .��5      �� $	��694��6    �� Orientation$ Vertical=�6   $��LeftToRight=�64   .+�5   
   -�  �� Left$ 12��6   
 �� Top$ 28��6.   $	��405��6>   .��5      /� -   5         �Name$ DocMain��5      .T�5      J� $
��Bold"�6    �� Margin$ 0q�6.   	 �� TextAlignment$	 Center=�69   .*�6P   LISTADO DE SECTORES OCUPADOS6n   �� 5	      .r�5
      �� -   5        $��	lsvSector��5
   ,   $��1��6   $��	0,20,0,10q�6U   ��6=   �� 
 �� View
 5      �� 5      ! �� ColumnHeaderContainerStyle 5   "   �� 5   &   .�5   *   ��  �� Property � �� �� Value$ 12(�6M   5   '   .P�5   "   �� $
��Zona��61    �� Width$ 50��6?    �� DisplayMemberBinding 6J   �� *Identificador+�� 5   "   $��Sector��61   $ 65��6A    6L   �� *Descripcion+�� 5   "   $��Fecha de entrada��61   $	 140��6K    6W   �� *TiempoDisponible+�� 5   "   $��Cliente��61   $	 145��6B    6N   �� *AyN+�� 5   "   $��T. Vehiculo��61   $ 90��6F    6Q   �� *
Vehiculo+�� 5   "   $��Patente��61   $ 75��6B    6M   �� *	Patente+�� 5   "   $��	Duración��61   $ 85��6C    6N   �� *
Duracion+5      ��5      �� 5       �� 
TargetType" ��6$   .�5   "   ��  � ��$ 12(�6=   5      5       5!      5"      5#      �� 5$   
   -   5        $��btnImprimir��5$   0   $��Imprimir��6   $��30��6$   $��0q�6]   5%      5&      