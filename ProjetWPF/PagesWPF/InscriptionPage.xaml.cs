using ProjetWPF.DAO;
using ProjetWPF.Factory;
using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ProjetWPF.PagesWPF
{
    /// <summary>
    /// Interaction logic for InscriptionPage.xaml
    /// </summary>
    public partial class InscriptionPage : Page
    {
        Member m = null;
        int passenger=0, bike=0;
        List<Ride> listR = new List<Ride>();
        bool check = false;
        public InscriptionPage(Member member)
        {
            InitializeComponent();
            m = member;
            CarOption.Visibility = Visibility.Hidden;
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            DAO<Category> categoryDAO = adf.GetCategoryDAO();
            List<Category> listCat = categoryDAO.FindBy(m.Id);
            CatChoise.ItemsSource = listCat;
        }

        private void CatChoise_SelectionChanged(object sender, RoutedEventArgs e)
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Ride> rideDAO = adf.GetRideDAO();
           
            int idCategory = CatChoise.SelectedIndex;
            idCategory++;
            
            List<Ride> listRide = rideDAO.FindBy(idCategory);
            LbxRides.ItemsSource = listRide;
            listR = listRide;
        }

        private void RideChoise_SelectionChanged(object sender, RoutedEventArgs e)
        {

            int idOrder = LbxRides.SelectedIndex;
            Ride r = listR[idOrder];
            int idRide = r.Num;
            string id = idRide.ToString();
            textBoxRide.Text = id;
            
            
            
        
        }

        private void passengerChecked(object sender, RoutedEventArgs e)
        {
            if(checkBoxPassenger.IsChecked == true)
            {
                passenger = 1;
                bike = 1;
                check = true;
                checkBoxDriver.IsChecked = false;
            }
            else if(checkBoxPassenger.IsChecked == false){
                passenger = 0;
                bike = 0;
                check = false;
                checkBoxDriver.IsChecked = true;
            }
        }
        private void driverChecked(object sender, RoutedEventArgs e)
        {
            if (checkBoxDriver.IsChecked==true)
            {
                passenger = 0;
                bike = 0;
                check = false;
                CarOption.Visibility = Visibility.Visible;
                checkBoxPassenger.IsChecked = false;
            }
            else if (checkBoxDriver.IsChecked == false)
            {
                passenger = 1;
                bike = 1;
                check = true;
                CarOption.Visibility = Visibility.Hidden;
                checkBoxPassenger.IsChecked = true;
            }
        }

        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Inscription> inscriptionDAO = adf.GetInscriptionDAO();
            DAO<Vehicle> vehicleDAO = adf.GetVehicleDAO();

            List<Inscription> listInscription = inscriptionDAO.FindBy(m.Id);
            bool inside = false;
            int idRideChoose; 
            string rideString = textBoxRide.Text;
            int.TryParse(rideString, out idRideChoose);

            foreach (Inscription inscription in listInscription)
            {
                if (inscription.Ride == idRideChoose)
                {
                    inside = true;
                }
            }
            if(check)
            {
                if (inside)
                {
                    MessageBox.Show("You are already registered to this ride.");
                }
                else
                {
                    Inscription i = new Inscription(m.Id, idRideChoose, passenger, bike);

                    inscriptionDAO.Create(i);
                    MessageBox.Show("Inscription as passenger succès");
                }
            }else if (!check)
            {
                if (inside)
                {
                    MessageBox.Show("You are already registered to this ride.");
                }
                else
                {
                    Inscription i = new Inscription(m.Id, idRideChoose, passenger, bike);

                    int pMembers, pBikes;
                    string pmString = textBoxMembers.Text;
                    string pbString = textBoxBikes.Text;
                    int.TryParse(pmString, out pMembers);
                    int.TryParse(pbString, out pBikes);
                    Vehicle v = new Vehicle(pMembers, pBikes, m.Id, idRideChoose);
                    vehicleDAO.Create(v);
                    inscriptionDAO.Create(i);
                    MessageBox.Show("Inscription as driver succès");
                }
            }
        }
    }
}
