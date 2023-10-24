using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
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
using FirstTaskWpfApp.Validators;

namespace FirstTaskWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public string UserName { get; set; } = "";
        public string UserStrAge { get; set; } = "";

        public string UserAddress { get; set; } = "ul. Majowa 5, Kielce";

        private string message = "";
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                OnPropertyChanged(nameof(Message));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /*
         DRY
         KISS
         YAGNI
         SOLID
         S - single responsibility - pojedyńcza odpowiedzialność
         O - open/close - otwarty/zamknięty - otwarta na rozszeżenia a zamknięta na modyfikacje
         */
        private void ButtonExecute_Click(object sender, RoutedEventArgs e)
        {
            string message;
            Validate validate = new Validate();
            if (validate.Validation(UserName, UserStrAge, UserAddress, out message))
                Message = "Witaj " + UserName + ". Jesteś " + ((int.Parse(UserStrAge) >= 18) ? "pełnoletni" : "niepełnoletni");
            else
                Message = message;
        }


        private bool Validate(string userName, string userStrAge, string userAddress, out string message)
        {
            if (!ValidationValueEmpty(userName, out message))
            {
                message = "[Imię] " + message;
                return false;
            }

            if (!ValidationValueEmpty(userStrAge, out message))
            {
                message = "[Wiek] " + message;
                return false;
            }

            if (!ValidationValueEmpty(userAddress, out message))
            {
                message = "[Adres] " + message;
                return false;
            }

            message = "";
            return true;
        }

        private bool ValidationValueEmpty(string value, out string message)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                message = "Nie podałeś wartości";
                return false;
            }
            message = "";
            return true;
        }
    }
}
