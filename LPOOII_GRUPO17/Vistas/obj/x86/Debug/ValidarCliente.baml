   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   
 Vistas   Vistas.ValidarCliente   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <svc,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	   -   5          � Title$  PETER PARKING��5   	   $	��439��6   $	��318��6,   $��LeftToRight=�68    � WindowStartupLocation$ CenterScreen=�6T    � Icon$3 -/Vistas;component/Images/mascaraspiderman.jpg��6y    � 
ResizeMode$ CanMinimize=�6�   ��5      �� 5   
    �� ImageSource$+ %/Vistas;component/Images/fondodoc.png��6    j� Stretch$ UniformToFill=�6I    j� TileMode$
 None=�6a    � 	Resources 5
         DATA_CLIENTE S� 
ObjectType!   ClasesBase.TrabajarClientes	 S� 
MethodName
 S� MethodParameters��%y   &	        S� 5   
   "  62   $	 TraerCliente��6]   
 5      ��5      Ingrese un DNI...��63   5      5      .��5      � ��6   Z� .+�5   
   �� -   5        $��lblClienteDNI��5   r   $	��DNI��6     	lblSombra#��[ 6   $��Center=�6A   $��
48,66,48,0q�6^   $	��Top=�6�   $��Center=�6�   $��Center=�6�   $	��200��6�   �� 5   
   -   5        $��lblClienteNombre��5   v   $��Nombre��6   #��[ 6!   $��Center=�6D   $��48,120,48,0q�6a   $	��Top=�6�   $	��200��6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $��lblClienteApellido��5   x   $��Apellido��6   #��[ 6#   $��Center=�6F   $��48,171,48,0q�6c   $	��Top=�6�   $	��200��6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $��lblClienteTelefono��5   x   $��	Teléfono��6   #��[ 6#   $��Center=�6F   $��48,225,48,0q�6c   $	��Top=�6�   $	��200��6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $��txtClienteDNI��5   C   $��Center=�6   $��
48,91,48,0q�6/     EstiloError#��[ 6X    � DataContext# [  6}   $	��Top=�6�   $	��200��6�   $��25��6'  $��Center=�63  .��6W  ��5      �� 5       �� Source# [  6    �� Path$ MethodParameters[0]�5       �� BindsDirectlyToSource .  �� UpdateSourceTrigger$ PropertyChanged=�5       �� ValidatesOnExceptions .  �� ValidatesOnDataErrors . 5      .��5      5      �� 5    
   -   5        $��txtClienteNombre��5    D   $��Center=�6   $��48,143,48,0q�6/   #��[ 6\   # [  6�   $	��Top=�6�   $	��200��6�   $��25��6�   $��Center=�6�   .��6  ��5!      �� 5"      $ Nombre�6   $ PropertyChanged=�6(    .  . 5#   .   .��5$      5%      �� 5&   
   -   5        $��txtClienteApellido��5&   D   $��Center=�6   $��48,196,48,0q�6/   #��[ 6^   # [  6�   $	��Top=�6�   $	��200��6�   $��25��6�   $��Center=�6�   .��6  ��5'      �� 5(      $ Apellido�6   $ PropertyChanged=�6*    .  . 5)   .   .��5*      5+      �� 5,   
   -	   5        $��txtClienteTelefono��5,   D   $��Center=�6   $��48,248,48,0q�6/   #��[ 6^   # [  6�   $	��Top=�6�   $	��200��6�   $��25��6
  $��Center=�6  .��6:  ��5-      �� 5.      $ Telefono�6   $ PropertyChanged=�6*    .  . 5/   .   .��50      51      �� 52   
   -
   5        $��lblClienteTitulo��52   x   $��MODIFICAR CLIENTE��6   #��[ 6,   $��36��6O   $��Center=�6[   $	��Top=�6�   $	��181��6�   $��
58,16,58,0q�6�   $��Center=�6�   $��Center=�6�   $��18(�6  �� 53   
   -   5        $��btnModificarCliente��53   V   $��	Modificar��6   $��Center=�6%   $��
48,0,48,58q�6B     EstiloBoton#��[ 6q   $��Bottom=�6�   $	��200��6�   6�   54      55      