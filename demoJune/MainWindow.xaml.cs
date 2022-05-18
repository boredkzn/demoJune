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

namespace demoJune
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Edit edit;
        ProizvodstvoEntities ProizvodstvoEntities = new ProizvodstvoEntities();
        public MainWindow()
        {
            InitializeComponent();
            sii.ItemsSource = ProizvodstvoEntities.Agent.ToList();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var variable = (sender as Button).DataContext as Agent;
            edit = new Edit(variable);
            edit.Show();
        }
    }
}
