   M S B A M L   `   `   `  ����A  =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistasVistas  5   	       Vistas.EstadoSector   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   $svcclr-namespace:Vistas     5   	     � Title$  EstadoSector��5   	   $	��237��6   $	��300��6+    � WindowStartupLocation$ CenterScreen=�67    � Icon$E ?/Vistas;component/Images/Peter_Parking_Grupo_17-transformed.png��6\    � 	Resources 5         Tiempos � Source � XPath  Vistas.ConversorDeEstados  conversorEstado��%`   &	        &	 9     � 5   
   $ Tiempos.xml?�6*   $ /tiempos��6?     5   
   6!   5	      .��5
      � .+�5   
   �� -   5         ��Name$ 	cmbTiempo��5      $��23��6&   $
��Left=�62   $��
146,17,0,0q�6M   $	��Top=�6a   $	��120��6y    �� SelectedIndex$ 0��6�   ��6�   ��  �� Source# [  	 �� XPath$	 tiempo/@name��6�   �� 5   
   -   5        $��
lblTiempos��5   j   $��Seleccione un tiempo:��6   $��28��60   $
��Left=�6<   $��	12,12,0,0q�6W   $	��Top=�6|   �� 5   
   -   5        $��	rctEstado��5   O   $	��100��6   $
��Left=�6!   $��	39,67,0,0q�6<   
���   �$	��Top=�6o   $	��200��6�   ��6�   �� *SelectedValue+
 �� ElementName$
 	cmbTiempo�� �� 	Converter# [ 5      5      