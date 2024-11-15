﻿using ProjetoCadastros.Comuns;
using ProjetoCadastros.RegraDeNegocio;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace ProjetoCadastros.Interface.ViewModel
{
    public class TelaCadastroProdutoViewModel : ViewModelBase
    {
        public TelaCadastroProdutoViewModel()
        {
            DadosProduto = new ProdutoDto();
            CriarComandos();
        }

        public ProdutoDto DadosProduto { get; set; }

        private void CriarComandos()
        {
            _comandos["CadastrarProduto"] = new RelayCommand(x => CadastrarProduto());
        }

        private void CadastrarProduto()
        {
            var teste = DadosProduto.NomeProduto + " " + DadosProduto.Codigo + " " + DadosProduto.Valor.ToString();
            MessageBox.Show(teste);
        }
    }
}
