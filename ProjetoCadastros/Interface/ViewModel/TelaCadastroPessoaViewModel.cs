using ProjetoCadastros.Comuns;
using ProjetoCadastros.RegraDeNegocio;
using System.Windows;

namespace ProjetoCadastros.Interface.ViewModel
{
    public class TelaCadastroPessoaViewModel : ViewModelBase
    {        
        public PessoaDto DadosPessoa { get; set; }

        public TelaCadastroPessoaViewModel()
        {
            DadosPessoa = new PessoaDto();
            CriarComandos();
        }

        public void CriarComandos()
        {
            _comandos["CadastrarPessoa"] = new RelayCommand(x => CadastrarPessoa());
        }

        public void CadastrarPessoa()
        {

            DadosPessoa.Endereco = DadosPessoa.Rua + " - " + DadosPessoa.NumeroCasa + " - " + DadosPessoa.Complemento; 

            MessageBox.Show(DadosPessoa.Endereco);
        }
    }
}
