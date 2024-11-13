using ProjetoCadastros.Interface.ViewModel;
using System.Windows;

namespace ProjetoCadastros.Interface
{
    /// <summary>
    /// Lógica interna para TelaCadastroProduto.xaml
    /// </summary>
    public partial class TelaCadastroProduto : Window
    {
        public TelaCadastroProduto()
        {
            InitializeComponent();
            DataContext = new TelaCadastroProdutoViewModel();
        }
    }
}
