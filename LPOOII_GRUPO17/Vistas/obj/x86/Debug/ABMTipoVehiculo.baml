   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   
 Vistas   Vistas.ABMTipoVehiculo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <svc,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   -   5          � Title$/  )PETER PARKING - ABM DE TIPOS DE VEHICULOS��5   	   $	��400��6;   $	��525��6H   $	��Top=�6k   $��Center=�6�    � WindowStartupLocation$ CenterScreen=�6�    � Icon$3 -/Vistas;component/Images/mascaraspiderman.jpg��6�    � 
ResizeMode$ CanMinimize=�6�   ��5      �� 5   
    �� ImageSource$&  /Vistas;component/Images/abm.png��6    j� Stretch$ UniformToFill=�6D    j� TileMode$
 None=�6\    � 	Resources 5	         LIST_TV S� 
ObjectType&    ClasesBase.TrabajarTiposVehiculo	 S� 
MethodName��%R   &	        S� 5
   
   "  5      $	 TraerTiposVehiculos��5      5      5      .��5      �� -   5        $��canvas_content��5      $	��480��6g   
 � DataContext
 6#   ��  �� Source# [  .+�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   $	��Top=�6I   $
��0,25q�6a   .+�5      �� $ 
Horizontal=�6   $��Stretch=�62   $��Stretch=�6P   $
��0,15q�6l   .+�5      �� -   5        $��
btnNuevoTV��5   �     BotonNeonStyle#��[ 6   $��Agregar��6A   $��23��6S   $
��Left=�6_   $��0,0,0,0q�6z   $	��Top=�6�   6�   �� 5      -   5        $��btnModificar��5   �     BotonNeonAzulStyle#��[ 6   $��	Modificar��6E   $��23��6Y   $
��Left=�6e   $��0,0,0,0q�6�   $	��Top=�6�   6�   �� 5      -   5        $��	btnListar��5   �     BotonNeonAmarilloStyle#��[ 6   $��Listar��6I   $��23��6Z   $
��Left=�6f   $��0,0,0,0q�6�   $	��Top=�6�   6�   �� 5      -   5        $��btnEliminar��5   �     BotonNeonRojoStyle#��[ 6   $��Eliminar��6E   $��23��6X   $��Right=�6d   $��0,0,0,0q�6�   $	��Top=�6�   6�   5      ]� 5      $	��400��6   $	��Top=�6$   $��0,0,0,0q�6<   .+�5      ]� $
��Left=�6   $	��200��62   .+�5      �� $ Vertical=�6!   $��0q�68   .+�5      �� -   5        $��lblReferencia��5   �     	lblSombra#��[ 6    $��
REFERENCIA��6C   $��24��6X   $��Center=�6d   $��0q�6�   $��Center=�6�   $��	0,15,0,10q�6�   �� 5      -   5        $��lblTVCodigo��5   b   #��[ 6    $��TVCodigo��6C   $��30��6V   $��Center=�6u   $��Center=�6�   $��Center=�6�   �� 5      -	   5        $��lblDescripcion��5   e   #��[ 6    $��Descripción��6C   $��30��6Y   $��Center=�6{   $��Center=�6�   �� 5      -
   5        $��	lblTarifa��5   `   #��[ 6    $��Tarifa��6C   $��30��6T   $��Center=�6q   $��Center=�6�   �� 5      -   5        $��	lblImagen��5   j   #��[ 6    $��URI de la imagen��6C   $��30��6^   $��Center=�6{   $��Center=�6�   $��0,0,0,10q�6�   5       5!      ]� 5"      $��Right=�6   $	��200��63   $��0,0,0,0q�6?   .+�5#      �� -   5        $��stpDatosUsuario��5#   !   $ Vertical=�68   $��0,0,0,0q�6O   .+�5$      �� -   5        $��lblDatosDelTV��5$   _   #��[ 6    $��DATOS��6C   $��24��6S   $��0q�6t   $��	0,15,0,20q�6�   $��Center=�6�   $��Center=�6�   $	��180��6�   �� 5%      -   5        $��txtTVCodigo��5%   �     txtRedondeado#��[ 6"   $	��160��6c   $��24��6o   $��0,0,0,14q�6{   $��Center=�6�    �� 
IsReadOnly . $��Center=�6�   $��Center=�6�   $��Center=�6  ��6I   �� *
TVCodigo+62  �� 5&      -   5        $��txtDescripcion��5&   �   #��[ 6"   $	��160��6f   $��24��6r   $��Center=�6~    . $��Center=�6�   $��Center=�6�   $��0,0,0,15q�6	  ��6I   �� *Descripcion+6  �� 5'      -   5        $��	txtTarifa��5'   �   #��[ 6"   $	��160��6a   $��24��6m   $��Center=�6y    . $��Center=�6�   $��Center=�6�   $��0,0,0,15q�6�   ��6I   �� *Tarifa+6  �� 5(      -   5        $��	txtImagen��5(   �   #��[ 6"   $	��160��6a   $��24��6m   $��Center=�6y    . $��Center=�6�   $��Center=�6�   ��6I   �� *Imagen+6  5)      5*      5+      �� 5,      $ 
Horizontal=�6   $
��0,15q�62   .+�5-      �� -   5        $��
btnPrimero��5-   Q     EstiloBoton#��[ 6   $��<<��6>   6~   �� 5.      -   5        $��btnAnterior��5.   M   #��[ 6   $��<��6>   6|   �� 5/      -   5        $��btnSiguiente��5/   M   #��[ 6   $��>��6>   6~   �� 50      -   5        $��	btnUltimo��50   Q   #��[ 6   $��>>��6>   6|   51      52      53      54      