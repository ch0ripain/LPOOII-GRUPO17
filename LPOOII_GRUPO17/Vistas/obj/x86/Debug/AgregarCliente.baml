   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   
 Vistas   Vistas.AgregarCliente   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <svc,clr-namespace:ClasesBase;assembly=ClasesBase     5   	     � Title$  PETER PARKING��5   	   $	��470��6   $	��320��6,    � WindowStartupLocation$ CenterScreen=�68    � Icon$+ %/Vistas;component/Images/fondodoc.png��6]    � 
ResizeMode$ CanMinimize=�6�   ��5      �� 5   
    �� ImageSource$+ %/Vistas;component/Images/fondodoc.png��6    j� Stretch$ UniformToFill=�6I    j� TileMode$
 None=�6a    � 	Resources 5	         DATA_CLIENTE S� 
ObjectType!   ClasesBase.TrabajarClientes	 S� 
MethodName��%H   &	        S� 5
   
   "  62   $	 TraerClienteNuevo��6]   5      5      .��5      � ��6   Z� .+�5   
   �� -   5        $��lblClienteDNI��5   r     	lblSombra#��[ 6   $	��DNI��63   $��Center=�6A   $��
49,72,49,0q�6^   $	��Top=�6�   $	��200��6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $��lblClienteNombre��5   v   #��[ 6   $��Nombre��63   $��Center=�6D   $��49,129,49,0q�6a   $	��Top=�6�   $	��200��6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $��lblClienteApellido��5   x   #��[ 6   $��Apellido��63   $��Center=�6F   $��49,188,49,0q�6c   $	��Top=�6�   $	��200��6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $��lblClienteTelefono��5   x   #��[ 6   $��	Teléfono��63   $��Center=�6F   $��49,248,49,0q�6c   $	��Top=�6�   $	��200��6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $��txtClienteDNI��5   �     EstiloError#��[ 6   
 � DataContext#
 [  67   $��Center=�6c   $��0,97,0,0q�6�   $	��Top=�6�   $	��200��6�   $��Center=�6�   .��6!  ��5      �� 5       �� Path$ 
ClienteDNI�6    �� UpdateSourceTrigger$ PropertyChanged=�6,    �� ValidatesOnExceptions .  �� ValidatesOnDataErrors . 5   .   .��5      5      �� 5   
   -   5        $��txtClienteNombre��5   �   #��[ 6   #
 [  67   $��Center=�6c   $��49,155,49,0q�6�   $	��Top=�6�   $	��200��6�   $��Center=�6�   .��6�   ��5      �� 5      $ Nombre�6   $ PropertyChanged=�6(    .  . 5   .   .��5      5      �� 5   
   -   5        $��txtClienteApellido��5   �   #��[ 6   #
 [  67   $��Center=�6c   $��49,214,49,0q�6�   $	��Top=�6�   $	��200��6�   $��Center=�6�   .��6�   ��5      �� 5       $ Apellido�6   $ PropertyChanged=�6*    .  . 5!   .   .��5"      5#      �� 5$   
   -   5        $��txtClienteTelefono��5$   �   #��[ 6   #
 [  67   $��Center=�6c   $��49,273,49,0q�6�   $	��Top=�6�   $	��200��6�   $��Center=�6�   .��6.  ��5%      �� 5&      $ Telefono�6   $ PropertyChanged=�6*    .  . 5'   .   .��5(      5)      �� 5*   
   -	   5        $��lblClienteTitulo��5*   v   #��[ 6   $��AGREGAR CLIENTE��63   $��31��6M   $��Center=�6Y   $	��Top=�6�   $��0,25,0,0q�6�   $	��168��6�   $��Center=�6�   $��Center=�6�   $��18(�6
  �� 5+   
   -
   5        $��btnCargarCliente��5+   e     EstiloBoton#��[ 6   $��Agregar��66   $��Center=�6H   $��Bottom=�6}   $	��200��6�   $��
49,0,49,65q�6�   5,      5-      5.      