   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   
 Vistas   Vistas.ABMClientes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <svc,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   -   5          � Title$%  PETER PARKING - ABM DE CLIENTES��5   	   $	��420��61   $	��525��6>   $	��Top=�6J   $��Center=�6b    � WindowStartupLocation$ CenterScreen=�6    � Icon$3 -/Vistas;component/Images/mascaraspiderman.jpg��6�    � 
ResizeMode$ CanMinimize=�6�   ��5      �� 5   
    �� ImageSource$&  /Vistas;component/Images/abm.png��6    j� Stretch$ UniformToFill=�6D    j� TileMode$
 None=�6\    � 	Resources 5	         LIST_CLIENT S� 
ObjectType!   ClasesBase.TrabajarClientes	 S� 
MethodName��%L   &	        S� 5
   
   "  5      $	 TraerClientes��5      5      5      .��5      �� -   5        $��canvas_content��5      $	��480��6k   
 � DataContext
 6#   ��  �� Source# [  .+�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   $	��Top=�6I   $
��0,30q�6a   .+�5      �� $ 
Horizontal=�6   $��Stretch=�62   $��Stretch=�6P   $
��0,15q�6l   .+�5      �� -   5        $��btnNuevoCliente��5   �     BotonNeonStyle#��[ 6   $��Agregar��6A   $��23��6S   $
��Left=�6_   $��0,0,0,0q�6z   $	��Top=�6�   6�   �� 5      -   5        $��btnModificar��5   �     BotonNeonAzulStyle#��[ 6   $��	Modificar��6E   $��23��6Y   $
��Left=�6e   $��0,0,0,0q�6�   $	��Top=�6�   6�   �� 5      -   5        $��	btnListar��5   �     BotonNeonAmarilloStyle#��[ 6   $��Listar��6I   $��23��6Z   $
��Left=�6f   $��0,0,0,0q�6�   $	��Top=�6�   6�   �� 5      -   5        $��btnEliminar��5   �     BotonNeonRojoStyle#��[ 6   $��Eliminar��6E   $��23��6X   $��Right=�6d   $��0,0,0,0q�6�   $	��Top=�6�   6�   5      ]� 5      $	��400��6   $	��Top=�6$   $��0,0,0,0q�6<   .+�5      ]� $
��Left=�6   $	��200��62   .+�5      �� $ Vertical=�6!   $��0q�68   .+�5      �� -   5        $��lblReferencia��5   �     	lblSombra#��[ 6    $��
REFERENCIA��6C   $��24��6X   $��Center=�6d   $��0q�6�   $��Center=�6�   $��	0,15,0,20q�6�    J� OpacityMask 6�   Z� �� 5      -   5        $��lblClienteDNI��5   k   #��[ 6    $��Nombre de Usuario��6C   $��30��6_   $��Center=�6�   $��0q�6�   $��0q�6�   �� 5      -	   5        $��lblApellido��5   b   #��[ 6    $��Apellido��6C   $��30��6V   $��Center=�6u   $��Center=�6�   $��0q�6�   $��0,3,0,7q�6�   �� 5      -
   5        $��	lblNombre��5   `   #��[ 6    $��Nombre��6C   $��30��6T   $��Center=�6q   $��Center=�6�   $��0q�6�   $��0q�6�   �� 5      -   5        $��lblTelefono��5   b   #��[ 6    $��	Teléfono��6C   $��30��6V   $��Center=�6u   $��Center=�6�   $��	0,10,0,15q�6�   5       5!      ]� 5"      $��Right=�6   $	��200��63   $��0,0,0,0q�6?   .+�5#      �� -   5        $��stpDatosUsuario��5#   !   $ Vertical=�68   $��0,0,0,0q�6O   .+�5$      �� -   5        $��lblDatosDelCliente��5$   _   #��[ 6    $��DATOS��6C   $��24��6S   $��0q�6y   $��	0,15,0,19q�6�   $��Center=�6�   $��Center=�6�   �� 5%      -   5        $��txtClienteDNI��5%   �     txtRedondeado#��[ 6"   $	��160��6e   $��24��6q   $��0,0,0,14q�6}   $��Center=�6�    �� 
IsReadOnly . $��Center=�6�   $��Center=�6�   $��Center=�6  ��6I   �� *
ClienteDNI+66  �� 5&      -   5        $��txtApellido��5&   �   #��[ 6"   $	��160��6c   $��24��6o   $��Center=�6{    . $��Center=�6�   $��Center=�6�   ��6I   �� *
Apellido+6  �� 5'      -   5        $��	txtNombre��5'   �   #��[ 6"   $	��160��6a   $��24��6m   $��Center=�6y    . $��Center=�6�   $��Center=�6�   $
��0,15q�6�   ��6I   �� *Nombre+6  �� 5(      -   5        $��txtTelefono��5(   �   #��[ 6"   $	��160��6c   $��24��6o   $��Center=�6{    . $��Center=�6�   $��Center=�6�   ��6I   �� *
Telefono+6  5)      5*      5+      �� 5,      $ 
Horizontal=�6   $
��0,15q�62   .+�5-      �� -   5        $��
btnPrimero��5-   Q     EstiloBoton#��[ 6   $��<<��6>   6~   �� 5.      -   5        $��btnAnterior��5.   M   #��[ 6   $��<��6>   6|   �� 5/      -   5        $��btnSiguiente��5/   M   #��[ 6   $��>��6>   6~   �� 50      -   5        $��	btnUltimo��50   Q   #��[ 6   $��>>��6>   6|   51      �� 52      $ Vertical=�6   62   53      54      55      