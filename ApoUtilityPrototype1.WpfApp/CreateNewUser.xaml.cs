using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ApoUtilityPrototype1.WpfApp.ServiceProxies;

namespace ApoUtilityPrototype1.WpfApp
{
    /// <summary>
    /// Interaction logic for CreateNewUser.xaml
    /// </summary>
    public partial class CreateNewUser : Window
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void BtnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            using (var proxy = new LoginServiceProxy())
            {
                var userAcount = new UserAccount
                {
                    Name = TxtUserName.Text,
                    Password = TxtPassword.Text
                };
                bool isCreateUserSuccessful = proxy.CreateUser(userAcount);
            }
        }
    }
}
