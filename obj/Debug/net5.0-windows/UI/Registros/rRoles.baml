   M S B A M L   `   `   `  ����T  PRegistroDetalleModificado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:RegistroDetalleModificado.UI.Registros&RegistroDetalleModificado.UI.Registros  5   	   3    -RegistroDetalleModificado.UI.Registros.rRoles   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:RegistroDetalleModificado.UI.Registros     5   	     � Title$  rRoles��5   	   $	��500��6   $	��800��6%   .��5	      � .+�5
   
   �� $��10q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Rol Id��6   $��16,10q�6)   �� 5      -   5         ��Name$ 	IdTextBox��5      $��30��6-   $��70��69   ��6D   �� *RolId+�� 5      -   5         ��Name$ Buscar��5      $��10q�6)   $��30��65   $��80��6A   .��5      �� $ 
Horizontal=�6!   .+�5      �� $��Buscar��6    �� 5      $,��&/Resources/search_locate_find_6278.png��6    5      5      �� 5      $��125, 7q�6   .+�5      �� -   5         ��Name$ ActivoCheckBox��5      $��Activo��67    d� 	IsChecked 6H   �� *
esActivo+5      5      �� 5      $ 
Horizontal=�6   .+�5       �� $��Descripcion��6   �� 5!      -   5        $ DescripcionTextBox��5!      $��30��66   $	��350��6B   ��6N   �� *Descripcion+5"      �� 5#      $ Vertical=�6   $��10q�60   .+�5$      �� $��Detalles de Roles��6   .��5%      �� $��10q�6!   .+�5&      �� $ 
Horizontal=�6%   .+�5'      �� $��	Permisos:��6$   �� 5(      -   5         ��Name$ PermisosComboBox��5(   '   $��30��6A   $	��500��6M   $��0,0,0,10q�6Z   5)      �� 5*      $ 
Horizontal=�6%   .+�5+      �� -   5        $ AgregarFilaButton��5+   %   $
��0,10q�6@   $��90��6n   .��5,   "   �� $ 
Horizontal=�6-   .+�5-   &   �� $��Agregar��6,   �� 5/   &   $-��'/Resources/add_icon-icons.com_74429.png��6,   52   #   53      �� 54      -   5        $ RemoverFilaButton��54   %   $��20,10q�6@   $��90��6o   .��55   "   �� $ 
Horizontal=�6-   .+�56   &   �� $��Eliminar��6,   �� 58   &   $,��&/Resources/delete_delete_exit_1577.png��6,   5;   #   5<      5=      &   System.Windows.Controls.DataGrid  5?      -   5          Name$ DetalleDataGrid��5?   #   $��80��6a      AutoGenerateColumns$ False��6m   ��6<   �� *RolesDetalle+	   Columns	 5@      0  *System.Windows.Controls.DataGridTextColumn  5A   "   ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Permiso Id��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *	PermisoId+  5C   "   $
 Nombre de Permiso��65    6P   �� *NombrePermiso+  5E   "   $
 Es Asignado��65    6J   �� *
esAsignado+5G      �� 5H      $ 
Horizontal=�6%   $
��Left=�6>   .+�5I      �� $"��Cantidad permisos agregados:��6$   $
��0,20q�6K   �� 5J      -	   5         ��Name$ TotalTextBlock��5J   (   $
��5,26q�6@   5K      5M      5N      5O      �� 5Q      $ 
Horizontal=�6   $
��0,15q�62   $
��Left=�6@   .+�5R      �� -
   5        $ NuevoButton��5R      $	��5,0q�6.   .��5S      �� $ 
Horizontal=�6!   .+�5U      �� $-��'/Resources/new_icon-icons.com_51017.png��6    �� 5X      $��Nuevo��6    5Y      5Z      �� 5[      -   5        $ GuardarButton��5[      $	��5,0q�62   .��5\      �� $ 
Horizontal=�6!   .+�5^      �� $#��/Resources/Save_37110 (1).png��6    �� 5a      $��Guardar��6    5b      5c      �� 5d      -   5        $ EliminarButton��5d      $	��5,0q�62   .��5e      �� $ 
Horizontal=�6!   .+�5g      �� $,��&/Resources/delete_delete_exit_1577.png��6    �� 5j      $��Eliminar��6    5k      5l      5m      5n      5o      5p      