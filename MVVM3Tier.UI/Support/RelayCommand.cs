using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM3Tier.UI.Support
{
   public class RelayCommand : ICommand
   {
      // the action to execute
      private Action<object> _execute;
      // if the action can execute
      private Predicate<object> _canExecute;

      public RelayCommand(Action<object> execute, Predicate<object> canExecute)
      {
         if (execute == null)
            throw new ArgumentException("execute");
         _execute = execute;
         _canExecute = canExecute;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="parameter"></param>
      /// <returns></returns>
      public bool CanExecute(object parameter)
      {
         return _canExecute == null ? true : _canExecute(parameter);
      }

      public void Execute(object parameter)
      {
         _execute(parameter);
      }

      public event EventHandler CanExecuteChanged
      {
         add
         {
            if (_canExecute != null)
               CommandManager.RequerySuggested += value;
         }
         remove
         {
            if (_canExecute != null)
               CommandManager.RequerySuggested -= value;
         }
      }
   }
}
