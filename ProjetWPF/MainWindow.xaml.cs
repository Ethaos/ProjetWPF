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
            LbxPerson.ItemsSource = new List<Person>
            {
                new Person {
                    Id = 1,
                    Name = "Martens",
                    FirstName = "Rémi",
                    Tel = 0492821292,
                    PassWord = "condorcet"
                },
                new Person {
                    Id = 2,
                    Name = "Volant",
                    FirstName = "Alexis",
                    Tel = 0482828288,
                    PassWord = "condorcet"
                }
            };
        }
    }
}
