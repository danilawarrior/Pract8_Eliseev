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

namespace Pract8_Eliseev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Guy guy;
        Girl girl;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void add(object sender, RoutedEventArgs e)
        {
            if (man.IsChecked == true)
            {
                guy = new(nameTextBox.Text, lastNameTextBox.Text, Int32.Parse(ageTextBox.Text));
                ListBoxOfHumans.Items.Add(guy.ToString());
            }
            if (woman.IsChecked == true)
            {
                girl = new(nameTextBox.Text, lastNameTextBox.Text, Int32.Parse(ageTextBox.Text));
                ListBoxOfHumans.Items.Add(girl.ToString());
            }

        }

        private void About_Program(object sender, RoutedEventArgs e)
        {
            Guy guy = new("John", "", 1);
            Girl girl = new("Sahra", "", 1);

            MessageBox.Show( guy.Greetings(girl));
            MessageBox.Show(girl.Greetings(guy));
        }

        private void Exit(object sender, RoutedEventArgs e)
        {

        }

        private void greetings(object sender, RoutedEventArgs e)
        {
            var selectedObjects = ListBoxOfHumans.SelectedItems;
            if (selectedObjects.Count == 2)
            {
                if (selectedObjects[0].)
                {

                }

            }
        }
    }
}
