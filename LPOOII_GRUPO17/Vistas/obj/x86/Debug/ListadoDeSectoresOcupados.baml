   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   
 Vistas&    Vistas.ListadoDeSectoresOcupados   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   JcoleccionSectores,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   ScomponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase     5   	     � Title$  PETER PARKING��5   	   $	��500��6   $	��750��6,    � WindowStartupLocation$ CenterScreen=�68    � Icon$3 -/Vistas;component/Images/mascaraspiderman.jpg��6]    � AllowsTransparency .  $y�Visible=�6�    � WindowStyle$ SingleBorderWindow=�6�    � 
ResizeMode$ CanMinimize=�6�   ��5      �� 5   
    �� ImageSource$+ %/Vistas;component/Images/fondodoc.png��6    j� Stretch$ UniformToFill=�6I    j� TileMode$
 None=�6a   	 � 	Resources	 5
         
dsSectores
 S� 
ObjectType   ClasesBase.TrabajarSector S� 
MethodName  SectoresOcupados �� Source �� SortDescriptions+  %System.ComponentModel.SortDescription   PropertyName   	Direction��%�   &	        &	 J     7   S� 5   
   "
  5      $ TraerSectoresOcupados��5      5      �� 5   
   8    5        5      $ Identificador��61   $ 	Ascending=�6N   5      5      .��5      � .+�5   
   �� -   5        $��	lblTitulo��5   r   $"��LISTADO DE SECTORES OCUPADOS��6   $��31��67   $��Center=�6C   $��0,12,0,0q�6`   $	��Top=�6�   $
��Bold"�6�   
�������$��18(�6�   �� 5   
   -   5        $��	lsvSector��5       $��1��6   $��10,60,10,10q�6r   ��61   ��  �� Source# [  �� View 5      �� 5      .P�5      �� $
��Zona��6%    �� Width$ 50��63    �� DisplayMemberBinding 6>   �� *Identificador+�� 5      $��Sector��6%   $ 65��65    6@   �� *Descripcion+�� 5      $��Fecha de entrada��6%   $	 145��6?    6K   �� *TiempoDisponible+�� 5       $��Cliente��6%   $	 140��66    6B   �� *AyN+�� 5!      $��Tipo de vehiculo��6%   $	 100��6?    6K   �� *
Vehiculo+�� 5"      $��Patente��6%   $ 65��66    6A   �� *	Patente+�� 5#      $��Tiempo transcurrido��6%   $	 150��6B    6N   �� *
Duracion+5$      5&      �� 5'   
   -   5        $��btnVistaPrevia��5'   �   $��Vista Previa��6     EstiloBoton#��[ 6(   $��24��6M   $��Right=�6Y   $��	0,29,10,0q�6u   $	��Top=�6�   $��97��6�   $��RightToLeft=�6�   5(      5)      