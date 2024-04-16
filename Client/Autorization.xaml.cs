using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Net;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Dictionary<string, string> people = new Dictionary<string, string>()
        {
            {"Kim", "123" },
            {"Glgen", "12345" }
        };
        public Autorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string login = LoginText.Text.ToString();
            string password = Password.Password;
            if (!people.Contains(new KeyValuePair<string, string>(login, password)))
            {
                error_massage.Visibility = Visibility.Visible;
            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}