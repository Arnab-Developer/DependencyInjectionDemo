using ApoUtilityPrototype1.WpfApp.ServiceProxies;
using System.Windows;

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
