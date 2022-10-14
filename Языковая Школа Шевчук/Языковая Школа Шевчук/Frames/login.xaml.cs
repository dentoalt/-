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
using Языковая_Школа_Шевчук.Appdata;
using Языковая_Школа_Шевчук.Frames;
using Языковая_Школа_Шевчук;

namespace Языковая_Школа_Шевчук.Appdata
{
    /// <summary>
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (passwordAdm.Password == "0000")
            {
                AppFrame.frameMain.Navigate(new Admin());
                
            }
            else
            {
                MessageBox.Show("Пароль введен не верно");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new Quest());
        }
    }
}
