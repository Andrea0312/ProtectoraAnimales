   M S B A M L   `   `   `  ����B  >Eventos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:EventosEventos  5          Eventos.Animales   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Eventos     5        N� Title$  Animales��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��135* �6   �� 5      $
��145* �6   �� 5      $
��341* �6   .+�5   
   � $��1��6   $��2��6    5      �� 5      $��6* �6    �� 5       5      �� 5      $	��28* �6#   �� 5      $	��27* �6#   �� 5      �� 5      $
��auto �6#   .+�5!      �� -   5         ��Name$ lstListaAnimales��5!      $��0��60    �� SelectedIndex$ 0��6@   $��
10,10,5,10q�6R   ���	#FFCBDAEC$��2��6�   ��6f   �� ��5"      �� 5#      .R�5$      ��  �� Orientation$ 
Horizontal=�6%   .+�5%      �� $��32��6$   $��37��6/   ��6;   �� *
Caratula+�� 5&      $��Center=�6(   $��10,0,0,0q�6C   ��6U   �� *Nombre+5'      5(      5+      �� 5,      -   5         ��Name$ 
btnAñadir��5,      $
��25,5q�6)   $��1��67   ��5-      �� 5.       �� ImageSource$ imagenes/anadirPerro.png��6!   	 j� Stretch$	 Uniform=�6H   50      �� 51      -   5        $ btnEliminar��51      $
��20,5q�6+   $��1��69   $��1��6F   ��52      �� 53      $  imagenes/eliminarPerro.png��6!   $	 Uniform=�6J   55      56      �� 57   
   -   5        
 ��Name$
 spDetallesAnimales��57      $ Vertical=�61   $��	5,0,10,10q�6H   $��2��6[   $��1��6k   .+�58      � $	��305��6    59      �� 5:      $��6* �6$   �� 5;      $	��23* �6$   �� 5<      $��6* �6$   �� 5=      $��6* �6$   �� 5>      $��6* �6$   �� 5?      $��9* �6$   �� 5@      $��5* �6$    5B      �� 5C      $	��70* �6'   �� 5D      $	��85* �6'   �� 5E      $	��70* �6'   �� 5F      $
��101* �6'   .+�5H      �� -   5         ��Name$ 	lblNombre��5H      $
��Bold"�6+   $��11(�6=   $	��5,0q�6�   $��2��6�   ��6K   �� *SelectedItem.Nombre+ �� ElementName$ lstListaAnimales��6�   �� 5I      -   5         ��Name$ imgCaratula��5I      $��	5,10,5,10q�6-   $��1��6�    J� RenderTransformOrigin$ -0.052,0.479&�6�   $��3��6�   ��6@   �� *SelectedItem.Caratula+$ lstListaAnimales��6�   �� 5J      $
��Bold"�6   $��Sexo:��6*   $��8(�6:   $��2��6G   $ 	0.643,0.5&�6T   ���	#FFCBDAEC$��2,2,2,2q�6�   $��Segoe UI Black)�6�   �� 5K      -   5        $ lblSexo��5K      $��1��6q   $	��5,0q�6�   $��2��6�   $ 	0.331,0.5&�6�   $��8(�6�   $
��Bold"�6�   ��6)   �� $ lstListaAnimales�� �� Path$ SelectedItem.Sexo�6�   �� 5L      $
��Bold"�6   $��8(�6*   $��3��67   ���	#FFCBDAEC$��2,2,2,2q�6\   $��Segoe UI Black)�6m   .��6�   Raza:6�   �� 5M      -   5        $ lblRaza��5M      $��1��6q   $��3��6�   $��8(�6�   $
��Bold"�6�   ��6)   �� $ lstListaAnimales��$ SelectedItem.Raza�6�   �� 5N      $
��Bold"�6   $��8(�6*   $��4��67   $��2��6D   ���	#FFCBDAEC$��2,2,2,2q�6k   $��Segoe UI Black)�6|   .��6�   
Tamaño:6�   �� 5O      -	   5        $ 
lblTamaño��5O      $��3��6u   $��4��6�   $��8(�6�   $
��Bold"�6�   ��6+   �� $ lstListaAnimales��$ SelectedItem.Tamano�6�   �� 5P      $
��Bold"�6   $��8(�6*   $��2��67   $��2��6D   ���	#FFCBDAEC$��2,2,2,2q�6l   $��Segoe UI Black)�6}   .��6�   Peso:6�   �� 5Q      -
   5        $ lblPeso��5Q      $��3��6q   $��0,0,6,0q�6�   $��2��6�   $��8(�6�   $
��Bold"�6�   ��6)   �� $ lstListaAnimales��$ SelectedItem.Peso�6�   �� 5R      $
��Bold"�6   $��8(�6*   $��2��67   $��3��6G   ���	#FFCBDAEC$��2,2,2,2q�6l   $��Segoe UI Black)�6}   .��6�   Edad:6�   �� 5S      -   5        $ lblEdad��5S      $��3��6q   $��3��6�   $��8(�6�   $
��Bold"�6�   ��6)   �� $ lstListaAnimales��$ SelectedItem.Edad�6�   �� 5T      -   5        $ 
btn_editar��5T      $��Editar��6-   $��3��6>   $��5,5,5,5q�6N   $��5��6_   $��Segoe UI Black)�6l   ���	#FF6FADF76�   �� 5U      -   5        $ label��5U      $��Apadrinado:��6'   $��4��6=   $��8(�6J   $
��Bold"�6W   ���	#FFCBDAEC$��2,2,2,2q�6�   $��Segoe UI Black)�6�   �� 5V      -   5        $ lblApadrinado��5V      $��1��6}   $��4��6�   $��8(�6�   $
��Bold"�6�   {�.  ��6/   �� $ lstListaAnimales��$ SelectedItem.Apadrinado�6�   �� 5W      -   5        $ btn_padrino��5W      $��Padrino��6.   $��5,5,5,5q�6@   $��5��6Q   $��Segoe UI Black)�6^   ���	#FF6FADF7$��1��6�   5Y      5Z      5[      5\      