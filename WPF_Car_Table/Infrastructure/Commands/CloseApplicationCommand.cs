using System.Windows;
using WPF_Car_Table.Infrastructure.Commands.Base;

namespace WPF_Car_Table.Infrastructure.Commands
{
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
