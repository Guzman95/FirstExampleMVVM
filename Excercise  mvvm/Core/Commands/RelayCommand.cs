using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Excercise__mvvm.Core.Commands
{
    class RelayCommand : ICommand
    {
        private Action _action;
        private readonly Func<bool> _canexecute;

        public RelayCommand(Action accion, Func<bool> canExecute)
        {
            _action = accion;
            _canexecute = canExecute;
        }

        public RelayCommand(Action action)
        {
            this._action = action;
            this._canexecute = () => true;
        }
        public bool CanExecute(object parameter)
        {
            bool result = this._canexecute.Invoke();
            return result;
        }
        public void Execute(object parameter)
        {
            this._action.Invoke();
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
