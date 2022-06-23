using ProjetWPF.Factory;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ProjetWPF
{
    /// <summary>
    /// Interaction logic for MemberPage.xaml
    /// </summary>
    public partial class MemberPage : Page
    {
        Member m = null;
        List<Category> listCategory = new List<Category>();
        List<Category> listCategoryAll = new List<Category>();
        int idCategory = 0;

        public MemberPage(Member member)
        {
            InitializeComponent();
            m = member;
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            DAO<Category> categoryDAO = adf.GetCategoryDAO();
            DAO<Bike> bikeDAO = adf.GetBikeDAO();
            DAO<Ride> rideDAO = adf.GetRideDAO();

            listCategory = categoryDAO.FindBy(member.Id);
            LbxCatMember.ItemsSource = listCategory;

            List<Bike> listBike = bikeDAO.FindBy(member.Id);
            LbxBikes.ItemsSource = listBike;

            List<Category> listCat = categoryDAO.FindAll();
            CatChoise.ItemsSource = listCat;

            List<Ride> listRide = rideDAO.FindByMember(m.Id);
            LbxRides.ItemsSource = listRide;

            listCategoryAll = listCat;
        }

        private void Refresh()
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Category> categoryDAO = adf.GetCategoryDAO();
            List<Category> listCateg = categoryDAO.FindBy(m.Id);
            LbxCatMember.ItemsSource = listCateg;
        }
        private void CatChoise_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int cbo = CatChoise.SelectedIndex;
            idCategory = cbo + 1;
        }
        private void AddCatClick(object sender, RoutedEventArgs e)
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            DAO<Category> categoryDAO = adf.GetCategoryDAO();
            
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
        }
    }
}
