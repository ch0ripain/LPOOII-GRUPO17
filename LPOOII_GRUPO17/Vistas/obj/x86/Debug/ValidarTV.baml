   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   
 Vistas   Vistas.ValidarTV   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <svc,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	   -   5          � Title$  PETER PARKING��5   	   $	��393��6   $	��458��6,    � WindowStartupLocation$ CenterScreen=�68    � Icon$3 -/Vistas;component/Images/mascaraspiderman.jpg��6]    � 
ResizeMode$ CanMinimize=�6�   ��5      �� 5   
    �� ImageSource$+ %/Vistas;component/Images/fondodoc.png��6    j� Stretch$ UniformToFill=�6I    j� TileMode$
 None=�6a   .��5
      � .+�5   
   �� -   5        $��	lblCodigo��5   ~   $��Codigo��6      	lblSombra#��[  6!   $��28��6D   $
��Left=�6P   $��	71,55,0,0q�6k   $	��Top=�6�   $��87��6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $ ��lblTipoVehiculoDescripcion��5   �   $��Descripción��6   #��[  6&   $��28��6I   $
��Left=�6U   $��
71,117,0,0q�6p   $	��Top=�6�   $��Center=�6�   $��Center=�6�   $��86��6  �� 5   
   -   5        $��lblTipoVehiculoTarifa��5      $��Tarifa��6   #��[  6!   $��28��6D   $
��Left=�6P   $��
71,180,0,0q�6k   $	��Top=�6�   $��87��6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $��	lblImagen��5   �   $��
URI Imagen��6   #��[  6%   $��28��6H   $
��Left=�6T   $��
71,243,0,0q�6o   $	��Top=�6�   $��87��6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $��	txtCodigo��5   s   $��23��6   $
��Left=�6     txtRedondeado#��[ 69   $��	16,89,0,0q�6`   $	��Top=�6�   $	��200��6�   $��Center=�6�   $��Center=�6�   .��6@  ��5      �� 5       �� Path$ Codigo�6    �� UpdateSourceTrigger$ PropertyChanged=�6(   	 �� ValidatesOnExceptions	 . 
 �� ValidatesOnDataErrors
 . 5   .   .��5      5      �� 5   
   -   5        $ ��txtTipoVehiculoDescripcion��5   t   $��23��6   #��[ 6   $
��Left=�6E   $��
16,151,0,0q�6`   $	��Top=�6�   $	��198��6�   $��Center=�6�   $��Center=�6�   .��6   ��5   
   �� 5      $ Descripcion�6   $ PropertyChanged=�6)   	 . 
 . 5   .   .��5      5      �� 5   
   -   5        $��txtTipoVehiculoTarifa��5   t   $��23��6   #��[ 6   $
��Left=�6E   $��
16,214,0,0q�6`   $	��Top=�6�   $	��198��6�   $��Center=�6�   $��Center=�6�   .��65  ��5   
   �� 5      $ Tarifa�6   $ PropertyChanged=�6$   	 . 
 . 5   .   .��5      5       �� 5!   
   -	   5        $��	txtImagen��5!   t   $��23��6   #��[ 6   $
��Left=�6E   $��
16,277,0,0q�6`   $	��Top=�6�   $	��198��6�   $��Center=�6�   $��Center=�6�   .��6�   ��5"   
   �� 5#      $ Imagen�6   $ PropertyChanged=�6$   	 . 
 . 5$   .   .��5%      5&      �� 5'   
   -
   5        $��
imgPreview��5'   P   $	��172��6   $��Center=�6   $��234,128,14,0q�6:   $	��Top=�6b   $	��172��6z    J� OpacityMask �	#FF190000$+��%/Vistas;component/Images/cargando.png��6�   �� 5(   
   -   5        $��lblClienteTitulo��5(   �   $ ��MODIFICAR TIPO DE VEHICULO��6   #��[  65   $��38��6X   $��Center=�6d   $��Center=�6�   $��
87,12,87,0q�6�   $	��Top=�6�   $	��262��6�   $��18(�6�   $��Center=�6  �� 5)   
   -   5        $��btnModificar��5)   �   $��	Modificar��6   $��23��6%     EstiloBoton#��[ 61   $��Center=�6V   $��
16,0,12,12q�6s   $��Bottom=�6�   $	��408��6�   6�   �� 5*   
   -   5        $��btnCargarImagen��5*   �   $��
Ver Imagen��6   $��23��6&   #��[ 62   $
��Left=�6W   $��
250,89,0,0q�6r   $	��Top=�6�   $	��172��6�   6�   5+      5,      