   M S B A M L   `   `   `  ����K  GProjetoCadastros, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ProjetoCadastros.InterfaceProjetoCadastros.Interface  5   	   .    (ProjetoCadastros.Interface.TelaPrincipal   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:ProjetoCadastros.Interface     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 	Bem vindo��5	   	   $	��450��6   $	��800��6(   .��5      � .+�5   
   �� $��2��6   .@�5      �� $��Clientes��6   .��5      �  � RowDefinitions 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      �� 5      .+�5      &   System.Windows.Controls.DataGrid  $��2��5         AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .    CanUserResizeColumns . 	   CanUserResizeRows	 .  
   CanUserSortColumns
 .    HorizontalGridLinesBrush
 ����    VerticalGridLinesBrush
 ����    AlternatingRowBackground
 �������5      ��  �� Path$ ListaPessoas� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��61      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5,   1   �� *
IdPessoa+  5-      $
 Nome��61    .  5/   1   �� *
NomePessoa+  50      $	 CPF��61    .  52   1   �� *Cpf+  53      $ 	Endereço��61    .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 500 56   1    55   1   �� *
Endereco+56   1   5:      �� 5<      $��2��6   $��2��5=      $��Cadatrar cliente��5>      $��50��5?      $	��100��5@      ��5A      �� *[CadastrarNovaPessoa]+5C      5D      5F      �� 5H      $��Produtos��6   .��5I         .   .   .   .  . 	 .  
 . 
 ���� 
 ���� 
 �������6   �� $ ListaProdutos�$ TwoWay=�$ PropertyChanged=� 5U        5V      $ Id��6-    .  5X   5   �� *	IdProduto+  5Y      $
 Nome��6-    .  5[   5   �� *NomeProduto+  5\      $ Código��6-    .  5^   5   �� *Codigo+  5_      $ Valor��6-    .  5a   5   �� *Valor+5e      5f      �� 5h      $��Pedidos��6   .��5i         .   .   .   .  . 	 .  
 . 
 ���� 
 ���� 
 �������6   �� $ ListaPedidos�$ TwoWay=�$ PropertyChanged=� 5u        5v      $ Id��6-    .  5x   5   �� *
IdPessoa+  5y      $
 Nome��6-    .  5{   5   �� *
NomePessoa+  5|      $	 CPF��6-    .  5~   5   �� *Cpf+  5      $ 	Endereço��6-    .  5�   5   �� *
Endereco+5�      5�      5�      5�      5�      