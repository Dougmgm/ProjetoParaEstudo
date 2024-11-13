using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastros.RegraDeNegocio
{
    public class PessoaDto
    {
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public int? NumeroCasa { get; set; }
        public string Complemento { get; set; }    
    }
}
