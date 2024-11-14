using ProjetoCadastros.Interface.ViewModel;
using System.Windows;

namespace ProjetoCadastros.Interface
{
    /// <summary>
    /// Interaction logic for TelaPessoa.xaml
    /// </summary>
    public partial class TelaCadastroPessoa : Window
    {
        public TelaCadastroPessoa()
        {
            InitializeComponent();
            this.DataContext = new TelaCadastroPessoaViewModel();
        }
    }
}
