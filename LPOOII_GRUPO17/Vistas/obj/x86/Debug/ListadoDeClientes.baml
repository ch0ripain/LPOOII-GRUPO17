   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   
 Vistas   Vistas.ListadoDeClientes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   IcoleccionCliente,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   ScomponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase     5   	     � Title$  PETER PARKING��5   	   $	��350��6   $	��646��6,    � WindowStartupLocation$ CenterScreen=�68    � Icon$3 -/Vistas;component/Images/mascaraspiderman.jpg��6]    � AllowsTransparency .  $y�Visible=�6�    � WindowStyle$ SingleBorderWindow=�6�    � 
ResizeMode$ CanMinimize=�6�   ��5      �� 5   
    �� ImageSource$+ %/Vistas;component/Images/fondodoc.png��6    j� Stretch$ UniformToFill=�6I    j� TileMode$
 None=�6a   	 � 	Resources	 5
         
dsClientes
 S� 
ObjectType!   ClasesBase.TrabajarClientes S� 
MethodName  ClientesFiltrados �� Source �� SortDescriptions+  %System.ComponentModel.SortDescription   PropertyName   	Direction��%�   &	        &	 B     7   S� 5   
   "
  5      $ TraerClientes��5      5      �� 5   
   -   5        8    5        5      $	 DNI��61   $ 	Ascending=�6D   5      5      .��5      � .+�5   
   �� -   5        $��lblListaClientes��5   W   $��LISTADO DE CLIENTES��6   $��33��6.   $��Center=�6:   $	��Top=�6o   $��0,12,0,0q�6�   $
��Bold"�6�   $	��198��6�   
�������$��18(�6�   �� 5   
   -   5        $��txtDNI��5   Q   $	��150��6   $��23��6     txtRedondeado#��[ 6*   $��111,51,363,0q�6_   $	��Top=�6u   $��Center=�6�   $��Center=�6�   6�   �� 5   
   -   5        $��
lsvCliente��5       $��1��6   $��10,80,10,10q�6t   ��62   ��  �� Source# [  �� View 5      �� 5      .P�5      �� $	��DNI��6%    �� Width$	 105��62    �� DisplayMemberBinding 6>   �� *
ClienteDNI+�� 5       $��Apellido��6%   $	 175��67    6C   �� *
Apellido+�� 5!      $��Nombre��6%   $	 195��65    6A   �� *Nombre+�� 5"      $��	Teléfono��6%   $	 120��67    6C   �� *
Telefono+5#      5%      �� 5&   
   -   5        $��lblFiltroCliente��5&   �   $��Filtrar por DNI:��6     	lblSombra#��[ 6+   $��28��6N   $
��Left=�6Z   $��	12,47,0,0q�6u   $	��Top=�6�   
�������6�   �� 5'   
   -   5        $��btnVistaPrevia��5'   �   $��Vista previa��6     EstiloBoton#��[ 6(   $��24��6M   $��Right=�6Y   $��	0,49,10,0q�6u   $	��Top=�6�   $��97��6�   $��RightToLeft=�6�   5(      5)      