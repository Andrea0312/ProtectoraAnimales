   M S B A M L   `   `   `  ����B  >Eventos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:EventosEventos  5   	       Eventos.AnimalsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Eventos     5   	     � Title$  AnimalsWindow��5   	   $	��450��6   $	��800��6,   .��5	      �  � RowDefinitions 5   
   �� 5      $	��19* �6   �� 5      $	��72* �6   �� 5      $	��73* �6   �� 5      $
��306* �6    � ColumnDefinitions 5   
   �� 5      $
��151* �6   �� 5      $
��642* �6   .+�5   
   �� -   5         ��Name$ fondo��5      ���	#FFF4F2CB$��0,0,-0.4,0.4q�64    �� RadiusY$ 1��6J    �� RadiusX$ 1��6V   
���   �$��3��6q   $��2��6�   $��4��6�   �� 5   
   -   5         ��Name$ imgLogo��5      $��39,19,47.2,0.2q�6!    J� RenderTransformOrigin$ -0.182,-0.102&�69   $��2��6_   $��	logo2.png��6p   �� 5   
   -   5         ��Name$ 
txtUsuario��5      $��1��6&   $��330.8,10.8,28.6,37.2q�66   $��1��6T   	 �� TextWrapping$
	 Wrap=�6a   $��TextBox��6u   ���	#FFF4F2CB���	#FFF4F2CB$��14(�6�   {�.  6�   �� 5   
   -   5        
 ��Name$
 lblFrasePrincipal��5      $��HOLA Bienvenidos!!��6+   $��1��6H   $��155.8,12.8,173.6,14q�6X   $��2��6u   $
��Bold"�6�   $��Ink Free)�6�   $��30(�6�   o� 5   
   -   5         o�Name$ 
mPrincipal��5      $��10,56,0,40.4q�6#   $��3��69    � Cursor$
 Hand��6F   $��1��6T   $��16(�6a   $
��Left=�6�   $	��131��6�   ��6o   Z� .@�5      �� -   5         ��Name$ mnPrincipal��5      $��Menu principal��6/   6H   �� 5      -   5        $ 
mnAnimales��5      $��Animales��6.   5      5      5"      