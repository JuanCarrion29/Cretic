using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YHLQMDLG.MVVM.VistaModelo
{
    public class RRelayCommand : ICommand
    {
        private readonly Action<object> _executeAction;

        private readonly Predicate<object> _caneExcuteAction;

        public RRelayCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
            _caneExcuteAction = null;
        }


        public RRelayCommand(Action<object> executeAction, Predicate<object> caneExcuteAction)
        {
            _executeAction = executeAction;
            _caneExcuteAction = caneExcuteAction;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }


        }

        public bool CanExecute(object parameter)
        {

            return _caneExcuteAction == null ? true : _caneExcuteAction(parameter);

        }

        public void Execute(object parameter)
        {

            _executeAction(parameter);


        }

    }
}
