using ProjetWPF.DAO;
using ProjetWPF.Factory;
using ProjetWPF.Metier;

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

namespace ProjetWPF
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

        private void MemberClick(object sender, RoutedEventArgs e)
        {
            //Main.Content = new MemberPage();
        }

        private void CategoryClick(object sender, RoutedEventArgs e)
        {
            //Main.Content = new CategoryPage();
        }

        private void ResponsibleClick(object sender, RoutedEventArgs e)
        {
            //Main.Content = new ResponsiblePage();
        }
    }
}
