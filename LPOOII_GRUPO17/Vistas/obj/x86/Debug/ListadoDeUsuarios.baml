   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   
 Vistas   Vistas.ListadoDeUsuarios   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   IcoleccionUsuario,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   ScomponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase     5   	     � Title$  PETER PARKING��5   	   $	��350��6   $	��646��6,    � WindowStartupLocation$ CenterScreen=�68    � Icon$3 -/Vistas;component/Images/mascaraspiderman.jpg��6]    � AllowsTransparency .  $y�Visible=�6�    � WindowStyle$ SingleBorderWindow=�6�    � 
ResizeMode$ CanMinimize=�6�    � 	Resources 5         
dsUsuarios S� 
ObjectType!   ClasesBase.TrabajarUsuarios S� 
MethodName  UsuariosFiltrados	 �� Source
 �� SortDescriptions+  %System.ComponentModel.SortDescription   PropertyName   	Direction��%�   &	        &	 B     7   S� 5   
   "  5
      $ TraerUsuarios��5      5      �� 5   
   -   5        8	   
 5        5      $ UserName��61   $ 	Ascending=�6I   5      5      .��5   
   � .+�5      �� -   5        $��lblListaUsuarios��5   [   $��LISTADO DE USUARIOS��6   $��35��62   $��Center=�6>   $	��Top=�6s   $��0,12,0,0q�6�   $
��Bold"�6�   $	��209��6�   
�������$��18(�6�   �� 5      -   5        $��txtUserNameFiltro��5   U   $	��149��6   $��23��6"     txtRedondeado#��[ 6.   $��204,53,271,0q�6n   $	��Top=�6�   $��Center=�6�   $��Center=�6�   6	  �� 5      -   5        $��
lsvUsuario��5   $   $��1��6   $��10,80,10,10q�6x   ��66   ��  �� Source# [  �� View 5      �� 5      .P�5      �� $��Usuario��6)    �� Width$	 120��6:    �� DisplayMemberBinding 6F   �� *
UserName+�� 5      $��Contraseña��6)   $	 120��6=    6I   �� *
Password+�� 5      $��Apellido��6)   $	 125��6;    6G   �� *
Apellido+�� 5      $��Nombre��6)   $	 132��69    6E   �� *Nombre+�� 5       $	��Rol��6)   $	 100��66    6B   �� *Rol+5!      5#      �� 5$      -   5        $��lblFiltroUserName��5$   �   $$��Filtrar por nombre de usuario:��6     	lblSombra#��[ 6=   $��28��6`   $
��Left=�6l   $��	12,49,0,0q�6�   $	��Top=�6�   
�������6�   �� 5%      -   5        $��btnVistaPrevia��5%   �   $��Vista previa��6     EstiloBoton#��[ 6,   $��24��6Q   $��Right=�6]   $��	0,49,10,0q�6y   $	��Top=�6�   $��97��6�   $��RightToLeft=�6�   5&      ��5'      �� 5(   
    �� ImageSource$+ %/Vistas;component/Images/fondodoc.png��6    j� Stretch$ UniformToFill=�6I    j� TileMode$
 None=�6a   5*      