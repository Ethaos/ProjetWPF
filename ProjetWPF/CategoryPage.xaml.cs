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
    /// Interaction logic for CategoryPage.xaml
    /// </summary>
    public partial class CategoryPage : Page
    {
        public CategoryPage()
        {
            InitializeComponent();
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Category> categoryDAO = adf.GetCategoryDAO();
            List<Category> listCategory = categoryDAO.FindAll();
            LbxCategoryAll.ItemsSource = listCategory;
        }
        
        private void CategoryUniqueClick(object sender, RoutedEventArgs e)
        {
            int id;
            string idString = textboxCategoryUnique.Text;
            int.TryParse(idString, out id);

            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Category> categoryDAO = adf.GetCategoryDAO();
            Category cat = categoryDAO.Find(id);
            List<Category> listCategory = new List<Category>();
            listCategory.Add(cat);
            LbxCategoryUnique.ItemsSource = listCategory;
        }
    }
}
