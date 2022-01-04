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
            Member m = memberDAO.Find(2);

            DAO<Category> categoryDAO = adf.GetCategoryDAO();
            List<Category> listCategory = categoryDAO.FindBy(m.Id);

            LbxCatMember.ItemsSource = listCategory;

            List<Category> listCat = categoryDAO.FindAll();
            LbxDisplayCategories.ItemsSource = listCat;
        }

        private void Refresh()
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            Member m = memberDAO.Find(2);
            DAO<Category> categoryDAO = adf.GetCategoryDAO();
            List<Category> listCategory = categoryDAO.FindBy(m.Id);
            LbxCatMember.ItemsSource = listCategory;
        }

        private void AddCatClick(object sender, RoutedEventArgs e)
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            Member m = memberDAO.Find(2);

            int idCategory;
            string idString = textboxAddCategory.Text;

            int.TryParse(idString, out idCategory);

            memberDAO.Add(m.Id, idCategory);

            Refresh();
        }
    }
}
