   M S B A M L   `   `   `  ����E  AProyectoP3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProyectoP3.vistasProyectoP3.vistas  5           ProyectoP3.vistas.Usuarios   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:ProyectoP3.vistas     5      
������   � 	Resources  5	         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value  FocusVisual �� StrokeDashArray  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border 	 Button.Pressed.Background 
 Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  BtnBuscarStyle ��Name �� 
ResourceId �� TypeInTargetAssembly&   System.Windows.Controls.DataGrid ��Name �Name J� Opacity � Points �� Stretch  DataGridStyle �� Padding � ColumnDefinitions � RowDefinitions   SelectAllCommand!   HeadersVisibilityConverter  �� 	Converter7  1System.Windows.Controls.DataGridHeadersVisibility
!   All" �� ConverterParameter# �� RelativeSource$ �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter%  Name&   Column' ��Name( �� CanContentScroll) ��Name* �� ScrollableHeight+ � Maximum, �� Orientation- �� ViewportHeight. �� ViewportSize*/ �� #ComputedVerticalScrollBarVisibility0 � Value1 �� Mode2 �� ScrollableWidth3 �� ViewportWidth,4 �� %ComputedHorizontalScrollBarVisibility=  7System.Windows.Controls.Primitives.DataGridColumnHeader*  $System.Windows.Controls.DataGridCell��%�  &	        &	 #     &	 F     &	 i     7   7  7  &	 �    &	 c    &	 �    &	 �    &	 �    &		 �    &	
     &	 5    &	 X    &	 {    &	 �    7  7  7  7  7  7  (�� �    5p      $" DataGridSelectAllButtonStyle��"  )&	 �    '  -    '      �� 5   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " ��6%   .�5      ��  � ��# � ��6+   �� 5       � ��8   6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5       �@ TabNavigation$
 None=�6A   �� 5       � ��$
 Left=�6;   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@J�	AllowDrop$
 true��6*   �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5       �@��IsFlicksEnabled$ False��67   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��63   $ 10��6!   #��z��6C   #��z��6m   #��z��6�   $
 True��6�   ._�5      �� $	 PART_ContentHost��6+   $|�false��6E   $��Hidden=�6W   $��Hidden=�6~   5      
 5      P� 5        � {�$ false��6;   . �5!   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5"      P� 5#       �@J�IsMouseOver$
 true��6=   . �5$   "   �� $ border��6@   8   � ��6T   5%      P� 5&       �@J�IsKeyboardFocused$
 true��6C   . �5'   "   �� $ border��6@   8   � ��6T   5(      5*      5,       5-      ]� 5.       5/      �� 50      + �@��#IsInactiveSelectionHighlightEnabled$
 true��6S   �� 51       �@��IsSelectionActive$ false��6A   ./�53      ��  �@��SelectionBrush# � /�67   54      56      �� 57   
   .�58      ��  � �� 59      �� 5:      .R�5;      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5<      5>      5?      �� 5B   
   $ 	#FFDDDDDD��6;   �� 5C   
   $ 	#FF707070��67   �� 5D   
   $ 	#FFBEE6FD��6>   �� 5E   
   $ 	#FF3C7FB1��6:   �� 5F   
   $ 	#FFC4E5F6��6<   �� 5G   
   $ 	#FF2C628B��68   �� 5H   
   $ 	#FFF4F4F4��6=   �� 5I   
   $ 	#FFADB2B5��69   �� 5J   
   $ 	#FF838383��6=   �� 5K   
   " ��6'   .�5L      ��  �@�FocusVisualStyle8   61   �� 5M       � ��8  6+   �� 5N       � ��8  6,   �� 5O       � ��# � ��6+   �� 5P       � ��$ 1q�60   �� 5Q       � ��$ Center=�6;   �� 5R       � ��$ Center=�69   �� 5S       � ��$ 1q�6(   �� 5T       � �� 5U      �� 5V      " ��6&   .R�5W      �� $ border��63   $ 10��6!   #��z��6C   #��z��6m   #��z��6�   $
 true��6�   ._�5X      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5Y      
 5Z      P� 5[       �@��IsDefaulted$
 true��6=   . �5\   "   �� $ border��6@   # � ��6T    � ��5]      P� 5^       �@J�IsMouseOver$
 true��6=   . �5_   "   �� $ border��6?    � �� �#f48fb16S   �� 5`   "   $ border��6@    � �� �#f48fb16T   5a      P� 5b       � ��$
 true��6;   . �5c   "   �� $ border��6?    � ��
 �����6S   �� 5d   "   $ border��6@    � ��
 �����6T   5e      P� 5f       � {�$ false��6;   . �5g   "   �� $ border��6?   8   � ��6S   �� 5h   "   $ border��6@   8   � ��6T   �� 5i   "   $ contentPresenter��6K   8   � ��6i   5j      5l      5n      5o      �� 5p   
   " ��6   .�5q      ��  � �� 5r      �� 5s      " ��6&   .R�5t      � .+�5u      �� $ Border��6(   #��� ��68   $
 True��6y   � 5v      $ Arrow��6&   
���   �$��Right=�6B   $��8,8,3,3q�6^   $
 0.15Q�6o    �   ��� ��� ��� ��� $ Uniform=�6�   $��Bottom=�6�   5w      
 5x      P� 5y       �@J�IsMouseOver$
 True��6=   . �5z   "   �� $ Border��6;   # � ��6O    � ��5{      P� 5|       � ��$
 True��6;   . �5}   "   �� $ Border��69   # � ��6M    � ��5~      P� 5       � {�$ False��6;   . �5�   "   �� $ Arrow��6?    � y�$ 	Collapsed=�6R   5�      5�      5�      5�      �� 5�   
   "  6&   .�5�      ��  � ��# � ��6+   �� 5�       � ��# � ��6+   �� 5�       � ��
 �����6,   �� 5�       � ��$ 1q�60   �� 5�        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�69   �� 5�       � ��$
 true��6>   �� 5�       �@��PanningMode$
 Both=�69   �� 5�       �@��IsFlicksEnabled$ False��67   �� 5�       � �� 5�      �� 5�      "  6&   .R�5�      �� $ 	0,0,10,10��6!   #��z��6:   #��z��6d   #��z��6�   # z��6�   $
 True��6�   ._�5�      �� $	 DG_ScrollViewer��6+   $|�false��6D   ��5�   "   �� 5�   &   " ��66   .R�5�   *   �  5�   .   �� 5�   2   $
��Auto �6C   �� 5�   2   $��* �6C   �� 5�   2   $
��Auto �6C    5�   .   �� 5�   2   $
��Auto �6@   �� 5�   2   $��* �6@   �� 5�   2   $
��Auto �6@   .+�5�   .   �� #��Z 65   $|�false��6d   ��6v   C� *�� $" DataGridSelectAllButtonStyle��"  +y�6�   �� *HeadersVisibility+#  Z #" Z! # �� "$  ��6�  �� *CellsPanelHorizontalOffset+# �� "$    5�   .   $!% PART_ColumnHeadersPresenter��6M   $��1��6r   y�6�   �� *HeadersVisibility+#  Z #" Z& # �� "$  �� 5�   .   $!' PART_ScrollContentPresenter��6E   $��2��6j   #( z��6~   $��1��6�   �� 5�   .   $) PART_VerticalScrollBar��68   $��2��6X   #+ z* 6h   $, Vertical=�6�   $��1��6�   #. z- 6�   #y�z/ 6H  0 6�   �� *VerticalOffset+$1 OneWay=�# �� *TemplatedParent+6H  � 5�   .   $��1��63   $��2��6C    5�   2   �� 5�   6   ��6G   �� **(NonFrozenColumnsViewportHorizontalOffset+# �� "$  �� 5�   6   $��* �6G   .+�5�   2   �� $) PART_HorizontalScrollBar��6<   $��1��6^   #+ z2 6n   $, 
Horizontal=�6�   #. z3 6�   #y�z4 6C  0 6�   �� *HorizontalOffset+$1 OneWay=�# �� *TemplatedParent+6C  5�   /   5�   +   5�   '   .��5�   "   �� # z 61   5�      5�      5�      5�       5�      ]� 5�       5�      �� 5�       �@��
IsGrouping$
 true��6:   �� 5�      " �@%�IsVirtualizingWhenGrouping$ false��6\   ./�5�      ��  � ��$ false��6F   5�      5�      �� 5�   
   "  6   .�5�      ��  � ��
 �����6+   �� 5�       � ��$ SemiBold"�6+   �� 5�       � ��
 �����6+   �� 5�       � ��$ 20��6'   �� 5�       � ��$ Center=�64   5�      �� 5�   
   "  6    5�      P� 5�       �@ 
IsSelected$
 True��60   . �5�      ��  � �� �#bbdefb63   �� 5�       � ��
 ���� 64   5�      P� 5�       �@J�IsMouseOver$
 True��61   . �5�      ��  � �� �#bbdefb63   �� 5�       � ��
 ���� 64   �� 5�       � ��
 �����63   5�      5�      5�      .��5�      �� $ 10��6   ���#ffedff._�5�   
   � -   5        5 �Name$5 GridUsuarios��5�       5�      �� 5�      $��20 �6#   �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      $��20 �6#    5�      �� 5�      $��50 �6    �� 5�      $��20 �6    �� 5�      $��30 �6    �� 5�      $��20 �6    �� 5�      �� 5�      �� 5�      �� 5�      $��20 �6    .+�5�      �� $��0��6   $��6��5�      $��Mantenimiento de Usuarios��5�      
���   �$��30(�5�      $��Center=�5�      $��Center=�5�      �� 5�      $��	Usuarios:��6   $��Center=�5�      $��Center=�5�      $��1��5�      $��2��5�      $��15(�5      $��0,0,10,0q�5     �� 5     -   5        6 ��Name$6 BtnCrearUsuario��5     ���#bbdefb���#bbdefb$��4��5     $��2��5	     7 � Cursor$
7 Hand��5
     $	��150��5     #���  5     .��5     �� $��Agregar Usuario��6   
�������$��15(�5     5       5     -   5        8  Name$8 	GridDatos��5     $��4��5     $��1��5     $��2��5     $��4��5     9   AutoGenerateColumns$9 False��5     
����������#c48b9f$��15(�5     :   CanUserAddRows$: False��5     ;   CanUserResizeColumns$
; True��5     <   CanUserResizeRows$< False��5      =   CanUserSortColumns$= False��5!     >   RowBackground
> ���� ?   HeadersVisibility$? Column=�5#     @   GridLinesVisibility$@ 
Horizontal=�5$     A   HorizontalGridLinesBrushA �#c48b9f#���  5%  :   B   ColumnsB 5&     4  .System.Windows.Controls.DataGridTemplateColumn  5'     ,  &System.Windows.Controls.DataGridColumnC   Header$ C Opciones del administrador��6-   D   Width5	  /System.Windows.Controls.DataGridLengthConverter$	D 245	 5(  -   E   CellTemplateE 5)     �� 5*     .R�5+  "   ]� .+�5,  &   �� $6 BtnConsultar��5-  -   -   5        $��	Consultar��5,  -   
�������$��80��5/  -   
������ 
�������#���  52  -   ��54  -   �� *Id+6M   �� 56  &   $6 BtnModificar��57  -   -   5        $��	Modificar��56  -   
�������$��80��59  -   
������ 
�������#���  5<  -   ��5=  .   �� *Id+6N   �� 5@  &   $6 BtnEliminar��5A  -   -   5        $��Eliminar��5@  -   
�������$��80��5C  -   
������ 
�������#���  5F  -   ��5G  -   �� *Id+6M   5I  #   5J     5L     0
  *System.Windows.Controls.DataGridTextColumn
  5M     $C Id��6)   $D 50	 5N  )   1  +System.Windows.Controls.DataGridBoundColumnF   BindingF 5O  )   �� *Id+
  5P     $C Username��6)   $	D 100	 5Q  )   F 5R  )   �� *
Username+
  5S     $C Nombre_Completo��6)   $	D 150	 5T  )   F 5U  )   �� *Nombre_Completo+5W      � 5Z     -   5        G  �Name$G FrameUsuarios��5Z     $��0��5[     $��0��5\     $��8��5]     $��6��5^     5`     5a     5d     