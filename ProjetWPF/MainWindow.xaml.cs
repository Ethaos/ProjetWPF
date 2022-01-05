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
        bool check;
        public MainWindow()
        {
            InitializeComponent();
            Disconnect.Visibility = Visibility.Hidden;
        }

        private void loginClick(object sender, RoutedEventArgs e)
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            string password = boxPassword.Password;
            string login = boxLogin.Text;

            if (check == true)
            {
                DAO<Member> memberDAO = adf.GetMemberDAO();
                Member member = memberDAO.LoginCheck(login, password);
                if (member == null)
                {
                    MessageBox.Show("Error Member not found.");
                }
                else
                {
                    Main.Content = null;
                    Main.Content = new MemberPage(member);
                    LoginGrid.Visibility = Visibility.Hidden;
                    boxLogin.Text = String.Empty;
                    boxPassword.Password = String.Empty;
                    Disconnect.Visibility = Visibility.Visible;
                }
            }
            else if (check == false)
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

        private void memberClick(object sender, RoutedEventArgs e)
        {
            check = true;
        }

        private void responsibleClick(object sender, RoutedEventArgs e)
        {
            check = false;
        }

        private void disconnectClick(object sender, RoutedEventArgs e)
        {
            Main.Content = null;
            LoginGrid.Visibility = Visibility.Visible;
            Disconnect.Visibility = Visibility.Hidden;
        }
    }
}
