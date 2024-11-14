using ProjetoCadastros.Comuns;
using ProjetoCadastros.RegraDeNegocio;
using System.Collections.Generic;
using System.Windows.Input;

namespace ProjetoCadastros.Interface.ViewModel
{
    public class TelaPrincipalViewModel : ViewModelBase
    {
        private readonly Dictionary<string, ICommand> _comandos = new Dictionary<string, ICommand>();

        public ICommand this[string commandName] => _comandos.ContainsKey(commandName) ? _comandos[commandName] : null;

        public List<PessoaDto> ListaPessoas { get; set; }
        public List<ProdutoDto> ListaProdutos { get; set; }
        public List<PedidoDto> ListaPedidos { get; set; }

        public TelaPrincipalViewModel()
        {
            CriarComandos();
            CarregarDados();
        }
        
        private void CriarComandos()
        {
            _comandos["CadastrarNovaPessoa"] = new RelayCommand(x => CadastrarNovaPessoa());
        }

        private void CarregarDados()
        {
            ListaPessoas = ObterListaPessoas();
            ListaProdutos = ObterListaProdutos();
            //ListaPedidos = ObterListaPedidos();
        }

        public List<PessoaDto> ObterListaPessoas()
        {
            return new List<PessoaDto>
        {
            new PessoaDto
            {
                IdPessoa = 1,
                NomePessoa = "João Silva",
                Cpf = "123.456.789-00",
                Endereco = "Rua das Flores",
                Rua = "Flores",
                Cep = "12345-678",
                NumeroCasa = 10,
                Complemento = "Apto 101"
            },
            new PessoaDto
            {
                IdPessoa = 2,
                NomePessoa = "Maria Oliveira",
                Cpf = "987.654.321-00",
                Endereco = "Avenida Central",
                Rua = "Central",
                Cep = "98765-432",
                NumeroCasa = 23,
                Complemento = "Casa"
            },
            new PessoaDto
            {
                IdPessoa = 3,
                NomePessoa = "Carlos Pereira",
                Cpf = "456.123.789-00",
                Endereco = "Rua das Palmeiras",
                Rua = "Palmeiras",
                Cep = "45678-123",
                NumeroCasa = 45,
                Complemento = "Sobrado"
            },
            new PessoaDto
            {
                IdPessoa = 4,
                NomePessoa = "Ana Costa",
                Cpf = "789.123.456-00",
                Endereco = "Travessa das Américas",
                Rua = "Américas",
                Cep = "87654-321",
                NumeroCasa = 50,
                Complemento = "Loft"
            },
            new PessoaDto
            {
                IdPessoa = 5,
                NomePessoa = "Pedro Santos",
                Cpf = "321.654.987-00",
                Endereco = "Alameda dos Pinhais",
                Rua = "Pinhais",
                Cep = "65432-198",
                NumeroCasa = 15,
                Complemento = "Casa de esquina"
            }
        };
        }

        public List<ProdutoDto> ObterListaProdutos()
        {
            return new List<ProdutoDto>
        {
            new ProdutoDto
            {
                IdProduto = 1,
                NomeProduto = "Cadeira Gamer",
                Codigo = 1001,
                Valor = 599.90
            },
            new ProdutoDto
            {
                IdProduto = 2,
                NomeProduto = "Monitor LED 24''",
                Codigo = 1002,
                Valor = 899.99
            },
            new ProdutoDto
            {
                IdProduto = 3,
                NomeProduto = "Teclado Mecânico",
                Codigo = 1003,
                Valor = 350.75
            },
            new ProdutoDto
            {
                IdProduto = 4,
                NomeProduto = "Mouse Gamer",
                Codigo = 1004,
                Valor = 120.45
            },
            new ProdutoDto
            {
                IdProduto = 5,
                NomeProduto = "Headset",
                Codigo = 1005,
                Valor = 199.90
            }
        };
        }

        private void CadastrarNovaPessoa()
        {            
            var formCadastrarPessoa = new TelaCadastroPessoa();

            formCadastrarPessoa.ShowDialog();
        }        
    }
}
