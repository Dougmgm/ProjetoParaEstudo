using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjetoCadastros.Interface.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public readonly Dictionary<string, ICommand> _comandos = new Dictionary<string, ICommand>();

        public ICommand this[string commandName] => _comandos.ContainsKey(commandName) ? _comandos[commandName] : null;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
