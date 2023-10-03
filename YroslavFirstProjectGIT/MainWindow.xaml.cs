using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace YroslavFirstProjectGIT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Password;

            

            MessageBox.Show($"Login successful!\nUsername: {username}", "Success");
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = txtRegisterUsername.Text;
            string password = txtRegisterPassword.Password;
            string confirmPassword = txtRegisterConfirmPassword.Password;

            if (true)
            {
                MessageBox.Show($"Registration successful!\nUsername: {username}\nPassword: {password}", "Success");
            }


           
        }
    }
}
