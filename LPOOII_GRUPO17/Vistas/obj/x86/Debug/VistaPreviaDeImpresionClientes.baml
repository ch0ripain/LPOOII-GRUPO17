   M S B A M L   `   `   `  ����
  Vistas+    %Vistas.VistaPreviaDeImpresionClientes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$6  0Vista previa de impresión - Listado de clientes��5   	   $	��485��6A   $	��725��6N    � WindowStartupLocation$ CenterScreen=�6Z    � Icon$3 -/Vistas;component/Images/mascaraspiderman.jpg��6    � 
ResizeMode$ CanMinimize=�6�   .��5      �� $	��694��6   $	��425��6   .+�5   
   -�  �� Left$ 12��6   
 �� Top$ 28��6.   $	��395��6>   .��5      /� -   5         �Name$ DocMain��5      .T�5      J� $
��Bold"�6    �� Margin$ 0q�6.    �� TextAlignment$ Center=�69   .*�6P   LISTADO DE CLIENTES6e   �� 5	      .r�5
      �� -   5        $��
lsvCliente��5
   ,   $��1��6   $��10,20,10,10q�6V   ��6>   �� 	 �� View	 5      �� 5      .P�5   "   �� $	��DNI��61   
 �� Width$	
 125��6>    �� DisplayMemberBinding 6J   �� *
ClienteDNI+�� 5   "   $��Apellido��61   $	
 170��6C    6O   �� *
Apellido+�� 5   "   $��Nombre��61   $	
 200��6A    6M   �� *Nombre+�� 5   "   $��	Teléfono��61   $	
 135��6C    6O   �� *
Telefono+5      5      5      5      5      �� 5   
   -   5        $��btnImprimir��5   0   $��Imprimir��6   $��30��6$   $��0q�6C   6N   5      5      