using Regex_lekontsev.Classes;
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

namespace Regex_lekontsev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal static object init;

        public List<Classes.Passport> Passports = new List<Classes.Passport>();

        public MainWindow()
        {
            InitializeComponent();
            init = this;
        }

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Add(object sender, RoutedEventArgs e) =>
            new Windows.Add(null).ShowDialog();
        private void Update(object sender, RoutedEventArgs e)
        {
            if (lv_passport.SelectedIndex > -1)
                new Windows.Add(lv_passport.SelectedItem as Classes.Passport).ShowDialog();
            else
                MessageBox.Show("Выберите элемент для изменения");
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (lv_passport.SelectedIndex > -1)
            {
                Passports.Remove(lv_passport.SelectedItem as Classes.Passport);
                LoadPassport();
            }
            else
                MessageBox.Show("Выберите элемент для удаленияя");
        }
        public void LoadPassport()
        {

       

        lv_passport.Items.Clear();
            foreach (Classes.Passport Passport in Passports)
                lv_passport.Items.Add(Passport);
        }
    }
}
