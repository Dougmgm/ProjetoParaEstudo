using ProjetoCadastros.Comuns;
using ProjetoCadastros.RegraDeNegocio;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace ProjetoCadastros.Interface.ViewModel
{
    public class TelaCadastroPessoaViewModel : ViewModelBase
    {
        private readonly Dictionary<string, ICommand> _comandos = new Dictionary<string, ICommand>();

        public ICommand this[string commandName] => _comandos.ContainsKey(commandName) ? _comandos[commandName] : null;

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
