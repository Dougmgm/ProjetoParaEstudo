   M S B A M L   `   `   `  ����K  GProjetoCadastros, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ProjetoCadastros.InterfaceProjetoCadastros.Interface  5   	   .    (ProjetoCadastros.Interface.TelaPrincipal   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:ProjetoCadastros.Interface     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 	Bem vindo��5	   	   $	��450��6   $	��800��6(   .��5      � .+�5   
   �� $��2��6   .@�5      �� $��Clientes��6   .��5      �  � RowDefinitions 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      �� 5      .+�5      &   System.Windows.Controls.DataGrid  $��2��5         AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .    CanUserResizeColumns . 	   CanUserResizeRows	 .  
   CanUserSortColumns
 .    HorizontalGridLinesBrush
 ����    VerticalGridLinesBrush
 ����    AlternatingRowBackground
 �������5      ��  �� Path$ ListaPessoas� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��61      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5)   1   �� *
IdPessoa+  5*      $
 Nome��61    .  5,   1   �� *
NomePessoa+  5-      $	 CPF��61    .  5/   1   �� *Cpf+  50      $ 	Endereço��61    .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 580 53   1    52   1   �� *
Endereco+53   1   55      �� 57      $��2��6   $��2��58      $��Cadatrar cliente��59      $��50��5:      $	��100��5;      ��5<      �� *[CadastrarNovaPessoa]+5>      5?      5A      �� 5C      $��Produtos��6   .��5D      �  5E      �� 5F      �� 5G       5J      �� 5K      �� 5L      .+�5O        $��2��5P       .   .   .   .  . 	 .  
 . 
 ���� 
 ���� 
 �������5O      �� $ ListaProdutos�$ TwoWay=�$ PropertyChanged=� 5\        5]      $ Id��61    .  5_   5   �� *	IdProduto+  5`      $
 Nome��61    .  5b   5   �� *NomeProduto+  5c      $ Código��61    .  5e   5   �� *Codigo+  5f      $ Valor��61    .  5h   5   �� *Valor+5j      �� 5l      $��2��6   $��2��5m      $��Cadatrar produto��5n      $��50��5o      $	��100��5p      ��5q      �� *[CadastrarNovoProduto]+5r      5s      5u      �� 5w      $��Pedidos��6   .��5x      �  5z      �� 5{      �� 5|       5      �� 5�      �� 5�      .+�5�        $��2��5�       .   .   .   .  . 	 .  
 . 
 ���� 
 ���� 
 �������5�      �� $ ListaPedidos�$ TwoWay=�$ PropertyChanged=� 5�        5�      $ Id��61    .  5�   5   �� *
IdPessoa+  5�      $
 Nome��61    .  5�   5   �� *
NomePessoa+  5�      $	 CPF��61    .  5�   5   �� *Cpf+  5�      $ 	Endereço��61    .  5�   5   �� *
Endereco+5�      �� 5�      $��2��6   $��2��5�      $��Novo pedido��5�      $��50��5�      $	��100��5�      ��5�      �� *[CadastrarNovoPedido]+5�      5�      5�      5�      5�      5�      