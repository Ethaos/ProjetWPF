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
        Member m = null;
        List<Category> listCategory = new List<Category>();
        public MemberPage(Member member)
        {
            InitializeComponent();
            m = member;
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            DAO<Category> categoryDAO = adf.GetCategoryDAO();
            DAO<Bike> bikeDAO = adf.GetBikeDAO();

            listCategory = categoryDAO.FindBy(member.Id);
            LbxCatMember.ItemsSource = listCategory;

            List<Bike> listBike = bikeDAO.FindBy(member.Id);
            LbxBikes.ItemsSource = listBike;

            List<Category> listCat = categoryDAO.FindAll();
            //LbxDisplayCategories.ItemsSource = listCat;
        }

        private void Refresh()
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Category> categoryDAO = adf.GetCategoryDAO();
            List<Category> listCateg = categoryDAO.FindBy(m.Id);
            LbxCatMember.ItemsSource = listCateg;
        }

        private void AddCatClick(object sender, RoutedEventArgs e)
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            DAO<Category> categoryDAO = adf.GetCategoryDAO();

            int idCategory;
            /*string idString = textboxAddCategory.Text;
            int.TryParse(idString, out idCategory);
            bool inside = false;

            foreach (Category category in listCategory)
            {
                if (category.Num == idCategory)
                {
                    inside = true;
                }
            }

            if (listCategory.Count >= 4)
            {
                MessageBox.Show("You are already in all the categories.");
            }
            else if (inside)
            {
                MessageBox.Show("You are already in this categories.");
            }
            else 
            {
                memberDAO.Add(m.Id, idCategory);
                listCategory.Add(categoryDAO.Find(idCategory));
                Refresh();
            }

            */
        }
    }
}
