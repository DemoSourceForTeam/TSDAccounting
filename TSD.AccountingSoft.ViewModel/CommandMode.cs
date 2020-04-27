using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Input;

namespace TSD.AccountingSoft.ViewModel
{
    public abstract class CommandModel 
    {
        public CommandModel()
        {
            Command = new RoutedUICommand();
        }

        // gets the routed command

        public RoutedUICommand Command { private set; get; }

        // abstract method to execute the command. Needs implementation.

        public abstract void OnExecute(object sender, ExecutedRoutedEventArgs e);


        // determines if a command is enabled. Override to provide custom behavior
        // do not call the base version when overriding

        public virtual void OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
            e.Handled = true;
        }
    }
}
