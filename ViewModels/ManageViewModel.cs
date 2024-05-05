using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfPractice.Command;

namespace WpfPractice.ViewModels
{
    internal class ManageViewModel
    {
        public ICommand ShowMenuDemo {  get; set; }

        public ManageViewModel() {
            ShowMenuDemo = new CommandWindow(ShowMenu, CanShowMenu);
        }

        private void ShowMenu(object parameter)
        {
            if(parameter.ToString() == "Hello")
            {
                MessageBox.Show("Hello");
            }
        }

        private bool CanShowMenu(object parameter)
        {
            return true;
        }
    }
}
