using ProjetWPF.DAO;
using ProjetWPF.Factory;
using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for MemberPage.xaml
    /// </summary>
    public partial class MemberPage : Page
    {
        public MemberPage()
        {
            InitializeComponent();
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            Member m = memberDAO.Find(1);

            DAO<Category> categoryDAO = adf.GetCategoryDAO();
            List<Category> listCategory = categoryDAO.FindBy(m.Id);

            LbxCatMember.ItemsSource = listCategory; 



            /*AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            List<Member> listMember = memberDAO.FindAll();
            LbxMember.ItemsSource = listMember;*/
        }
        /*
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            int id, tel;
            float balance;
            string idString = textboxId.Text;
            string name = textboxName.Text;
            string firstname = textboxFirstName.Text;
            string telString = textboxTel.Text;
            string login = textboxLogin.Text;
            string password = textboxPassWord.Text;
            string balanceString = textboxBalance.Text;

            int.TryParse(idString, out id);
            int.TryParse(telString, out tel);
            float.TryParse(balanceString, out balance);

            Member m = new Member(id, name, firstname, tel, login,password, balance);

            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            memberDAO.Create(m);
            Refresh();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            int id;
            string idString = textboxDeleteId.Text;
            int.TryParse(idString, out id);

            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            Member m = memberDAO.Find(id);
            memberDAO.Delete(m);
            Refresh();

        }

        private void Refresh()
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            List<Member> listMember = memberDAO.FindAll();
            LbxMember.ItemsSource = listMember;
        }

        */
    }
}
