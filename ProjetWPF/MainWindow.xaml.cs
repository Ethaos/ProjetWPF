using ProjetWPF.DAO;
using ProjetWPF.Factory;
using ProjetWPF.Metier;
using ProjetWPF.PagesWPF;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        bool check;
        Member m = null;
        public MainWindow()
        {
            InitializeComponent();
            Disconnect.Visibility = Visibility.Hidden;
            Inscription.Visibility = Visibility.Hidden;
            Back.Visibility = Visibility.Hidden;
        }

        private void loginClick(object sender, RoutedEventArgs e)
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            string password = boxPassword.Password;
            string login = boxLogin.Text;

            if (check == false)
            {
                DAO<Member> memberDAO = adf.GetMemberDAO();
                Member member = memberDAO.LoginCheck(login, password);
                if (member == null)
                {
                    MessageBox.Show("Error Member not found.");
                }
                else
                {
                    m = member;
                    Main.Content = null;
                    Main.Content = new MemberPage(member);
                    LoginGrid.Visibility = Visibility.Hidden;
                    boxLogin.Text = String.Empty;
                    boxPassword.Password = String.Empty;
                    Disconnect.Visibility = Visibility.Visible;
                    Inscription.Visibility = Visibility.Visible;
                }
            }
            else if (check == true)
            {
                DAO<Responsible> responsibleDAO = adf.GetResponsibleDAO();
                Responsible responsible = responsibleDAO.LoginCheck(login, password);
                if (responsible == null)
                {
                    MessageBox.Show("Error Responsible not found.");
                }
                else
                {
                    Main.Content = null;
                    Main.Content = new ResponsiblePage(responsible);
                    LoginGrid.Visibility = Visibility.Hidden;
                    boxLogin.Text = String.Empty;
                    boxPassword.Password = String.Empty;
                    Disconnect.Visibility = Visibility.Visible;
                }
            }
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            Main.Content = null;
            Main.Content = new MemberPage(m);
            Disconnect.Visibility = Visibility.Visible;
            Inscription.Visibility = Visibility.Visible;
            Back.Visibility = Visibility.Hidden;
        }

        private void InscriptionClick(object sender, RoutedEventArgs e)
        {
            Main.Content = null;
            Main.Content = new InscriptionPage(m);
            Disconnect.Visibility = Visibility.Hidden;
            Inscription.Visibility = Visibility.Hidden;
            Back.Visibility = Visibility.Visible;
        }

        private void disconnectClick(object sender, RoutedEventArgs e)
        {
            Main.Content = null;
            LoginGrid.Visibility = Visibility.Visible;
            Disconnect.Visibility = Visibility.Hidden;
            Inscription.Visibility = Visibility.Hidden;
        }

        private void Choice_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
            ComboBoxItem cbo = ((sender as ComboBox).SelectedItem as ComboBoxItem);

            string value = cbo.Content.ToString();

            if (value == "Member")
            {
                check = false;
            }
            else if (value == "Responsible")
            {
                check = true;
            }
            
          
           
        }
    }
}
