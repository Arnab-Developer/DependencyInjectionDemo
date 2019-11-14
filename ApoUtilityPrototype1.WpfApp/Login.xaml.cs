using System.Windows;
using ApoUtilityPrototype1.WpfApp.ServiceProxies;

namespace ApoUtilityPrototype1.WpfApp
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            using (var proxy = new LoginServiceProxy())
            {
                var userAcount = new UserAccount
                    {
                        UserId = 1,
                        Name = TxtUserName.Text,
                        Password = TxtPassword.Text
                    };
                bool isValidUser = proxy.IsAuthenticUser(userAcount);
            }
        }

        private void BtnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            var newUserWindow = new CreateNewUser();
            Close();
            newUserWindow.Show();
        }
    }
}
