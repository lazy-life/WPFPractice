using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfPractice.Command;
using WpfPractice.Models;
using WpfPractice.Views;

namespace WpfPractice.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        #region Command
        public ICommand ButtonRedirect {  get; set; }
        #endregion

        #region Constructor
        public HomeViewModel() {
            ButtonRedirect = new CommandWindow(CloseWindow, CanCloseWindow);
        }

        private bool CanCloseWindow(object parameter)
        {
            // Kiểm tra xem parameter có phải là một cửa sổ (Window) hay không
            return parameter is Window;
        }

        private void CloseWindow(object parameter)
        {
            ManageView manageView = new ManageView();
            manageView.Show();
            using(DatabaseContext context = new DatabaseContext())
            {
                User us = new User();
                us.UserName = "Hello";
                us.UserEmail = "ddduc@gmail.com";
                us.UserAge = 30;
                context.Users.Add(us);
                context.SaveChanges();
            }
            if (parameter is Window window)
            {
                // Kiểm tra xem parameter có phải là một cửa sổ (Window) hay không
                window.Close();
            }
        }
        #endregion
    }
}
