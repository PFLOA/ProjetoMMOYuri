   M S B A M L   `   `   `  ����M  IProjetoAulaYuriWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:ProjetoAulaYuriWpf.Views.MochilaViews%ProjetoAulaYuriWpf.Views.MochilaViews  5   	   i9clr-namespace:ProjetoAulaYuriWpf.Models.Personagem.Perfil+ProjetoAulaYuriWpf.Models.Personagem.Perfil  5   	   3    -ProjetoAulaYuriWpf.Views.MochilaViews.Mochila   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:ProjetoAulaYuriWpf.Views.MochilaViews     5   	   Kmodel9clr-namespace:ProjetoAulaYuriWpf.Models.Personagem.Perfil     5   	   -   5          � Title$  Mochila��5	   	   $	��700��6   $	��900��6&    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�62   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��153* �6   �� 5      $
��247* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dgvItensMochila��5      $��1��6*   $��0��5         AutoGenerateColumns .  $
��10,0q�6<      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6)   	   MinWidth$		 100Q�65   
   MaxWidth$	
 100Q�6D      CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $��btnItem��6)   -   5        $��80��5   8   $��80��6C   .��5   &   �� ��6,   �� *
ImageUrl+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5    #   5!      5"      5$      5&      �� 5(   
   $ 
Horizontal=�6   $��1��6.   $��1��6;   .+�5)      �� $��Item Consumível HP��6   �� 5*      $��80��5+      $��80��6   ��5*      �� *Gear.ConsumivelHP.ImageUrl+5+      5,      5-      5.      