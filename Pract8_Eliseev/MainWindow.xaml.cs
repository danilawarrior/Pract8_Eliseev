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
                ListBoxOfHumans.Items.Add(guy);
            }
            if (woman.IsChecked == true)
            {
                girl = new(nameTextBox.Text, lastNameTextBox.Text, Int32.Parse(ageTextBox.Text));
                ListBoxOfHumans.Items.Add(girl);
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
            var selectedHumans = ListBoxOfHumans.SelectedItems;
            var greetings = new StringBuilder();

            IHuman greeter = selectedHumans[0] as IHuman;

            foreach (var human in selectedHumans.Cast<IHuman>().Skip(1))
            {
                greetings.AppendLine(greeter.Greetings(human)); 
            }

            MessageBox.Show(greetings.ToString());

            //if (selectedObjects.Count == 2)
            //{

            //    IHuman human1 = selectedObjects[0] as IHuman;
            //    IHuman human2 = selectedObjects[1] as IHuman;

            //    MessageBox.Show(human1.Greetings(human2));
                

            //}
        }

        private void compare(object sender, RoutedEventArgs e)
        {
            var selectedHumans = ListBoxOfHumans.SelectedItems;
            if (selectedHumans.Count == 2)
            {
                Guy guy1 = selectedHumans[0] as Guy;
                Guy guy2 = selectedHumans[1] as Guy;
                if (guy1.CompareTo(guy2) == 0)
                {
                    MessageBox.Show("йоу, два одинаковых чела");
                }
                if (guy1.CompareTo(guy2) > 0)
                {
                    MessageBox.Show("первый выбранный  больше второго");
                }
                else
                {
                    MessageBox.Show("первый выбранный  меньше второго");
                }
                
            }
        }
    }
}
