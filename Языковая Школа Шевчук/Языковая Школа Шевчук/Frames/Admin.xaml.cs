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
using Языковая_Школа_Шевчук.Frames;

namespace Языковая_Школа_Шевчук.Appdata
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void AwShitHireWeGoAgain(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new login());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Change change = new Change();
            change.Show();
        }
    }
}
