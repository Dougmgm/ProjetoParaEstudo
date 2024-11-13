﻿using ProjetoCadastros.Interface.ViewModel;
using System.Windows;

namespace ProjetoCadastros.Interface
{
    /// <summary>
    /// Interaction logic for TelaPrincipal.xaml
    /// </summary>
    public partial class TelaPrincipal : Window
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            DataContext = new TelaPrincipalViewModel();
        }
    }
}
