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

            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            /*Member m = new Member();
            memberDAO.Create(m);
            Member member = memberDAO.Find(m.Id);*/

            Member member = memberDAO.Find(1);

            LbxMember.ItemsSource = new List<Member>
            {
                member
            };

            

            /*
            LbxMember.ItemsSource = new List<Member>
            {
                new Member {
                    Id = 1,
                    Name = "Martens",
                    FirstName = "Rémi",
                    Tel = 0492821292,
                    PassWord = "condorcet"
                },
                new Member {
                    Id = 2,
                    Name = "Volant",
                    FirstName = "Alexis",
                    Tel = 0482828288,
                    PassWord = "condorcet"
                }
            };
            */
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            int id, tel;
            float balance;
            string idString = textboxId.Text;
            string name = textboxName.Text;
            string firstname = textboxFirstName.Text;
            string telString = textboxTel.Text;
            string password = textboxPassWord.Text;
            string balanceString = textboxBalance.Text;

            int.TryParse(idString, out id);
            int.TryParse(telString, out tel);
            float.TryParse(balanceString, out balance);

            Member m = new Member(id, name, firstname, tel, password, balance);

            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            memberDAO.Create(m);

        }
    }
}
