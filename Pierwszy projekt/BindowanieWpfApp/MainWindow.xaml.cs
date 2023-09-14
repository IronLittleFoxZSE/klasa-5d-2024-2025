using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace BindowanieWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public string SourceValue { get; set; }

        //propertisy do obsługo zadania z dniem tygodnia
        public string StringNumberOfWeek { get; set; }

        private string nameDayOfWeek;
        public string NameDayOfWeek 
        {
            get
            {
                return nameDayOfWeek;
            } 
            set
            {
                nameDayOfWeek = value;
                //OnPropertyChanged("NameDayOfWeek");
                //OnPropertyChanged(nameof(NameDayOfWeek));
                OnPropertyChanged();
            }
        }

        private string dana;

        public string Dana
        {
            get { return dana; }
            set 
            { 
                dana = value;
                OnPropertyChanged();
            }
        }

        public string Czesc
        {
            get { return Dana[0].ToString(); }
        }



        public MainWindow()
        {
            InitializeComponent();
        }

        #region informowanie bindowania

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string value = textBoxInfo.Text;
            textBlockWynik.Text = value;
        }

        private void textBoxInfo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string value = textBoxInfo.Text;
            textBlockWynik.Text = value;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("zawartość: " + SourceValue);
        }

        private void ButtonShowDayOfWeek_Click(object sender, RoutedEventArgs e)
        {
            switch(StringNumberOfWeek)
            {
                case "1":
                    NameDayOfWeek = "Poniedziałek";
                    //OnPropertyChanged("NameDayOfWeek");
                    break;
                case "2":
                    NameDayOfWeek = "Wtorek";
                    //OnPropertyChanged("NameDayOfWeek");
                    break;
                case "3":
                    NameDayOfWeek = "Środa";
                    //OnPropertyChanged(nameof(NameDayOfWeek));
                    break;
                default:
                    NameDayOfWeek = "Zła dana";
                    break;  
            }
        }
    }
}
